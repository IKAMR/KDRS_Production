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
    public partial class EditMetaForm : Form
    {

        Log logger;
        XMLInfoReader xmlReader;

        List<InfoXml> infoList;

        string infoXmlPath = String.Empty;
        string dbPath = String.Empty;

        public EditMetaForm(string infoXmlPath, string dbPath)
        {
            InitializeComponent();

            this.infoXmlPath = infoXmlPath;
            this.dbPath = dbPath;

            txtBxInfoXmlPath.Text = infoXmlPath;
        }

        private void btnSelectInfoXml_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxInfoXmlPath.Text = openFileDialog1.FileName;
        }

        private void btnImportXml_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBxInfoXmlPath.Text))
            {
                lblError.Text = "Enter path to file";
            }
            else if (String.IsNullOrEmpty(txtBxWorkArea.Text))
            {
                lblError.Text = "Enter path to work folder";
            }
            else
            {
                lblError.Text = "";

                string infoXmlPath = txtBxInfoXmlPath.Text;

                xmlReader = new XMLInfoReader();

                //xmlReader.InfoXml(infoXmlPath);


                infoList = xmlReader.InfoXmlImport(infoXmlPath);

                foreach (InfoXml info in infoList)
                {
                    Console.WriteLine("{0} - {1} - {2}", info.ID, info.Name, info.Value);

                }

               // string targetPath = txtBxOutPath.Text;

             //   string dbPath = targetPath + @"\repository_operations\log.sqlite";

              //  logger.LogInfoXml(dbPath, infoList);
            }
        }

        private void btnEditMeta_Click(object sender, EventArgs e)
        {
            // TODO: Hvis noen av textBox er endret lag ny info.xml fil og lagre endring i log fil under 'edited_value'.
        }

        private void DisplayInfo()
        {
            // TODO: Legg til en tekstbox  og en label for hver info i infoList.
            
        }

        private void btnChooseWorkArea_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxWorkArea.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
