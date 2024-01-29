using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj:");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite drugi broj:");
            int drugiBroj = int.Parse(Console.ReadLine());

            int najveciDjeljiviBroj = 0;

            for (int i = 1; i <= Math.Min(prviBroj, drugiBroj); i++)
            {
                if (prviBroj % i == 0 && drugiBroj % i == 0)
                {
                    najveciDjeljiviBroj = i;
                }
            }

            Console.WriteLine("Najveći broj djeljiv s oba broja je: " + najveciDjeljiviBroj);
            Console.ReadKey();
        }
    }
}
