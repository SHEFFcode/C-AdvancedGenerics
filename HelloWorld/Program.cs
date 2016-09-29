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
    public class PresentationObject
    {
        public int Heigh { get; set; }
        public int Width { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object has been copied.");
        }
    }

    public class Text : PresentationObject
    {
        public int Fontsize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("Hyperlink Added to " + url);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }
    }
}