using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDRS_Production
{
    internal class DocValidator
    {
        List<string> missingFileList = new List<string>();
        List<string> refFiles = new List<string>();
        List<string> filesNoRefList = new List<string>();

        List<InfoXml> refDocQuery = new List<InfoXml>();
        FileInfo[] docFileList;

        int filesXml;
        int includedFiles;
        int missingFiles;
        int filesNoRef;

        //-------------------------------------------------------------------------------
        public void CheckMissingFiles(string targetFolder, string resultFolder, string packageID)
        {
            XMLInfoReader xmlReader = new XMLInfoReader();

            missingFileList.Clear();
            refFiles.Clear();
            refDocQuery.Clear();

            DirectoryInfo docFolder = new DirectoryInfo(targetFolder + @"\dokumenter");
            docFileList = docFolder.GetFiles();

            includedFiles = docFileList.Length;
            
           /* string targetFolder = txtBxTargetFolder.Text;
            string resultFolder = txtBxResultFolder.Text;
            string packageID = txtBxPackageID.Text;
           */
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

                    refFiles.Add(file);

                    filePath = Path.Combine(targetFolder, file);
                    if (!File.Exists(filePath))
                        missingFileList.Add(file);
                }
            }

            foreach (FileInfo file in docFileList)
            {
                filePath = @"dokumenter/" + file.Name;
                Console.WriteLine("doc file: {0}", filePath);

                if (!refFiles.Contains(filePath)){
                    filesNoRefList.Add(filePath);
                }
            }

            filesXml = refFiles.Count;

            missingFiles = missingFileList.Count;
            filesNoRef = filesNoRefList.Count;

            foreach (string file in refFiles)
                Console.WriteLine("files in xml: {0}", file);

            foreach (FileInfo file in docFileList)
                Console.WriteLine("files in folder: {0}", file);

            string docSummaryFile = Path.Combine(resultFolder, "analyse", packageID + "_noark5-doc_summary.txt");
            string missingFilesFile = Path.Combine(resultFolder, "analyse", packageID + "_noark5-doc_missing.txt");

            writeDocSummaryFile(docSummaryFile, packageID);
            writeResultsToFile(missingFilesFile, missingFileList, packageID);
        }
        //-------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------
        private void writeResultsToFile(string outFile, List<string> result, string packageID)
        {
            using (StreamWriter w = File.AppendText(outFile))
            {
                w.WriteLine(packageID);
                w.WriteLine("Missing files:");
                w.WriteLine("");

                foreach (string item in result)
                    w.WriteLine(item);

                w.WriteLine("");

            }
        }
        //-------------------------------------------------------------------------------
        private void writeDocSummaryFile(string outFile, string packageID)
        {
            using (StreamWriter w = File.AppendText(outFile))
            {
                w.WriteLine(packageID);
                w.WriteLine("KDRS Production v" + Globals.toolVersion + " - Noark 5 doc validator v" + DocValVersion);
                w.WriteLine("arkivstruktur.xml dokumentobjekt count: " + filesXml);
                w.WriteLine("dokumenter files: " + includedFiles);

                w.WriteLine("Missing files: " + missingFiles);
                w.WriteLine("Files without reference: " + filesNoRef);

                w.WriteLine("");

            }
        }

        public string DocValVersion = "0.2";
    }
}
