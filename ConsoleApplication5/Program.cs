using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            var mm = DateTime.UtcNow.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
            DateTime dt = DateTime.Parse("10/10/2020");
            var tt = dt.ToUniversalTime();

            DateTime saveUtcNow = DateTime.UtcNow;

            string date = "2020-10-22 00:00:00.000";

            DateTime d = DateTime.Parse(date);            
            string result = d.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss")+"-00:00";


            var pp = DateTime.Now;
            var fff =DateTime.Parse(pp.ToShortDateString()).Add(DateTime.Now.TimeOfDay);


            DateTime bdt = DateTime.Parse(result);

            var gg = bdt.ToString();
            return;

            /*
            string g = "25";
            object m = (object)g;
            int intehr = m;

            Console.WriteLine("----OLD TREE STARTS---");
            XElement doc = XElement.Parse(@"<magento_api>
                                              <data_item>
                                                <code>400</code>
                                                <message>Attribute weight is not applicable for product type Configurable Product</message>
                                              </data_item>
                                              <data_item>
                                                <code>400</code>
                                                <message>Resource data pre-validation error.</message>
                                              </data_item>
                                              <data_item>
                                                <code>1</code>
                                                <message></message>
                                              </data_item>
                                              <data_item>
                                                <code><code1></code1><code2></code2></code>
                                                <message>No code was given</message>
                                              </data_item>
                                        </magento_api>");
            Console.Write(doc.ToString());
            Console.WriteLine("");
            Console.WriteLine("----OLD TREE ENDS---");
            Console.WriteLine("");
            doc.Descendants().Where(e => string.IsNullOrEmpty(e.Value)).Remove();
            Console.WriteLine("----NEW TREE STARTS---");
            Console.Write(doc.ToString());
            Console.WriteLine("");
            Console.WriteLine("----NEW TREE ENDS---");
            Console.ReadKey();
            */
        }
    }
}
