using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocjenskaVjezbaPetlje03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broj1, broj2, broj3;

            Console.WriteLine("Unesite prvi broj;");
            broj1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            broj2 = int.Parse(Console.ReadLine());

            while (broj2 != 0)
            {
                broj3 = broj1 % broj2;
                broj1 = broj2;
                broj2 = broj3;
            }

            Console.WriteLine("Najveći zajednički djelitelj je:" + broj1);

            Console.ReadKey();
        }
    }
}
