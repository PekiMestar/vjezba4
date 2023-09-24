using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibunacijevNiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pozicija, rezultat, prethodni, drugiPrethodni ;

            rezultat = 0;
            prethodni = 1;
            drugiPrethodni = 0;

            Console.WriteLine("Unesi poziciju broja u Fibonaccijevom nizu: ");
            pozicija = int.Parse(Console.ReadLine());

            if (pozicija > 0)
            {
                for (int i = 1; i < pozicija; i++)
                {                   
                    rezultat = prethodni + drugiPrethodni;
                    drugiPrethodni = prethodni;
                    prethodni = rezultat;
                }
            }

            Console.WriteLine("Rezultat na poziciji " + pozicija + " iznosi: " + rezultat);

            Console.ReadKey();
        }
    }
}