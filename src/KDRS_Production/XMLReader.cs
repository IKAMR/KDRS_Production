using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Saxon.Api;

namespace KDRS_Production
{
    public class XMLInfoReader
    {
        DataSet ds;
        //-------------------------------------------------------------------------------
        public DataSet ReadInfoXml(string fileName)
        {
            XmlReader xmlFile;

            Console.WriteLine("info.xml: {0}", fileName);

            xmlFile = XmlReader.Create(fileName, new XmlReaderSettings());

            ds = new DataSet();

            ds.ReadXml(xmlFile);

            return ds;
        }
        //-------------------------------------------------------------------------------
        public Dictionary<string, string> InfoXml(string inputDoc)
        {
            Dictionary<string, string> infoDict = new Dictionary<string, string>();
            infoDict.Add("Object ID", @"//@OBJID/string()");
            infoDict.Add("Label", @"//@LABEL/string()");
            infoDict.Add("Type", @"//mets:mets/@TYPE/string()");

            infoDict.Add("Extraction date", @"//@CREATEDATE/string()");

            infoDict.Add("Archivist organization", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='ORGANIZATION']/mets:name/text()");

            infoDict.Add("Archivist individual", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:name/text()");
            infoDict.Add("Archivist individual, adress", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[1]/text()");
            infoDict.Add("Archivist individual, phone", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[2]/text()");
            infoDict.Add("Archivist individual, email", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[3]/text()");

            infoDict.Add("Submitter organization", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='ORGANIZATION']/mets:name/text()");

            infoDict.Add("Submitter individual", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:name/text()");
            infoDict.Add("Submitter individual, adress", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()");
            infoDict.Add("Submitter individual, email", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()");
            infoDict.Add("Submitter individual, phone", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()");

            infoDict.Add("Producer organization", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='ORGANIZATION']/mets:name/text()");
            infoDict.Add("Producer individual", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:name/text()");
            infoDict.Add("Producer individual, adress", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()");
            infoDict.Add("Producer individual, phone", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()");
            infoDict.Add("Producer individual, email", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()");

            infoDict.Add("Ipowner organization", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='ORGANIZATION']/mets:name/text()");

            infoDict.Add("Ipowner individual", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:name/text()");
            infoDict.Add("Ipowner individual, adress", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()");
            infoDict.Add("Ipowner individual, phone", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()");
            infoDict.Add("Ipowner individual, email", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()");

            infoDict.Add("Creator organization", @"//mets:agent[@ROLE='CREATOR' and @TYPE='ORGANIZATION']/mets:name/text()");

            infoDict.Add("Creator individual", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:name/text()");
            infoDict.Add("Creator individual, adress", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[1]/text()");
            infoDict.Add("Creator individual, phone", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[2]/text()");
            infoDict.Add("Creator individual, email", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[3]/text()");

            infoDict.Add("Creator software", @"//mets:agent[@ROLE='CREATOR' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()");
            infoDict.Add("Creator software version", @"//mets:agent[@ROLE='CREATOR' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()");

            infoDict.Add("Preservator organization", @"//mets:agent[@ROLE='PRESERVATION' and @TYPE='ORGANIZATION']/mets:name/text()");

            infoDict.Add("Archivist software", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()");
            infoDict.Add("Archivist software version", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()");
            infoDict.Add("Archivist software Noark", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()");
            infoDict.Add("Archivist software Noark version", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()");

            infoDict.Add("Producer software", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()");
            infoDict.Add("Producer software version", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()");
            infoDict.Add("Producer software Noark", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()");
            infoDict.Add("Producer software Noark version", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[3]/text()");

            infoDict.Add("Delivery specification", @"//mets:altRecordID[@TYPE='DELIVERYSPECIFICATION']/text()");
            infoDict.Add("Submission agreement", @"//mets:altRecordID[@TYPE='SUBMISSIONAGREEMENT']/text()");
            infoDict.Add("Start date", @"//mets:altRecordID[@TYPE='STARTDATE']/text()");
            infoDict.Add("End date", @"//mets:altRecordID[@TYPE='ENDDATE']/text()");

            infoDict.Add("Package date", @"//mets:file[@MIMETYPE='application/tar']/@CREATED/string()");
            infoDict.Add("Package checksum", @"//mets:file[@MIMETYPE='application/tar']/@CHECKSUM/string()");
            infoDict.Add("Package size", @"//mets:file[@MIMETYPE='application/tar']/@SIZE/string()");


            Dictionary<string, string> resutDict = RunXpath(inputDoc, infoDict);

            return resutDict;
        }

        //-------------------------------------------------------------------------------
        public Dictionary<string, string> RunXpath(string inputDoc, Dictionary<string, string> queries)
        {
            Dictionary<string, string> xPathDict
                = new Dictionary<string, string>();
            Processor processor = new Processor();
            XmlDocument infoXml = new XmlDocument();

            infoXml.Load(inputDoc);

            XdmNode xmlDoc = processor.NewDocumentBuilder().Build(new XmlNodeReader(infoXml));

            XPathCompiler xPathCompiler = processor.NewXPathCompiler();

            string nameSpace = infoXml.DocumentElement.NamespaceURI;
            string nameSpaceXsi = infoXml.DocumentElement.GetNamespaceOfPrefix("xsi");
            string nameSpaceMets = infoXml.DocumentElement.GetNamespaceOfPrefix("mets");


            xPathCompiler.DeclareNamespace("", nameSpace);
            xPathCompiler.DeclareNamespace("xsi", nameSpaceXsi);
            xPathCompiler.DeclareNamespace("mets", nameSpaceMets);

            string result;

            foreach (KeyValuePair<string, string> key in queries)
            {
                try
                { 
                    result = xPathCompiler.Evaluate(key.Value, xmlDoc).ToString(); 
                }catch (Exception e)
                {
                    Console.WriteLine("Unable to execute query : {0}", key.Value);
                    result = null;

                    throw e;
                }

                xPathDict.Add(key.Key, result);
            }

           

            return xPathDict;
        }

        //-------------------------------------------------------------------------------

        public List<InfoXml> InfoXmlImport(string inputDoc)
        {
            List<InfoXml> valueList = new List<InfoXml>();

            valueList.Add(new InfoXml("OBJID", "Object ID", @"//@OBJID/string()"));

            valueList.Add(new InfoXml("LABEL", "Label", @"//@LABEL/string()"));
            valueList.Add(new InfoXml("TYPE", "Type", @"//mets:mets/@TYPE/string()"));

            valueList.Add(new InfoXml("EXTR_DATE", "Extraction date", @"//@CREATEDATE/string()"));

            valueList.Add(new InfoXml("ARCH_ORG", "Archivist organization", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='ORGANIZATION']/mets:name/text()"));

            valueList.Add(new InfoXml("ARCH_IND", "Archivist individual", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:name/text()"));
            valueList.Add(new InfoXml("ARCH_IND_ADR", "Archivist individual, adress", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("ARCH_IND_PHONE", "Archivist individual, phone", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("ARCH_IND_EMAIL", "Archivist individual, email", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='INDIVIDUAL']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("SUB_ORG", "Submitter organization", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='ORGANIZATION']/mets:name/text()"));

            valueList.Add(new InfoXml("SUB_IND", "Submitter individual", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:name/text()"));
            valueList.Add(new InfoXml("SUB_IND_ADR", "Submitter individual, adress", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("SUB_IND_PHONE", "Submitter individual, phone", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("SUB_IND_EMAIL", "Submitter individual, email", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='SUBMITTER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("PROD_ORG", "Producer organization", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='ORGANIZATION']/mets:name/text()"));
            valueList.Add(new InfoXml("PROD_ORG", "Producer individual", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:name/text()"));
            valueList.Add(new InfoXml("PROD_ORG_ADR",  "Producer individual, adress", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("PROD_ORG_PHONE", "Producer individual, phone", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("PROD_ORG_EMAIL", "Producer individual, email", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("IPO_ORG", "Ipowner organization", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='ORGANIZATION']/mets:name/text()"));

            valueList.Add(new InfoXml("IPO_IND", "Ipowner individual", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:name/text()"));
            valueList.Add(new InfoXml("IPO_IND_ADR", "Ipowner individual, adress", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("IPO_IND_PHONE", "Ipowner individual, phone", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("IPO_IND_EMAIL", "Ipowner individual, email", @"//mets:agent[@ROLE='IPOWNER' and @TYPE='INDIVIDUAL']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("CRE_ORG", "Creator organization", @"//mets:agent[@ROLE='CREATOR' and @TYPE='ORGANIZATION']/mets:name/text()"));

            valueList.Add(new InfoXml("CRE_IND", "Creator individual", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:name/text()"));
            valueList.Add(new InfoXml("CRE_IND_ADR", "Creator individual, adress", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("CRE_IND_PHONE", "Creator individual, phone", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("CRE_IND_EMAIL", "Creator individual, email", @"//mets:agent[@ROLE='CREATOR' and @TYPE='INDIVIDUAL']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("CRE_SOFT", "Creator software", @"//mets:agent[@ROLE='CREATOR' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()"));
            valueList.Add(new InfoXml("CRE_SOFT_VER", "Creator software version", @"//mets:agent[@ROLE='CREATOR' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()"));

            valueList.Add(new InfoXml("PRES_ORG", "Preservator organization", @"//mets:agent[@ROLE='PRESERVATION' and @TYPE='ORGANIZATION']/mets:name/text()"));

            valueList.Add(new InfoXml("ARCH_SOFT", "Archivist software", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()"));
            valueList.Add(new InfoXml("ARCH_SOFT_VER", "Archivist software version", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("ARCH_SOFT_NOARK", "Archivist software Noark", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("ARCH_SOFT_NOARK_VER", "Archivist software Noark version", @"//mets:agent[@ROLE='ARCHIVIST' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()"));

            valueList.Add(new InfoXml("PROD_SOFT", "Producer software", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:name/text()"));
            valueList.Add(new InfoXml("PROD_SOFT_VER", "Producer software version", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[1]/text()"));
            valueList.Add(new InfoXml("PROD_SOFT_NOARK", "Producer software Noark", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[2]/text()"));
            valueList.Add(new InfoXml("PROD_SOFT_NOARK_VER", "Producer software Noark version", @"//mets:agent[@ROLE='OTHER' and @OTHERROLE='PRODUCER' and @TYPE='OTHER' and @OTHERTYPE='SOFTWARE']/mets:note[3]/text()"));

            valueList.Add(new InfoXml("DEL_SPEC", "Delivery specification", @"//mets:altRecordID[@TYPE='DELIVERYSPECIFICATION']/text()"));
            valueList.Add(new InfoXml("SUB_AGREEMENT", "Submission agreement", @"//mets:altRecordID[@TYPE='SUBMISSIONAGREEMENT']/text()"));
            valueList.Add(new InfoXml("START_DATE", "Start date", @"//mets:altRecordID[@TYPE='STARTDATE']/text()"));
            valueList.Add(new InfoXml("END_DATE", "End date", @"//mets:altRecordID[@TYPE='ENDDATE']/text()"));

            valueList.Add(new InfoXml("PACK_DATE", "Package date", @"//mets:file[@MIMETYPE='application/tar']/@CREATED/string()"));
            valueList.Add(new InfoXml("PACK_CHKS", "Package checksum", @"//mets:file[@MIMETYPE='application/tar']/@CHECKSUM/string()"));
            valueList.Add(new InfoXml("PACK_SIZE", "Package size", @"//mets:file[@MIMETYPE='application/tar']/@SIZE/string()"));

            RunXpath(inputDoc, valueList);

            return valueList;
        }

        //-------------------------------------------------------------------------------
        public void RunXpath(string inputDoc, List<InfoXml> infoList)
        {
            Processor processor = new Processor();
            XmlDocument infoXml = new XmlDocument();

            infoXml.Load(inputDoc);

            XdmNode xmlDoc = processor.NewDocumentBuilder().Build(new XmlNodeReader(infoXml));

            XPathCompiler xPathCompiler = processor.NewXPathCompiler();

            string nameSpace = infoXml.DocumentElement.NamespaceURI;
            string nameSpaceXsi = infoXml.DocumentElement.GetNamespaceOfPrefix("xsi");
            string nameSpaceMets = infoXml.DocumentElement.GetNamespaceOfPrefix("mets");


            xPathCompiler.DeclareNamespace("", nameSpace);
            xPathCompiler.DeclareNamespace("xsi", nameSpaceXsi);
            xPathCompiler.DeclareNamespace("mets", nameSpaceMets);

            string result;

            foreach (InfoXml info in infoList)
            {
                try
                {
                    result = xPathCompiler.Evaluate(info.Query, xmlDoc).ToString();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to execute query : {0}", info.Query);
                    result = null;

                    throw e;
                }

                info.Value = result;
            }
        }
    }

    public class InfoXml
    {
        public InfoXml(string ID, string Name, string query)
        {
            this.Name = Name;
            this.ID = ID;
            this.Query = query;
        }

        public string ID;
        public string Name;
        public string Query;
        public string Value;

    }
}
