using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KDRS_Production
{
    public partial class EditMetaForm : Form
    {

        Log logger;
        XMLInfoReader xmlReader;

        List<InfoXml> infoList;
        List<InfoXml> editList;

        string infoXmlPath = String.Empty;
        string dbPath = String.Empty;
        //-------------------------------------------------------------------------------

        public EditMetaForm(string infoXmlPath, string dbPath, List<InfoXml> infoList)
        {
            InitializeComponent();

            this.infoXmlPath = infoXmlPath;
            this.dbPath = dbPath;

            txtBxInfoXmlPath.Text = infoXmlPath;

            this.infoList = infoList;
            if (infoList != null)
                DisplayInfo();
            else
            {
                lblError.Text = "Please inport info.xml!";
            }

            editList = new List<InfoXml>();

            xmlReader = new XMLInfoReader();

            logger = new Log();
        }
        //-------------------------------------------------------------------------------

        private void btnSelectInfoXml_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxInfoXmlPath.Text = openFileDialog1.FileName;
        }
        //-------------------------------------------------------------------------------

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
        //-------------------------------------------------------------------------------
        // Save edited values to new info.xml file.
        private void btnSaveMeta_Click(object sender, EventArgs e)
        {
            foreach (InfoXml info in infoList)
            {
                Console.WriteLine("{0} - {1} - {2}", info.ID, info.Name, info.Value);
            }
            
            string filePath = Path.GetDirectoryName(infoXmlPath);
            string fileName = Path.GetFileNameWithoutExtension(infoXmlPath);

            string newFile = Path.Combine(filePath, fileName + "_Edited.xml");
            if (File.Exists(newFile))
                lblError.Text = "File already exist!";
            else
            {
                lblError.Text = "";
                File.Copy(infoXmlPath, newFile);
            }

            editList = new HashSet<InfoXml>(editList).ToList();

            foreach (InfoXml edit in editList)
            {
                Console.WriteLine("Changed info {0}", edit.Name);
            }

            Console.WriteLine("Changed total {0}", editList.Count);

            xmlReader.updateXml(newFile, editList);

            logger.LogEditInfoXml(dbPath, editList);
        }
        //-------------------------------------------------------------------------------
        // Create a label and a textbox for each node in info.xml.
        private void DisplayInfo()
        {
            int x = 3;
            int y = 10;
            foreach (InfoXml info in infoList)
            {
                var label = new Label();
                label.Text = info.Name;
                label.Location = new Point(x, y);
                label.AutoSize = true;
                pnlInfo.Controls.Add(label);

                var textBx = new TextBox();
                textBx.Text = info.Value;
                textBx.Name = "txtBx" + info.ID;
                textBx.Location = new Point(label.Width + 10, y);
                textBx.Width = 300;

                textBx.DataBindings.Clear();
                textBx.DataBindings.Add("Text", info, "Value", false, DataSourceUpdateMode.OnPropertyChanged);

                textBx.TextChanged += new System.EventHandler(this.txtBx_TextChanged);

                pnlInfo.Controls.Add(textBx);
                y += 25;
            }

           // this.AutoSize = true;
           // this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
        //-------------------------------------------------------------------------------
        // If any content in textboxes are changed -> enable option to save edits.
        private void txtBx_TextChanged(object sender, EventArgs e)
        {
            lblError.Text = ((TextBox)sender).Text;

            string name = ((TextBox)sender).Name;

            editList.Add(infoList.Find(info => info.ID == name.Remove(0, 5)));

            btnSaveMeta.Enabled = true;
        }

        //-------------------------------------------------------------------------------

        private void btnChooseWorkArea_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxWorkArea.Text = folderBrowserDialog1.SelectedPath;
        }
    }
}
