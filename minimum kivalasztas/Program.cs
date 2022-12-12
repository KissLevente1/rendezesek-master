using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minimum_kivalasztas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 1 };
            for (int i = 0; i < tomb.Length; i++)
            {
                int min = i;
                for (int j = i+1; j < tomb.Length; j++)
                {
                    if (tomb[min]> tomb[j])
                    {
                        min = j;
                    }
                }

                int temp = tomb[i];
                tomb[i] = tomb[min];
                tomb[min] = temp;
            }

            foreach (var szam in tomb)
            {
                Console.Write($"{szam}, ");
            }

            Console.ReadKey();
        }
    }
}
