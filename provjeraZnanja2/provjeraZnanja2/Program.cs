using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s1, s2, s3;
             
            Console.WriteLine(" Unesi 2 stringa u program. ");
            Console.WriteLine(" Unesi 1. string. ");
            s1 = Console.ReadLine();

            Console.WriteLine(" Unesi 2. string. ");
            s2 = Console.ReadLine();

            s3 = s1 + s2;


            s3.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            
            Console.ReadKey();

        }
    }
}
