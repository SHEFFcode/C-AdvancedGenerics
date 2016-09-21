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
            var builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Replace('-', '+');
            builder.Remove(0, 10);
            builder.Insert(0, new string('_', 10));
            Console.WriteLine(builder);
            Console.WriteLine(builder[2]);
            
        }
    }
}