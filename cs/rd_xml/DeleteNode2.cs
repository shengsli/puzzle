using System;
using System.Linq;

namespace LINQtoXML
{
    class Program
    {
        static void Main(string[] args)
        {
            string myXML = @"<Departments>
                            <Department>Support</Department>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Pre-Sales</Department>
                            <Department>Marketing</Department>
                            <Department>Finance</Department>
                            </Departments>";
            
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);
            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            var result = xdoc.Element("Departments").Descendants();
            foreach(XElement item in result)
            {
                Console.WriteLine("Department NAme - " + item.Valye);
            }
        }
    }
}