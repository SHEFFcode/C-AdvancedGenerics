using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using HelloWorld.Math;

namespace HelloWorld
{
    public class Person
    {
        public string Name { get; set; }
        private DateTime _birthDate;

        public void setBirthdate(DateTime birthdate)
        {
            this._birthDate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthDate;
        }

        public DateTime Birthdate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public DateTime BirthDate { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.setBirthdate(new DateTime(1982, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}