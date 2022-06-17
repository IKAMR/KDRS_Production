using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace KDRS_Production
{
    public partial class ToolHandling : Form
    {
        public ToolHandling(string packageID, string workingDir)
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(ToolHandling_FormClosing);

            comBxToolSelect.Items.AddRange(new object[] { "VeraPDF", "Droid" });

            // IF Droid selected
            txtBxResultFolder.Text = Path.Combine(workingDir, "repository_operations");
            txtBxDroidJar.Text = @"C:\prog\droid\droid_v6.5.2_V97\droid-command-line-6.5.2.jar";
            txtBxPackageID.Text = packageID;
        }
        //-------------------------------------------------------------------------------
        public void CheckMissingFiles()
        {
            XMLInfoReader xmlReader = new XMLInfoReader();

            List<string> fileList = new List<string>();
            List<InfoXml> refDocQuery = new List<InfoXml>();

            string targetFolder = txtBxTargetFolder.Text;
            string resultFolder = txtBxResultFolder.Text;
            string packageID = txtBxPackageID.Text;

            string xmlFilePath = Path.Combine(targetFolder, "arkivstruktur.xml");


            refDocQuery.Add(new InfoXml("refDocQuery", "Reference Document File Query", @"distinct-values(//dokumentobjekt/referanseDokumentfil)", null));

            xmlReader.RunXpath(xmlFilePath, refDocQuery);

            Console.WriteLine("Running xml query: {0}", refDocQuery[0].Query);

            string filePath;

            using (StringReader reader = new StringReader(refDocQuery[0].Value))
            {
                string file;
                while ((file = reader.ReadLine()) != null)
                {
                    //Does file exist in documents folder?
                    

                    //Console.WriteLine("Current missing file: {0}", targetFolder + @"\" + file);


                    file = file.Replace("\"", "");
                    filePath = Path.Combine(targetFolder, file);
                    if (!File.Exists(filePath))
                        fileList.Add(file);
                }
            }

            string missingFilesFile = Path.Combine(resultFolder, "analyse", packageID + "_missing_files.txt");

            writeResultsToFile(missingFilesFile, fileList);
        }
        //-------------------------------------------------------------------------------
        private void writeResultsToFile(string outFile, List<string> result)
        {
            using (StreamWriter w = File.AppendText(outFile))
            {
                w.WriteLine(txtBxPackageID.Text);
                w.WriteLine("Missing files:");
                w.WriteLine("");
                
                foreach (string item in result)
                    w.WriteLine(item);

                w.WriteLine("");

            }
        }
        //-------------------------------------------------------------------------------

            private void RunDroidProcesses(string droidJarPath, string targetFolder, string resultFolder, string packageID)
        {
            /*
            targetFolder = txtBxTargetFolder.Text;
            resultFolder = txtBxResultFolder.Text;
            packageID = txtBxPackageID.Text;
            */
            
            if (string.IsNullOrEmpty(targetFolder) || string.IsNullOrEmpty(resultFolder) || string.IsNullOrEmpty(packageID))
            {
                lblToolError.Text = "Please put fill in target folder, result folder and package ID";
            }
            else
            {
                string droidFolderName = resultFolder.Split(Path.DirectorySeparatorChar).Last();
                string droidProjectName = packageID + @"_" + droidFolderName + @".droid";

                // Add files to droid project and run droid
                string processString = @"-jar " + droidJarPath + @" -R -a " + targetFolder + " -p " + resultFolder + @"\" + droidProjectName;

                Console.WriteLine("JAVA Command: {0} {1}", "java", processString);

                this.Enabled = false;

                txtBxDroidInfo.Text = "Adding files to droid project and running droid";
                RunJavaProcess(processString);

                string droidResultFile = packageID + @"_" + droidFolderName + @".csv";

                // Print droid project result csv file

                processString = @"-jar " + droidJarPath + @" -p " + resultFolder + @"\" + droidProjectName + @" -e " + resultFolder + @"\" + droidResultFile;

                this.Enabled = false;

                Console.WriteLine("JAVA Command: {0} {1}", "java", processString);

                RunJavaProcess(processString);

                // Print droid project result project file
                string droidReportFile = packageID + @"_" + droidFolderName + @"_report.xml";
                processString = @"-jar " + droidJarPath + @" -p " + resultFolder + @"\" + droidProjectName + " -n \"Comprehensive breakdown\" -r " + resultFolder + @"\" + droidReportFile + " -t \"Droid Report XML\"";

                this.Enabled = false;

                Console.WriteLine("JAVA Command: {0} {1}", "java", processString);

                RunJavaProcess(processString);

                // Print droid project result project file
                droidReportFile = packageID + @"_" + droidFolderName + @"_report-planets.xml";
                processString = @"-jar " + droidJarPath + @" -p " + resultFolder + @"\" + droidProjectName + " -n \"Comprehensive breakdown\" -r " + resultFolder + @"\" + droidReportFile + " -t \"Planets XML\"";

                this.Enabled = false;

                Console.WriteLine("JAVA Command: {0} {1}", "java", processString);

                RunJavaProcess(processString);

                // Print droid project result project file
                droidReportFile = packageID + @"_" + droidFolderName + @"_report.pdf";
                processString = @"-jar " + droidJarPath + @" -p " + resultFolder + @"\" + droidProjectName + " -n \"Comprehensive breakdown\" -r " + resultFolder + @"\" + droidReportFile + " -t \"Pdf\"";

                this.Enabled = false;

                Console.WriteLine("JAVA Command: {0} {1}", "java", processString);

                RunJavaProcess(processString);
                Console.WriteLine("Droid finish");
            }
        }
        //-------------------------------------------------------------------------------
        private void RunJavaProcess(string processString)
        {
            try
            {
                System.Diagnostics.Process droidProcess = new System.Diagnostics.Process();
                droidProcess.StartInfo.FileName = "java";
                droidProcess.StartInfo.Arguments = processString;
                droidProcess.Start();
                droidProcess.WaitForExit();
                this.Enabled = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Droid unable to run");
                throw e;
            }
        }

        //-------------------------------------------------------------------------------

        private void btnImportLog_Click(object sender, EventArgs e)
        {

        }
        //-------------------------------------------------------------------------------

        private void btnSelectLog_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxLogPath.Text = openFileDialog1.FileName;
        }
        //-------------------------------------------------------------------------------

        private void ToolHandling_FormClosing(Object sender, FormClosingEventArgs e)
        {
        }
        //-------------------------------------------------------------------------------

        private void btnChooseTargetFolder_Click(object sender, EventArgs e)
        {
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxTargetFolder.Text = folderBrowserDialog1.SelectedPath;
        }
        //-------------------------------------------------------------------------------

        private void btnChooseResultFolder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = txtBxResultFolder.Text;
            DialogResult dr = folderBrowserDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxResultFolder.Text = folderBrowserDialog1.SelectedPath;
        }
        //-------------------------------------------------------------------------------

        private void btnChooseDroidJar_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
                txtBxDroidJar.Text = openFileDialog1.FileName;
        }
        //-------------------------------------------------------------------------------

        private void btnRunDroid_Click(object sender, EventArgs e)
        {
            RunDroidProcesses(txtBxDroidJar.Text, txtBxTargetFolder.Text,txtBxResultFolder.Text, txtBxPackageID.Text);
        }

        private void btnChkMissFiles_Click(object sender, EventArgs e)
        {
            CheckMissingFiles();
        }
        //-------------------------------------------------------------------------------

    }
}
