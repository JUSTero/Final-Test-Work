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
            Console.WriteLine("Enter lengh limit of string");
            int lenghtLimit = Convert.ToInt32(Console.ReadLine());
            string[] strings = new string[lenght];

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine("Enter element");
                strings[i] = Console.ReadLine();
            }


        }
    }
}
