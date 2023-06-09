using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x1 = "abc";
            string x2 = "xyz"; 

            TinhToan.Swap(ref x1, ref x2);

            Console.WriteLine($"x1={x1}, x2 = {x2}");

            Console.ReadKey();
        }
    }
}
