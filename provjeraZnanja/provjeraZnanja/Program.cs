using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica, novo;

            Console.WriteLine(" Unesi neku rečenicu u string. ");
            recenica = Console.ReadLine();

            novo = recenica.Replace(" ", "_");

            Console.WriteLine(novo);

            Console.ReadKey();
        }
    }
}
