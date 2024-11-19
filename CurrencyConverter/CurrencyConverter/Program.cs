using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double rate = 23000d;
            Console.Write("Enter USD: ");
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine(usd + " USD -> " + (usd * rate) + " VND");
            Console.ReadLine();
        }
    }
}
