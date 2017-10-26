using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialization_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Person> pp = Init();

            //SaveToSVC(pp);
            //List<Person> pp = InitFromCSV();

            //SaveToXML(pp);
            //List<Person> pp = InitFromXML();

            //SaveToJson(pp);
            //List<Person> pp = InitFromJson();

            //SaveToYaml(pp);
            //List<Person> pp = InitFromYaml();

            Print(pp);
            Console.ReadKey();
        }
        public static void Print(List<Person> pp)
        {
            foreach (Person p in pp)
            {
                Console.WriteLine(p);
            }
        }
        public static List<Person> Init()
        {
            List<Person> pp = new List<Person>();
            pp.Add(new Person(10, "Vasia", "Pupkin", 23));
            pp.Add(new Person(12, "Kasia", "Lupkin", 27));
            pp.Add(new Person(19, "Masia", "Gupkin", 15));
            pp.Add(new Person(25, "Hasia", "Hupkin", 67));
            pp.Add(new Person(89, "Basia", "Nupkin", 33));
            return pp;
        }
        #region SVC
        private static void SaveToSVC(List<Person> pp)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\COURSE\\Person.csv");
            file.WriteLine("Id, Fn, Ln, Age");
            foreach (Person p in pp)
            {
                file.WriteLine(p.ToString());
            }
            file.Close();
        }
        public static List<Person> InitFromCSV()
        {
            List<Person> pp = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@"D:\\COURSE\\Person.csv");
            for (int i = 1; i < lines.Length; i++)
            {
                String[] args = lines[i].Split(',');
                int id = Int32.Parse(args[0].Trim());
                string fn = args[1].Trim();
                string ln = args[2].Trim();
                int age = Int32.Parse(args[3].Trim());
                pp.Add(new Person(id, fn, ln, age));
            }
            return pp;
        }
        #endregion

        #region XML
        public static void SaveToXML(List<Person> pp)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\COURSE\\Person.xml");
            file.WriteLine("Id, Fn, Ln, Age");
            foreach (Person p in pp)
            {
                file.WriteLine(p.ToXML());
            }
            file.Close();
        }
        public static List<Person> InitFromXML()
        {
            List<Person> pp = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@"D:\\COURSE\\Person.xml");

            for (int i = 2; i < lines.Length; i++)
            {
                String[] args = lines[i].Split('<', '>');
                int id = Int32.Parse(args[2].Trim());
                i++;
                args = lines[i].Split('<', '>');
                string fn = args[2].Trim();
                i++;
                args = lines[i].Split('<', '>');
                string ln = args[2].Trim();
                i++;
                args = lines[i].Split('<', '>');
                int age = Int32.Parse(args[2].Trim());
                pp.Add(new Person(id, fn, ln, age));
                i += 2;
            }
            return pp;
        }
        #endregion

        #region JSON
        public static void SaveToJson(List<Person> pp)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\COURSE\\Person.json");
            file.WriteLine("Id, Fn, Ln, Age");
            foreach (Person p in pp)
            {
                file.WriteLine(p.ToJson());
            }
            file.Close();
        }
        public static List<Person> InitFromJson()
        {
            List<Person> pp = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@"D:\\COURSE\\Person.json");

            for (int i = 2; i < lines.Length; i++)
            {
                String[] args = lines[i].Split(':', ',', '}');
                int id = Int32.Parse(args[1].Trim());
                string fn = args[3].Trim();
                string ln = args[5].Trim();
                int age = Int32.Parse(args[7].Trim());
                pp.Add(new Person(id, fn, ln, age));
            }
            return pp;
        }
        #endregion

        #region YAML
        public static void SaveToYaml(List<Person> pp)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\COURSE\\Person.yaml");
            file.WriteLine("Id, Fn, Ln, Age");
            foreach (Person p in pp)
            {
                file.WriteLine(p.ToYaml());
            }
            file.Close();
        }
        public static List<Person> InitFromYaml()
        {
            List<Person> pp = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@"D:\\COURSE\\Person.yaml");

            for (int i = 1; i < lines.Length; i++)
            {
                String[] args = lines[i].Split(':', ',', '}');
                int id = Int32.Parse(args[1].Trim());
                i++;
                args = lines[i].Split(':', ',', '}');
                string fn = args[1].Trim();
                i++;
                args = lines[i].Split(':', ',', '}');
                string ln = args[1].Trim();
                i++;
                args = lines[i].Split(':', ',', '}');
                int age = Int32.Parse(args[1].Trim());
                pp.Add(new Person(id, fn, ln, age));
                i++;
            }
            return pp;
        }
        #endregion
    }
}
