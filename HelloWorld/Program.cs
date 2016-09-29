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
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
            {
                Console.WriteLine("You are our best and only customer.");
            }
            else
            {
                Console.WriteLine("You are a horrible cusotmer.");
            }
        }

        public int CalculateRating()
        {
            return 0;
        }
    }


    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            var rating = customer.CalculateRating();
        }
    }
}