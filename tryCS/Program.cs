using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace cs_lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkDB MyDB = new WorkDB();
            //MyDB.Linq15Variants();//lab 4

            /*int temp;
            do
            {
                Console.WriteLine("0 - Exit\n1 - Add\n2 - Show");
                int.TryParse(Console.ReadLine(), out temp);
                switch (temp)
                {
                    case 0: break;
                    case 1: MyDB.AddProductFast();break;
                    case 2: MyDB.Show();break;
                    default:break;
                }
            }
            while (0 < temp);*/
            Random rnd = new Random();
            List<Data> d1 = new List<Data>();
            List<Data> d2 = new List<Data>();
            for (int x = 0; x < 10; x++)
            {
                Random r = new Random();
                string rndstr1 = "";
                string rndstr2 = "";
                for (int i = 0; i < 5; i++)
                {
                    char a = Convert.ToChar(r.Next(97, 122));
                    char b = Convert.ToChar(r.Next(97, 122));
                    rndstr1 += a;
                    rndstr2 += a;
                }
                Data p1 = new Data(rnd.Next(0, 100), rndstr1);
                Data p2 = new Data(rnd.Next(0, 100), rndstr2);
                d1.Add(p1);
                d2.Add(p2);
            }

            Console.WriteLine("START");
            //ЗАПИСЬ
            /*var xmlDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), //Linq to XML
                new XElement("RootElement",
                    d1.Select(
                       item => new XElement("Rndlst", new XAttribute("Id", item.id),
                    new XElement("NumLine", item.valueNum),
                    new XElement("StringLine", item.valueString)))));
            xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "xmlDoc2.xml"));*/

            /*foreach(var x in d1) //цинлы, НЕ Linq
            {
                xmlDoc.Root.Add(
                    new XElement("Rndlst", 
                    new XAttribute("Id", x.id),
                    new XElement("NumLine",x.valueNum),
                    new XElement("StringLine", x.valueString)));
                xmlDoc.Save(Path.Combine(Environment.CurrentDirectory, "xmlDoc.xml"));
            }*/
            //ЧТЕНИЕ
            /*var std = from Rndlst in XDocument.Load(Path.Combine(Environment.CurrentDirectory, "xmlDoc.xml")).Descendants("Rndlst")
                      where Convert.ToInt32(Rndlst.Element("NumLine").Value) < 70
                      select new Data
                      {
                          id = (int)Rndlst.Attribute("Id"),
                          valueNum = (int)Rndlst.Element("NumLine"),
                          valueString = Rndlst.Element("StringLine").Value.ToString()
                      };
            foreach(var Rnd in std)
            {
                Console.WriteLine(Rnd.ToString());
            }*/

            Console.WriteLine("END");

            Console.ReadKey();
        
        
        
            
        }
    }
}
