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

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping()
        {
            Console.WriteLine("Shipping Calculated.");
            return 0.00f;
        }
    }

    public interface IShippingCalculator
    {
        float CalculateShipping();
    }


    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
        }
    }

}