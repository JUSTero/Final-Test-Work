using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Test_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter lenght limit of string");
            int lenghtLimit = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[lenght];
            string[] finalArray = new string[lenght];
            int j = 0;

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter element");
                strings[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Created array:");

            void ArrayPrint(string []array)
            {
                Console.WriteLine();

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }

            ArrayPrint(strings);

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length <= lenghtLimit)
                {
                    finalArray[j] = strings[i];
                    j++;
                }
            }

            Console.WriteLine("Final array:");
            
            ArrayPrint(finalArray);
        }
    }
}
