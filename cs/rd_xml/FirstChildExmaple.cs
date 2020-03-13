using System;
using System.Xml;

public class Sample
{
    public static void Main()
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<book ISBN='1-861001-57-5'>" +
                    "<title>Pride And Prejudice</title>" +
                    "<title>new book 2</title>" +
                    "<price>19.95</price>" +
                    "</book>");

        XmlNode root = doc.SelectSingleNode(".");
        XmlNode fstChild = root.FirstChild;
        Console.WriteLine(root.InnerXml);
        Console.WriteLine(fstChild.InnerXml);
    }
}