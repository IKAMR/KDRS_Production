using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KDRS_Production
{
    public class Log
    {

        //-------------------------------------------------------------------------------

        public void LogInfoXml(string dbPath, List<InfoXml> infoXml)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

            }
            string dataSource = @"Data Source=" + dbPath + ";Pooling=true;FailIfMissing=false;Version=3";

            Console.WriteLine("Data source: {0}", dataSource);

            using (SQLiteConnection connection = new SQLiteConnection(dataSource))
            {
                SQLiteCommand sqlite_cmd;
                string tableName = "info_xml";
                connection.Open();


                if (!TableExists(connection, tableName))
                {
                    Console.WriteLine("Create table");
                    string[] columns = { "id", "name", "value", "edited_value"};
                    CreateTable(tableName, columns, connection);
                }

                /*string getID = "SELECT MAX(ID) FROM " + tableName + ";";

                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = getID;
                logID = sqlite_cmd.ExecuteNonQuery();

                ev.ID = logID++;*/

                foreach (InfoXml info in infoXml)
                {
                    string logCommand = "INSERT INTO " + tableName + "(id, name, value, edited_value) VALUES(\'" + info.ID + "\',\' " + info.Name + "\',\' " + info.Value +
                        "\',\' " + null + "\'); ";
                    sqlite_cmd = connection.CreateCommand();
                    sqlite_cmd.CommandText = logCommand;
                    sqlite_cmd.ExecuteNonQuery();
                }
            }
        }
        //-------------------------------------------------------------------------------

        private object GetObject(object ob)
        {
            foreach (var p in ob.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                return p;
            }
            return null;
        }

        //-------------------------------------------------------------------------------

        private List<PropertyInfo> DisplayObject(object obj, List<PropertyInfo> pList)
        {
            if (obj == null) return null;
            Type type = obj.GetType();
            foreach (var propertyInfo in type.GetProperties())
            {
                object value = propertyInfo.GetValue(obj, null);
                var elems = value as IList;
                if (elems != null)
                {
                    foreach (var item in elems)
                    {
                        DisplayObject(item, pList);
                    }
                }
                else
                {
                    if (propertyInfo.PropertyType.Assembly == type.Assembly)
                    {
                        DisplayObject(value, pList);

                    }
                    else
                    {
                        pList.Add(propertyInfo);

                    }
                }
            }
            return pList;
        }

        //-------------------------------------------------------------------------------

        public void LogEvent(string dbPath, Event ev)
        {
            int logID;
            if (!File.Exists(dbPath))
            {
                Console.WriteLine("creating db");

                SQLiteConnection.CreateFile(dbPath);
            }

            string dataSource = @"Data Source=" + dbPath + ";Pooling=true;FailIfMissing=false;Version=3";

            Console.WriteLine("Data source: {0}", dataSource);

            using (SQLiteConnection connection = new SQLiteConnection(dataSource))
            {
                SQLiteCommand sqlite_cmd;
                string tableName = "Event_log";
                connection.Open();


                if (!TableExists(connection, tableName))
                {
                    Console.WriteLine("Create table");
                    string[] columns = { "ID", "TAG", "Timestamp", "Description", "Status", "Comments" };
                    CreateTable(tableName, columns, connection);
                }

                string getID = "SELECT MAX(ID) FROM " + tableName + ";";

                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = getID;
                logID = sqlite_cmd.ExecuteNonQuery();

                ev.ID = logID++;

                string logCommand = "INSERT INTO " + tableName + "(ID, TAG, Timestamp, Description, Status, Comments) VALUES(\'" + ev.ID + "\',\' " + ev.Tag + "\',\' " + ev.TimeStamp +
                    "\',\' " + ev.Description + "\',\' " + ev.Status + "\',\' " + ev.Comments + "\'); ";
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = logCommand;
                sqlite_cmd.ExecuteNonQuery();
            }

        }
        //-------------------------------------------------------------------------------
        static void CreateTable(string name, string[] colNames, SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;

            string CreateSql = "CREATE TABLE " + name + " (";

            for (int i = 0; i < colNames.Length; i++)
            {
                if (i == colNames.Length - 1)
                    CreateSql += colNames[i] + " VARCHAR(20)";
                else
                    CreateSql += colNames[i] + " VARCHAR(20), ";
            }

            CreateSql += "); ";

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = CreateSql;
            sqlite_cmd.ExecuteNonQuery();
        }
        //-------------------------------------------------------------------------------

        static void InsertData(string key, string data, string tableName)
        {

        }

        //-------------------------------------------------------------------------------

        static void EditData(string key, string data, string tableName)
        {

        }

        //-------------------------------------------------------------------------------

        static bool TableExists(SQLiteConnection conn, string tableName)
        {
            string getTables = "SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "';";
            SQLiteCommand sqlite_cmd;

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = getTables;
            SQLiteDataReader reader = sqlite_cmd.ExecuteReader();

            if (reader.HasRows)
                return true;
            return false;
        }

        //-------------------------------------------------------------------------------

        public void PrintInfoLog(string dbPath)
        {
            if (!File.Exists(dbPath))
            {
                
            }

            string newLogFile = dbPath + "log.csv";

            string dataSource = @"Data Source=" + dbPath + ";Pooling=true;FailIfMissing=false;Version=3";

            Console.WriteLine("Data source: {0}", dataSource);

            using (SQLiteConnection connection = new SQLiteConnection(dataSource))
            {

                SQLiteCommand sqlite_cmd;
                SQLiteDataReader reader;
                string tableName = "info_xml";
                connection.Open();

                string exportQuery = "SELECT name, value, edited_value FROM info_xml";

                try
                {
                    sqlite_cmd = connection.CreateCommand();
                    sqlite_cmd.CommandText = exportQuery;
                    reader = sqlite_cmd.ExecuteReader();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to execute query: {0}", exportQuery);
                    throw e;
                }
                List<string> lines = new List<string>();

                //header
                string headerLine = "";

                if (reader.Read())
                {
                    string[] columns = new string[reader.FieldCount];
                    for (int i=0; i < reader.FieldCount; i++)
                    {
                        columns[i] = reader.GetName(i);
                    }
                    headerLine = string.Join(",", columns);
                    lines.Add(headerLine);
                }

                //data
                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    lines.Add(string.Join(",", values));
                }

                try
                {
                    File.WriteAllLines(newLogFile, lines);
                }
                catch ()
                {
                    Console.WriteLine("Unable to create file: {0}", newLogFile);

                }
            }
        }
    }
    //====================================================================================
    public class DataPack
    {
        public string ID { get; set; }
        public string QuarPath { get; set; }
        public string WorkPath { get; set; }
        public string[] BackupPath { get; set; }
        public string LogFilePath { get; set; }

        public MetaData MetaData { get; set; }

    }
    //====================================================================================

    public class MetaData //ephorte??
    {

        public string AvtNr { get; set; }

        public string CreatorName { get; set; }
        public string CreatorContactPers { get; set; }
        public string CreatorAdress { get; set; }
        public string CreatorPhone { get; set; }
        public string CreatorEmail { get; set; }
        public string TransferName { get; set; }
        public string TransferContactPers { get; set; }
        public string TransferAdress { get; set; }
        public string TransferPhone { get; set; }
        public string TransferEmail { get; set; }

        public string ProducerName { get; set; }
        public string ProducerContactPers { get; set; }
        public string ProducerAdress { get; set; }
        public string ProducerPhone { get; set; }
        public string ProducerEmail { get; set; }
        public string SystemName { get; set; }
        public string SystemVersion { get; set; }
        public string SystemType { get; set; }
        public string SystemTypeVersion { get; set; }


        public string ExtractionSystemName { get; set; }
        public string ExtractionSystemVersion { get; set; }
        public string ExtractionSystemType { get; set; }
        public string ExtractionSystemTypeVersion { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ExtractDate { get; set; }
        public string InfoXML { get; set; }
        public string InfoXMLName { get; set; }
        public string InfoXMLContactPers { get; set; }
        public string InfoXMLAdress { get; set; }
        public string InfoXMLPhone { get; set; }
        public string InfoXMLEmail { get; set; }
        public string METSProg { get; set; }
        public string METSProgVersion { get; set; }

        public string DepotDealSent { get; set; }
        public string DepotDealConfirmed { get; set; }
        public string DepotInfoOmInn { get; set; }
        public string DepotMetaData { get; set; }
        public string DepotInfoXMLRecieved { get; set; }
        public string DepotReceiptSent { get; set; }
        public string DepotDeportedDate { get; set; }
        public string DepotDeportedID { get; set; }

    }
    //====================================================================================

    public class Contact
    {
        public string Name { get; set; }
        public string ContactPers { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
    //====================================================================================

    public class Software
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string TypeVersion { get; set; }
    }
    //====================================================================================

    public class Depot
    {
        public string DealSent { get; set; }
        public string DealConfirmed { get; set; }
        public string InfoOmInn { get; set; }
        public string MetaData { get; set; }
        public string InfoXMLRecieved { get; set; }
        public string ReceiptSent { get; set; }
        public string DeportedDate { get; set; }
        public string DeportedID { get; set; }

    }
    //====================================================================================

    public class Event
    {
        public string TimeStamp { get; set; }
        public int ID { get; set; }
        public string Tag { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

    }
}
