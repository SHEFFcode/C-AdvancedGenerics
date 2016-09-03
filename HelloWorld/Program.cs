using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.Math;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Value type, passed by value.
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"a:{a}, b:{b}");

            //reference types, passed by reference
            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"array1: {array1[0]}, array2: {array2[0]}");

            //another example of value type vs reference type
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {age = 20};
            MakeOld(person);
            Console.WriteLine(person.age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;
        }
    }
}