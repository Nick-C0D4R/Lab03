using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "provider", "customer", "article", 33);
            Console.WriteLine(invoice.GetSum());
            Console.WriteLine(invoice.GetSum(false));
        }
    }
}
