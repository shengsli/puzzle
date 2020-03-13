using System;
using System.Xml;

namespace DOMtoXML
{
    class ReadParamsProgram
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(".\\videos.xml");

            Console.WriteLine("----------");
            XmlNode videosNode = xmlDoc.SelectSingleNode("./Videos/Video");
            Console.WriteLine(videosNode.InnerXml);

            Console.WriteLine("----------");
            XmlNode fstChild = videosNode.FirstChild;
            Console.WriteLine(fstChild.InnerXml);

        }
    }
}