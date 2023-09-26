using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequential_writing_of_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            int[] array3 = new int[array1.Length + array2.Length];

            Rand(1, 10);

            for (int i = 0; i < array3.Length; i++)
            {
                if (i % 2 == 0)
                    array3[i] = array1[i / 2];
                else
                    array3[i] = array2[i / 2];
            }

            foreach (int num in array3)
            {
                Console.Write(num + " ");
            }


            void Rand(int number1, int number2)
            {
                Random rand = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = rand.Next(number1, number2);

                    Console.Write(array1[i] + " ");

                }
                Console.Write("\n");
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = rand.Next(number1, number2);

                    Console.Write(array2[i] + " ");

                }
                Console.Write("\n\n");
            }
        }
    }
}
