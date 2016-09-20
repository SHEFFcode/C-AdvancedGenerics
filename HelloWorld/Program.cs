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
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Jeremy Shefer ";
            Console.WriteLine($"Whitespace Trimmer: {fullName.Trim()}");
            Console.WriteLine($"Uppercase: {fullName.Trim().ToUpper()}");

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");

            var nameArr = fullName.Split(' ');
            Console.WriteLine($"FIrst name: {nameArr[0]}, Last Name: {nameArr[1]}");
            var newFullName = fullName.Replace("Jeremy", "Yuriy");
            Console.WriteLine(newFullName);

            if (String.IsNullOrWhiteSpace(""))
            {
                Console.WriteLine("SUpplied string is invalid");
            }

            var age = "25";
            var numAge = Convert.ToByte(age);

            var price = 10.99f;
            var priceString = price.ToString("C");

            Console.WriteLine(priceString);


            /*============== Summarizing Text =======================*/
            var sentence = "This is going to be a really really really long text";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();
                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                    {
                        break;
                    }
                }

                var summary = String.Join(" ", summaryWords) + "...";
                Console.WriteLine(summary);
            }

            SummaryUtility.SummarizeText("This trip");

            /*=================== String Builder ==========================*/



        }
    }
}