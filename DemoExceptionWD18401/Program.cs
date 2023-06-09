using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExceptionWD18401
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //int x = -1;
            //try
            //{
            //    x = int.Parse(Console.ReadLine());
            //}catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
            //finally
            //{
            //    if (x == -1)
            //    {
            //        Console.WriteLine("Nhap sai");
            //    }
            //}
            #endregion

            double diem = -1;
            try
            {
                diem = NhapDiem();
            }catch (ScoreException ex)
            {
                Console.WriteLine(ex.Message);
            }finally
            {
                if (diem == -1) {

                    Console.WriteLine("Nhap diem that bai");

                }
            }


            //Console.WriteLine(x);
            Console.ReadKey();
        }

        static double NhapDiem()
        {
            double n = -1;
            Console.WriteLine("Diem: ");
            n = double.Parse(Console.ReadLine());

            if (n < 0 || n > 10)
            {
                throw new ScoreException("Exception: Incorrect format :Diem tu 0 den 10");
            }
            return n;

        }
    }
}
