using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDRS_Production
{
    public partial class Form1 : Form
    {
        Log logger;
        XMLInfoReader xmlReader;

        List<InfoXml> infoList;

        public Form1()
        {
            InitializeComponent();

            Text = Globals.toolName + " " + Globals.toolVersion;

            logger = new Log();

        }

        private void btnOpenEventLog_Click(object sender, EventArgs e)
        {
            pnlEventLog.Visible = true;

            txtBxEventTime.Text = DateTime.Now.ToString("yyyy.MM.ddTHH:mm:ss");

            cbBxStatus.Items.AddRange(new object[]
            {
                "",
                "Godkjent",
                "Godkjent med avvik",
                "Avvik",
                "Avvist"
            });
        }

        private void bntSaveEvent_Click(object sender, EventArgs e)
        {


            Event ev = new Event
            {
                TimeStamp = txtBxEventTime.Text,
                Tag = txtBxPackID.Text,
                Description = txtBxDescription.Text,
                Status = cbBxStatus.Text,
                Comments = txtBxComments.Text
            };

            string targetPath = txtBxOutPath.Text;

            string dbPath = targetPath + @"\repository_operations\log.sqlite";
            if (String.IsNullOrEmpty(txtBxOutPath.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
            {
                lblError.Text = "";
                logger.LogEvent(dbPath, ev);
            }
        }

        private void btnSaveMetadata_Click(object sender, EventArgs e)
        {
            string targetPath = txtBxOutPath.Text;

            string dbPath = targetPath + @"\repository_operations\log.sqlite";
           // logger.LogInfoXml(dbPath, infoList);
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxInfoXmlPath.Text))
            {
                lblError.Text = "Enter path to file";
            }
            else if (String.IsNullOrEmpty(txtBxOutPath.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
            {
                lblError.Text = "";

                string infoXmlPath = txtBxInfoXmlPath.Text;

                xmlReader = new XMLInfoReader();

                xmlReader.InfoXml(infoXmlPath);


                infoList = xmlReader.InfoXmlImport(infoXmlPath);

                foreach (InfoXml info in infoList)
                {
                    Console.WriteLine("{0} - {1} - {2}", info.ID, info.Name, info.Value);

                }

                string targetPath = txtBxOutPath.Text;

                string dbPath = targetPath + @"\repository_operations\log.sqlite";

                logger.LogInfoXml(dbPath, infoList);
            }
        }

        private void btnSelectInfoXml_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxInfoXmlPath.Text = openFileDialog1.FileName;
        }

        private void btnExpLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxOutPath.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
            {
                lblError.Text = "";
                string targetPath = txtBxOutPath.Text;
                Console.WriteLine("Exporting log");

                string dbPath = targetPath + @"\repository_operations\log.sqlite";
                string logNAme = targetPath + @"\repository_operations\full_log.csv";

                logger.PrintAllLog(dbPath, logNAme);
                //logger.PrintInfoLog(dbPath);
            }
        }

        private void btnEditMeta_Click(object sender, EventArgs e)
        {
        }
    }
    //====================================================================================================
    public static class Globals
    {
        public static readonly String toolName = "KDRS Production";
        public static readonly String toolVersion = "0.1";
    }

}
