
using System.Security.Principal;
using System.Xml.Linq;

namespace Linq_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQReadXML();
        }
        private static void LINQReadXML ()
        {
            string myXML = @"<Departments>
                            <Department>Account</Department>
                            <Department>Sales</Department>
                            <Department>Presales</Department>
                            <Department>Marketing</Department>
                            </Departments>";
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new element
            //  xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //add new elements at first
            //xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            // remove a node
            object value = xdoc.Descendants().Where(s => s.Value() == "Sales").Remove();
            var result = xdoc.Element("Departments").Descendants();
            foreach (XElement item in result)
            {
                Console.WriteLine("Department name - " + item.Value);
            }
            Console.WriteLine("press any key to continue ");
            Console.ReadKey();
        }
    }
}
