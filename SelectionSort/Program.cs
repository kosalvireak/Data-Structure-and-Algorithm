using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
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
        public static void SelectionSort(int[] input, int length)
        {
            
            int n = length - 1;
            for (int i = 0; i <= n; i++)//loop through every element of the array
            {
                int min = i;
                //find the lowest value
                for (int j = i + 1; j <= n; j++)
                {
                    if (input[min] > input[j])
                    {
                        min = j;    //assign j to min so that min now points to the minimum data
                    }
                }

                if (min != i)
                {
                    //swap the elements
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
            }
        }
        public static void SelectionSort_Decending(int[] input, int length)
        {

            int n = length - 1;
            for (int i = 0; i <= n; i++)//loop through every element of the array
            {
                int min = i;
                //find the lowest value
                for (int j = i + 1; j <= n; j++)
                {
                    if (input[min] < input[j])
                    {
                        min = j;    //assign j to min so that min now points to the minimum data
                    }
                }

                if (min != i)
                {
                    //swap the elements
                    var lowerValue = input[min];
                    input[min] = input[i];
                    input[i] = lowerValue;
                }
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


            SelectionSort(intArray, length);
            Console.WriteLine("\nThe Selection Sort array:");
            DisplayArray(intArray, length);

            SelectionSort_Decending(intArray, length);
            Console.WriteLine("\nThe Selection Sort Decending array:");
            DisplayArray(intArray, length);

            Console.ReadKey();
        }
    }
}
