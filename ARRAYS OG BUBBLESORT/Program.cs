using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS_OG_BUBBLESORT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();


            Console.WriteLine("Intast antal numre");
            int antal = int.Parse(Console.ReadLine());

            Console.WriteLine("Intast max værdien");

            int[] numbers = new int[antal];
            int max = int.Parse(Console.ReadLine());
            max++;

            for (int i = 0; i < antal; i++)
            {
                numbers[i] = rdn.Next(0, max);
            }

            foreach (int number in numbers)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }

    }
}
