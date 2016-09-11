using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class SummaryUtility
    {
        public static string SummarizeText(string sentence, int maxLength = 20)
        {
            /*============== Summarizing Text =======================*/
            //            var sentence = "This is going to be a really really really long text";

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
                return (sentence);
            }
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
            return (summary);

        }
    }
}