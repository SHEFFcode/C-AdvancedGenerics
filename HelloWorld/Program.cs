using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using HelloWorld.Math;

namespace HelloWorld
{

    public class Persons
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi, I am {Name}, it is nice to meet you {to}");
        }

        public static Persons CreatePerson(string str)
        {
            var person = new Persons();
            person.Name = str;
            return person;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = Persons.CreatePerson("Peter");
            person.Introduce("mosh");
        }
    }
}