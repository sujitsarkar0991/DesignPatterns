using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = Factory.GetProduct(3);
            p.Show();
            Console.ReadLine();
        }
    }
}
