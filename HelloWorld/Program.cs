using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] {3, 7, 5, 8 ,10, 15};
            //Length
            Console.WriteLine(numbers.Length);

            //IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);

            //Clear
            Array.Clear(numbers, 0, 2);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Copy
            var anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);
            foreach (var num in anotherArray)
            {
                Console.WriteLine(num);
            }

            //Sort
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //Reverse
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
;        }
    }
}