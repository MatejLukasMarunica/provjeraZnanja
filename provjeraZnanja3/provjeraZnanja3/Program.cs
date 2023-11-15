using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 0, b = 1, c, n = 0;

            Console.Write(" Upisi broj clanova ");
            unos:
            n = int.Parse(Console.ReadLine());

            if (n< 2)

            {
                Console.Write("upisi veci broj od 2.");
                n = 0;
                goto unos;
            }
            else
            {
                Console.WriteLine(a + " " + b + " ");


                for (int i = 2; i < n; i++)

                {
                    c= a + b;
                    Console.Write(c + " ");
                    a = b;
                    b = c;

                }

            }
            Console.ReadKey();
        }
    }
}
