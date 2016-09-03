using System;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Intoduce()
        {
            Console.WriteLine($"My name is {FirstName} {LastName}");
        }
    }
}