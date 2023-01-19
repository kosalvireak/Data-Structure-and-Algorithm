using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReversal
{
    internal class Program
    {
        static void GenerateRandomIntegers(int[] intArray, int length)
        {// The rand() is a Lib function to generate a constant set of random Integers
            Random r = new Random();
            for (int k = 0; k < length; k++)
                intArray[k] = r.Next() % 100 + 1; // Integers from 1 to 100
        }

        static void DisplayArray(int[] intArray, int length)
        {
            for (int k = 0; k < length; k++)
                Console.Write("{0}, ", intArray[k]);
            

        }

        static void ArrayReversal(int[] intArray, int length)
        {

            int k = 0;
            while(k < length-1)
            {
                int temp = intArray[k];
                intArray[k] = intArray[length - 1];
                intArray[length - 1] = temp;
                length--;
                k++;
            }
            

        }



        static void Main(string[] args)
        {
            int[] intArray = new int[15];
            int length;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);

            //BubbleSort(intArray, length);
            ArrayReversal(intArray, length);
            Console.WriteLine("\nThe reversed array:");
            DisplayArray(intArray, length);
            Console.ReadKey();
        }
    }
}
