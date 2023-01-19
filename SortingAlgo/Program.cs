using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgo
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
            Console.WriteLine();


        }


        public static void BubbleSortAscending(int[] input, int length)
        {
            int num_run = 0;

            var itemMoved = false;
            do
            {
                itemMoved = false;
                //loop through every element of the array
                for (int i = 0; i < (length - 1); i++)
                {
                    //compare if the element is greater than the next element, swap them
                    if (input[i] > input[i + 1])
                    {
                        //if true swap the elements
                        int lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;

                        itemMoved = true;//item has moved
                    }
                    num_run++;


                }
            } while (itemMoved);//if item has moved start from the beginning again

            Console.WriteLine("\nNumber of run: " + num_run);

        }

        public static void BubbleSortAscendingImproved(int[] input, int length)
        {
            int count = 0;
            var itemMoved = false;
            do
            {
                itemMoved = false;
                //loop through every element of the array
                for (int i = 0; i < (length - 1); i++)
                {
                    //compare if the element is greater than the next element, swap them
                    if (input[i] > input[i + 1])
                    {
                        //if true swap the elements
                        int lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;
                        itemMoved = true;//item has moved
                    }
                    count++;

                }
                length--;
            } while (itemMoved);//if item has moved start from the beginning again
            Console.WriteLine("\nNumber of run: " + count);
        }

        public static void BubbleSortDesending(int[] input, int length)
        {


            var itemMoved = false;
            do
            {
                itemMoved = false;
                //loop through every element of the array
                for (int i = 0; i < (length - 1); i++)
                {
                    //compare if the element is greater than the next element, swap them
                    if (input[i] < input[i + 1])
                    {
                        //if true swap the elements
                        int lowerValue = input[i + 1];
                        input[i + 1] = input[i];
                        input[i] = lowerValue;

                        itemMoved = true;//item has moveds
                    }


                }
                length--;
            } while (itemMoved);//if item has moved start from the beginning again

        }

        static void Main(string[] args)
        {
            int[] intArray = new int[15];
            int length = 9;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);


            BubbleSortAscending(intArray, length);
            Console.WriteLine("The sorted array normal:");
            DisplayArray(intArray, length);


            BubbleSortAscendingImproved(intArray, length);
            Console.WriteLine("The sorted array improve:");
            DisplayArray(intArray, length);



            BubbleSortDesending(intArray, length);
            Console.WriteLine("\nThe sorted array desending:");
            DisplayArray(intArray, length);

            Console.ReadKey();
        }


    }

}
