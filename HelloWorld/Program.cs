using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse("abc");
            int numner;
            var result = int.TryParse("abc", out number);

            if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("conversion failed.");
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            var result = calculator.Add(2, 2);
            Console.WriteLine(result);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(0, 0);
                point.Move(new Point(40, 60));
                Console.WriteLine($"x: {point.X}, y: {point.Y}");

                point.Move(100, 200);
                Console.WriteLine($"x: {point.X}, y: {point.Y}");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
            }
        }
    }
}