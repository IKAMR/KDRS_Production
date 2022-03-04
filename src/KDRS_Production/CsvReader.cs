using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KDRS_Production
{
    class CsvReader
    {
        public DataTable ConvertCSVtoDataTable(string strFilePath)
        {
            StreamReader sr = new StreamReader(strFilePath);

            string[] headers = sr.ReadLine().Split(';');

            DataTable dt = new DataTable();
            foreach (string header in headers)
            {
                dt.Columns.Add(header.Trim());
            }
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine("leset linje {0}", line);
                if (line.StartsWith("#") || String.IsNullOrEmpty(line))
                    continue;
                else
                {
                    string[] rows = Regex.Split(line, ";(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    dt.Rows.Add(dr);
                }
            }
            return dt;
        }
    }
}
