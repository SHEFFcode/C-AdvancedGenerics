using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Doe";
            john.Intoduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);

            //Arrays
            var numbers = new int[3] {1, 2, 3};

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            //Strings
            var FirstName = "Jeremy";
            var numbersArray = new int[3] {1, 2, 3};
            var list = string.Join(",", numbersArray);

            Console.WriteLine(list);

            var line = "Hi There \n folks how is the life going c:\\asdas\\asdsa\\asda";
            var newLine = @"Hi there
                            This is a new line 
                            c:\sadsa\asdas\asdasda";

            Console.WriteLine(line, newLine);

        }
    }
}