using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provjeraZnanja4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brojevi;
            string broj1, broj2, broj3;

            Console.WriteLine(" Unesi 3 broja u niz odvojene razmakom. ");
            brojevi = Console.ReadLine();

            broj1 = brojevi.Substring(0, brojevi.IndexOf(" "));
            broj3 = brojevi.Substring(brojevi.LastIndexOf(" ", brojevi.Length - 1));
            broj2 = brojevi.Substring(brojevi.IndexOf(" "), brojevi.LastIndexOf(" "));

            Convert.ToDouble(broj1);
            Convert.ToDouble(broj2);
            Convert.ToDouble(broj3);

            

        }
    }
}
