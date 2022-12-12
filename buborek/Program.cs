using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buborek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8, 1 };

            for (int i = tomb.Length - 1; i >=1 ; i--)
            {
                for (int j = 0; j <= i-1; j++)
                {
                    if (tomb[j]>tomb[j+1])
                    {
                        int temp = tomb[j];
                        tomb[j] = tomb[j+1];
                        tomb[j + 1] = temp;
                    }
                    
                }
            }



            foreach (var szam in tomb)
            {
                Console.Write($"{szam} ");
            }


            Console.ReadKey();
        }
    }
}
