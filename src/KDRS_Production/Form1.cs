using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        ToolHandling toolHandler;

        List<InfoXml> infoList;

        string packageID = String.Empty;
        string workAreaPath = String.Empty;
        string infoXmlPath = String.Empty;
        string dbPath = String.Empty;
        string targetPath = String.Empty;

        bool toolHandlingExists;
        bool templateFileExists;

        DataTable templateData;
        //-------------------------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();

            this.Height -= pnlEventLog.Height;

            Text = Globals.toolName + " " + Globals.toolVersion;

            logger = new Log();

            //FOR DEV - TO BE REMOVED
            txtBxOutPath.Text = @"C:\developer\c#\kdrs_production\doc";
            
            txtBxPackageID.Text = "15nn_test";

            string[] assemblyNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            foreach (string assemblyName in assemblyNames)
                Console.WriteLine(assemblyName);    

        }
        //-------------------------------------------------------------------------------
        private void btnOpenEventLog_Click(object sender, EventArgs e)
        {
            if (!pnlEventLog.Visible)
            {
                if (String.IsNullOrEmpty(txtBxOutPath.Text))
                {
                    lblError.Text = "Enter path to work folder";
                }
                else
                {
                    this.Height += pnlEventLog.Height;

                    pnlEventLog.Visible = true;

                    cbBxStatus.Items.AddRange(new object[]
                    {
                        "",
                        "Godkjent",
                        "Godkjent med avvik",
                        "Avvik",
                        "Avvist"
                    });

                    targetPath = txtBxOutPath.Text;
                    string logTemplate = targetPath + @"\repository_operations\templates\15KK_nnn_A_depot-log_v2.0_template.txt";

                    csvReader = new CsvReader();

                    //templateData = csvReader.ConvertCSVtoDataTable(logTemplate);
                    templateData = csvReader.ImportCSVtoDataTable();
                }
            }
            else
            {
                this.Height -= pnlEventLog.Height;

                pnlEventLog.Visible = false;
            }
        }
        //-------------------------------------------------------------------------------

        private void bntSaveEvent_Click(object sender, EventArgs e)
        {
            Event ev = new Event
            {
                TimeStamp = txtBxEventTime.Text,
                Tag = txtBxLogTag.Text,
                User = txtBxUser.Text,
                Description = txtBxDescription.Text,
                Status = cbBxStatus.Text,
                Comments = txtBxComments.Text
            };

            targetPath = txtBxOutPath.Text;

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
        //-------------------------------------------------------------------------------

        //-------------------------------------------------------------------------------

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
/*
                foreach (InfoXml info in infoList)
                {
                    Console.WriteLine("{0} - {1} - {2}", info.ID, info.Name, info.Value);
                }
                */
                targetPath = txtBxOutPath.Text;

                dbPath = targetPath + @"\repository_operations\" + packageID +  @"_event_log.sqlite";

                logger.LogInfoXml(dbPath, infoList);
            }
        }
        //-------------------------------------------------------------------------------

        private void btnSelectInfoXml_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxInfoXmlPath.Text = openFileDialog1.FileName;
        }
        //-------------------------------------------------------------------------------
        // Export log db to a csv file.
        private void btnExpLog_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxOutPath.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
            {
                lblError.Text = "";
                targetPath = txtBxOutPath.Text;
                Console.WriteLine("Exporting log");

                dbPath = targetPath + @"\repository_operations\" + packageID + @"_event_log.sqlite";
                string logName = targetPath + @"\repository_operations\full_log.csv";

                if (!File.Exists(dbPath))
                {
                    lblError.Text = "Cannot find Log file: " +  dbPath;
                }else
                    logger.PrintAllLog(dbPath, logName);
                //logger.PrintInfoLog(dbPath);
            }
        }
        //-------------------------------------------------------------------------------
        // Opens new form for editing info.xml metadata.
        private void btnEditMeta_Click(object sender, EventArgs e)
        {
            EditMetaForm EditForm = new EditMetaForm(infoXmlPath, dbPath, infoList);
            EditForm.Show();
        }
        //-------------------------------------------------------------------------------
        // Checkiung checkbox changes Log tag textbox to drop down meny with suggested tags read from template file.
        private void chkBxSelectFromTemplate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSelectFromTemplate.Checked)
            {
                txtBxLogTag.Visible = false;
                cbBxSelectEvent.Visible = true;

                if (!templateData.Columns.Contains("tagdesc"))
                    templateData.Columns.Add("tagdesc", typeof(String));

                foreach (DataRow rw in templateData.Rows)
                {
                    rw["tagdesc"] = rw["tag"] + " " + rw["description"];
                }

                cbBxSelectEvent.DataSource = templateData;
                cbBxSelectEvent.ValueMember = "tag";
                cbBxSelectEvent.DisplayMember = "tagdesc";
            }
            else
            {
                txtBxLogTag.Visible = true;
                cbBxSelectEvent.Visible = false;
            }
        }
        //-------------------------------------------------------------------------------

        private void cbBxSelectEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedRow = "tag= '" + cbBxSelectEvent.SelectedValue + "'";
                Console.WriteLine("Tag = {0}", selectedRow);
                DataRow[] dr = templateData.Select(selectedRow);

                foreach (DataRow row in dr)
                {
                    txtBxDescription.Text = row["description"].ToString();
                    txtBxComments.Text = row["comments"].ToString();
                    txtBxLogTag.Text = cbBxSelectEvent.SelectedValue.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //-------------------------------------------------------------------------------

        private void btnGetTimeStamp_Click(object sender, EventArgs e)
        {
            txtBxEventTime.Text = DateTime.Now.ToString("yyyy.MM.ddTHH:mm:ss");
        }
        //-------------------------------------------------------------------------------
        // Prevents opening more than one Toolhandling windows.
        private void btnToolHandling_Click(object sender, EventArgs e)
        {
            if (!toolHandlingExists)
            {
                workAreaPath = txtBxOutPath.Text;
                packageID = txtBxPackageID.Text;

                toolHandler = new ToolHandling(packageID, workAreaPath);
                toolHandlingExists = true;
                toolHandler.FormClosed += ToolHandling_FormClosed;
            }
            toolHandler.Show();
            toolHandler.Activate();
        }

        //-------------------------------------------------------------------------------

        private void ToolHandling_FormClosed(Object sender, FormClosedEventArgs e)
        {
            toolHandlingExists = false;
        }
    }
    //====================================================================================================
    public static class Globals
    {
        public static readonly String toolName = "KDRS Production";
        public static readonly String toolVersion = "0.5-rc1";
    }

}
