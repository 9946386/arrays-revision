using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 10;

            int[] task2 = new int[100];
            Random rand = new Random();


            for(int i = 0; i < task2.Length; i++)
            {
                task2[i] = rand.Next(min, max);
                Console.WriteLine("{0}",);
            }

            Console.ReadLine();
        }
        

    }
}
