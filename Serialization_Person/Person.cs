using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serialization_Person
{
    public class Person
    {
        public int id;
        public string fn;
        public string ln;
        public int age;

        public Person(int id, string fn, string ln, int age)
        {
            Init(id, fn, ln, age);
        }
        public void Init(int id, string fn, string ln, int age)
        {
            this.id = id;
            this.fn = fn;
            this.ln = ln;
            this.age = age;
        }
        public override string ToString()
        {
            string str = "";
            str += id + ", ";
            str += fn + ", ";
            str += ln + ", ";
            str += age;
            return str;
        }
        public string ToXML()
        {
            string str = "<Person>\n";
            str += "\t<id>" + id + "</id>\n";
            str += "\t<fn>" + fn + "</fn>\n";
            str += "\t<ln>" + ln + "</ln>\n";
            str += "\t<age>" + age + "</age>\n";
            str += "</Person>";
            return str;
        }
        public string ToJsonSimple()
        {
            string str = "{";
            str += "id:" + id + ", ";
            str += "fn:" + fn + ", ";
            str += "ln:" + ln + ", ";
            str += "age:" + age;
            str += "}";
            return str;
        }
        public string ToJson()
        {
            string str = "{";
            str += "\"id\":" + id + ", ";
            str += "\"fn\":\"" + fn + "\", ";
            str += "\"ln\":\"" + ln + "\", ";
            str += "\"age\":" + age;
            str += "}";
            return str;
        }
        public string ToYaml()
        {
            string str = "";
            str += "Id:" + id;
            str += "\nFirstName:" + fn;
            str += "\nLastName:" + ln;
            str += "\nAge:" + age + "\n";
            return str;
        }
    }
}
