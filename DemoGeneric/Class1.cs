using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoGeneric
{
    static class TinhToan
    {
        //public static void Swap(ref int a, ref int b)
        //{
        //    int temp = a;
        //    a= b;
        //    b= temp;
        //}

        //public static void Swap(ref double a, ref double b)
        //{
        //    double temp = a;
        //    a = b;
        //    b = temp;
        //}

        public static void Swap<T>(ref T a, ref T b)
        {
            var temp = a; a = b; b = temp;
        }
    }
}
