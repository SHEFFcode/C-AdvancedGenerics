using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using HelloWorld.Math;

namespace HelloWorld
{

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            
        }

    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }


    }

    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            Shape shape = text;


            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            //StreamReader streamReader = new StreamReader(new MemoryStream());
            var list = new ArrayList();
            list.Add(1);
            list.Add("Hello");


            //downcasting
            Shape shapes = new Text();
            Text text = (Text)shape;
        }
    }

}