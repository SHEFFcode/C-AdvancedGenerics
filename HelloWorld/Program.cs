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
            //List
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(3);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var index = numbers.IndexOf(1);
            Console.WriteLine(index);
            var lastIndex = numbers.LastIndexOf(1);
            Console.WriteLine(index);

            //count
            Console.WriteLine(numbers.Count);

            //remove first instance of a number
            numbers.Remove(1);

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //remove all instances of the same number
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            //clear - removes all elements from the list

            numbers.Clear();

            Console.WriteLine(numbers.Count);

        }
    }
}