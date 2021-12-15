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
        CsvReader csvReader;

        List<InfoXml> infoList;

        string infoXmlPath = String.Empty;
        string dbPath = String.Empty;

        bool fromTemplate = false;
        DataTable templateData;

        public Form1()
        {
            InitializeComponent();

            Text = Globals.toolName + " " + Globals.toolVersion;

            logger = new Log();

            //FOR DEV - TO BE REMOVED
            txtBxOutPath.Text = @"C:\developer\c#\kdrs_production\doc";

        }

        private void btnOpenEventLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxOutPath.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
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

                string targetPath = txtBxOutPath.Text;
                string logTemplate = targetPath + @"\repository_operations\templates\15KK_nnn_A_depot-log_v1.9_template_2.txt";

                csvReader = new CsvReader();


                templateData = csvReader.ConvertCSVtoDataTable(logTemplate);
            }
 
        }

        private void bntSaveEvent_Click(object sender, EventArgs e)
        {


            Event ev = new Event
            {
                TimeStamp = txtBxEventTime.Text,
                Tag = txtBxLogTag.Text,
                Description = txtBxDescription.Text,
                Status = cbBxStatus.Text,
                Comments = txtBxComments.Text
            };

            string targetPath = txtBxOutPath.Text;

            dbPath = targetPath + @"\repository_operations\log.sqlite";
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

            dbPath = targetPath + @"\repository_operations\log.sqlite";
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

                infoXmlPath = txtBxInfoXmlPath.Text;

                xmlReader = new XMLInfoReader();

                //xmlReader.InfoXml(infoXmlPath);


                infoList = xmlReader.InfoXmlImport(infoXmlPath);

                foreach (InfoXml info in infoList)
                {
                    Console.WriteLine("{0} - {1} - {2}", info.ID, info.Name, info.Value);

                }

                string targetPath = txtBxOutPath.Text;

                dbPath = targetPath + @"\repository_operations\log.sqlite";

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

                dbPath = targetPath + @"\repository_operations\log.sqlite";
                string logNAme = targetPath + @"\repository_operations\full_log.csv";

                logger.PrintAllLog(dbPath, logNAme);
                //logger.PrintInfoLog(dbPath);
            }
        }

        private void btnEditMeta_Click(object sender, EventArgs e)
        {
            EditMetaForm EditForm = new EditMetaForm(infoXmlPath, dbPath);
            EditForm.Show();
        }

        private void chkBxSelectFromTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSelectFromTemplate.Checked)
            {
                txtBxLogTag.Visible = false;
                cbBxSelectEvent.Visible = true;
                fromTemplate = true;

                cbBxSelectEvent.DataSource = templateData;
                cbBxSelectEvent.DisplayMember = "tag";
            }
            else
            {
                txtBxLogTag.Visible = true;
                cbBxSelectEvent.Visible = false;
                fromTemplate = false;
            }
        }

        private void cbBxSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedRow = "tag= '" + cbBxSelectEvent.Text + "'";
                Console.WriteLine("Tag = {0}", selectedRow);
                DataRow[] dr = templateData.Select(selectedRow);

                foreach (DataRow row in dr)
                {
                    txtBxDescription.Text = row["description"].ToString();
                    txtBxComments.Text = row["comments"].ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
    //====================================================================================================
    public static class Globals
    {
        public static readonly String toolName = "KDRS Production";
        public static readonly String toolVersion = "0.1";
    }

}
