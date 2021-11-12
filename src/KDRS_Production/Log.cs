using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDRS_Produksjon
{
    public class Log
    {
        public void LogMetadata(string dbPath, DataPack dataPack)
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);

            }
        }

        public void LogEvent(string dbPath, Event ev)
        {
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
                    string[] columns = { "ID", "Timestamp", "Description", "Status", "Comments" };
                    CreateTable(tableName, columns, connection);
                }


                string logCommand = "INSERT INTO " + tableName + "(ID, Timestamp, Description, Status, Comments) VALUES(\'" + ev.ID + "\',\' " + ev.TimeStamp +
                    "\',\' " + ev.Description + "\',\' " + ev.Status + "\',\' " + ev.Comments + "\'); ";
                sqlite_cmd = connection.CreateCommand();
                sqlite_cmd.CommandText = logCommand;
                sqlite_cmd.ExecuteNonQuery();
            }

        }

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

        static void InsertData(string key, string data, string tableName)
        {

        }

        static void EditData(string key, string data, string tableName)
        {

        }

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
    }

    public class DataPack
    {
        public string ID { get; set; }
        public string QuarPath { get; set; }
        public string WorkPath { get; set; }
        public string LogFilePath { get; set; }

        public MetaData MetaData { get; set; }

    }

    public class MetaData //ephorte??
    {

        public MetaData()
        {
            Dictionary<string, string> metaDict = new Dictionary<string, string>();
        }

        public string AvtNr { get; set; }

        public Contact Creator { get; set; }
        public Contact Transfer { get; set; }
        public Contact Producer { get; set; }

        public System System { get; set; }
        public System ExtractionSystem { get; set; }

        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ExtractDate { get; set; }
        public string InfoXML { get; set; }
        public Contact CreatorInfoXML { get; set; }
        public string METSProg { get; set; }
        public string METSProgVersion { get; set; }

        public Depot DepotInfo { get; set; }



    }

    public class Contact
    {
        public string Name { get; set; }
        public string ContactPers { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }

    public class System
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string TypeVersion { get; set; }
    }
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

    public class Event
    {
        public string TimeStamp { get; set; }
        public string ID { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }

    }
}
