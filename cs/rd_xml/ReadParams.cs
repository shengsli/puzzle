using System;
using System.Xml;

namespace DOMtoXML
{
    class ReadParamsProgram
    {
        static void Main(string[] args)
        {
            // string myXml = "<Parameters><Parameter Type=\"Configuration\" Name=\"UseSemLayer\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"UseUserConfiguration\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"SQLServer.ServerName\">SGDPDEVSLI01</Parameter><Parameter Type=\"Configuration\" Name=\"SQLServer.UserName\">sa</Parameter><Parameter Type=\"Configuration\" Name=\"SQLServer.Password\">Password1</Parameter><Parameter Type=\"Configuration\" Name=\"SQLType\" SubCategory=\"\">MSSQL2016</Parameter><Parameter Type=\"Configuration\" Name=\"SAPDatabase\" SubCategory=\"\">SBODEMOUS</Parameter><Parameter Type=\"Configuration\" Name=\"SAPUserName\" SubCategory=\"\">manager</Parameter><Parameter Type=\"Configuration\" Name=\"SAPPassword\" SubCategory=\"\">manager</Parameter><Parameter Type=\"Configuration\" Name=\"CreatePOas\" SubCategory=\"\">Sales Order</Parameter><Parameter Type=\"Configuration\" Name=\"DuplicatePO\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"AutoSelection\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"TransactionSearch.TxnSearchPeriodNumber\">1</Parameter><Parameter Type=\"Configuration\" Name=\"CreateDropShipPO\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"Batching.ImportFlag\">false</Parameter><Parameter Type=\"Configuration\" Name=\"Batching.Import\">1</Parameter><Parameter Type=\"Configuration\" Name=\"Batching.ExportFlag\">false</Parameter><Parameter Type=\"Configuration\" Name=\"Batching.Export\">1</Parameter><Parameter Type=\"Configuration\" Name=\"SOFilterRange.TxnSearchPeriodNumber\">1</Parameter><Parameter Type=\"Configuration\" Name=\"OverrideLotsAllocatedOnSalesOrder\" SubCategory=\"\">True</Parameter><Parameter Type=\"Configuration\" Name=\"AllowDuplicateTrack\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"IncludeComponents\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"IncludeDraftDocConso\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"Create945Draft\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"UsingSingleSignOn\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"DisableSuppCatNum\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"EnableCustomerCreationOnExport\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"ExplodePickTicket\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"GetPartnerSettingByWhscode\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"CascadeWhsCode\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"Allowovership\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"CreateASNAsDraft\" SubCategory=\"\">False</Parameter><Parameter Type=\"Configuration\" Name=\"AssignNextSAPBussinessPartner\" SubCategory=\"\">False</Parameter></Parameters>";
            XmlDocument xmlDoc = new XmlDocument();
            // xmlDoc.LoadXml(myXml);
            xmlDoc.Load(".\\params.xml");
            XmlNodeList xmlNodeList = xmlDoc.SelectSingleNode(".").FirstChild.ChildNodes;
            Console.WriteLine(xmlNodeList.Count);
            foreach (XmlNode xmlNode in xmlNodeList)
            {
                Console.WriteLine(xmlNode.OuterXml);
            }

            Console.WriteLine("----------");
            XmlNode curNode = xmlDoc.SelectSingleNode(".");
            Console.WriteLine(curNode.InnerXml);
            
            Console.WriteLine("----------");
            XmlNode fstChild = xmlDoc.SelectSingleNode(".").FirstChild;
            Console.WriteLine(fstChild.InnerXml);

            Console.WriteLine("----------");
            XmlNode fstfstChild = xmlDoc.SelectSingleNode(".").FirstChild.FirstChild;
            Console.WriteLine(fstfstChild.InnerXml);

            Console.WriteLine("----------");
            Console.WriteLine(fstChild.OuterXml.Equals(curNode.OuterXml));
        }
    }
}