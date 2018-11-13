using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace walutyobceNBP
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("http://www.nbp.pl/kursy/xml/a220z181113.xml");
            XmlNodeList xnList = xml.SelectNodes("/tabela_kursow/pozycja");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tabela kursów średnich walut obcych NBP:\n");
            foreach (XmlNode xn in xnList)
            {
                string nazwaWaluty = xn["nazwa_waluty"].InnerText;
                string przelicznik = xn["przelicznik"].InnerText;
                string kodWaluty = xn["kod_waluty"].InnerText;
                string kursSredni = xn["kurs_sredni"].InnerText;
                Console.WriteLine(nazwaWaluty + " " + " " + przelicznik + " " + kodWaluty + " " + kursSredni);


            }
            Console.ReadKey();
        }
    }
}
