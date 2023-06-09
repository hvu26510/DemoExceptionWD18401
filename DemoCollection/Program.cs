using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable demoHash = new Hashtable();

            demoHash.Add(1,"Mr.A");
            demoHash.Add("x", "Mr.B");
            //if (demoHash.ContainsKey("3"))
            //{
            //    Console.WriteLine(demoHash["2"].ToString());
            //}


            foreach (DictionaryEntry entry in demoHash)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine(entry.Value);
            }

            Console.ReadLine();
        }
    }
}
