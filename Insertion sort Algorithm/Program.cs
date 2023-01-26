using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
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

        static int[] InsertionSort(int[] inputArray, int length)
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
        }

        static int[] InsertionSortNew(int[] inputArray, int length)
        {
            for (int i = 0; i < length ; i++)
            {
                int key = inputArray[i];
                int j = i - 1;
                while (j>= 0 && inputArray[j] > key)
                {
                    inputArray[j + 1] = inputArray[j];
                    j--;
                }
                inputArray[j+1] = key;
                
            }
            return inputArray;
        }

        static int[] InsertionSort_Decending(int[] inputArray, int length)
        {
            for (int i = 0; i < length -1 ; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] < inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                }
            }
            return inputArray;
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


            InsertionSort(intArray, length);
            Console.WriteLine("\n The Insertion Sort array:");
            DisplayArray(intArray, length);

            InsertionSortNew(intArray, length);
            Console.WriteLine("\n The Insertion Sort CPP array:");
            DisplayArray(intArray, length);

            InsertionSort_Decending(intArray, length);
            Console.WriteLine("\n The Insertion Sort Decending array:");
            DisplayArray(intArray, length);
            Console.ReadKey();
        }
    }
}
