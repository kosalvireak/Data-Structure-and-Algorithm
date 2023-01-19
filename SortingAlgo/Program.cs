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
            
                int Iteration = 0;

                var itemMoved = false;
                do
                {
                   //DisplayArray(input, length);
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
                        Iteration++;
                    }
                } while (itemMoved);//if item has moved start from the beginning again
                Console.WriteLine("Iteration of normal: " + Iteration);
            


        }

        public static void BubbleSortAscendingImproved(int[] input, int length)
        {
            int Iteration = 0;

            var itemMoved = false;
            do
            {
                //DisplayArray(input, length);
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
                    //length--;
                    Iteration++;
                }
            } while (itemMoved);//if item has moved start from the beginning again
            Console.WriteLine("Iteration of improve: " + Iteration);

        }

        public static void BubbleSortDesending(int[] input, int length)
        {

            //int Iteration = 0;

            var itemMoved = false;
            do
            {
                //DisplayArray(input, length);
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

                        itemMoved = true;//item has moved
                    }
                    //Iteration++;
                }
            } while (itemMoved);//if item has moved start from the beginning again
                                //Console.WriteLine("Iteration: " + Iteration);
                                
        }

        static void Main(string[] args)
        {
            int[] intArray = { 33, 44, 66, 23, 60, 56, 32, 77, 15 };
            int length = 9;
            //do
            //{
            //    Console.Write("Enter number of elements (1-15) for the array: ");
            //    length = int.Parse(Console.ReadLine());
            //} while (length < 1 || length > 15);

            //GenerateRandomIntegers(intArray, length);
            Console.WriteLine("The Unsorted array:");
            DisplayArray(intArray, length);

            BubbleSortAscendingImproved(intArray, length);


            //BubbleSortDesending(intArray, length);

            //DisplayArray(intArray, length);

            //BubbleSortAscending(intArray, length);
            
            Console.WriteLine("The sorted array improve:");
            DisplayArray(intArray, length);
            Console.ReadKey();
        }


    }

}
