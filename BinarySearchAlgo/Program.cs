using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgo
{
    internal class Program
    {
        static void DisplayArray(int[] intArray, int length)
        {
            Console.Write("Index: ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", k);
            Console.WriteLine();
            Console.Write("data:  ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", intArray[k]);
            Console.WriteLine();
        }


        static int BinarySearchFor1stOccurance(int[] dataArray, int key)
        {
            int min = 0;
            int max = dataArray.Count() - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key > dataArray[mid])
                    min = mid + 1;
                else
                    max = mid - 1;
                if (dataArray[mid] == key)
                {
                    while (mid > 0 && dataArray[mid - 1] == key )
                    {
                        mid--;
            }
                    return mid;
        }
            }
            return -1; //not found
        }
        //static int BinarySearchFor1stOccurance(int[] dataArray, int key)
        //{
        //    int min = 0;
        //    int max = dataArray.Count() - 1;
        //    while (min <= max)
        //    {
        //        int mid = (min + max) / 2;
        //        if (key > dataArray[mid])
        //            min = mid + 1;
        //        else
        //            max = mid - 1;
        //        if (dataArray[mid] == key)
        //        {
        //            if (mid > 0)
        //            {
        //                while (dataArray[mid - 1] != key)
        //                {
        //                    return mid;
        //                }
        //                mid--;
        //            }
        //            else
        //            {
        //                return 0;
        //            }
        //    }
        //    return -1; //not found
        //}



        static void Main(string[] args)
        {
            int[] intArray1 = new int[] { 1, 6, 6, 7, 8, 10, 12, 15, 16, 20, 23 };
            int[] intArray2 = new int[] { 2, 2, 4, 5, 5, 5, 5, 6, 6, 7, 9, 10 };
            //int length;

            //Display the array contents
            Console.WriteLine("Array 1:");
            DisplayArray(intArray1, intArray1.Count());

            //ask for a search key
            Console.WriteLine("\nWhat integer do you want to search: ");
            int key = int.Parse(Console.ReadLine());

            //Call the Search algorithm;
            int SearchResult = BinarySearchFor1stOccurance(intArray1, key);
            if (SearchResult < 0)
                Console.WriteLine("Not found.");
            else
                Console.WriteLine("found at index number {0}", SearchResult);

            //------ repeat with second array -----------
            //Display the array contents
            Console.WriteLine("\n\nArray 2:");
            DisplayArray(intArray2, intArray2.Count());

            //ask for a search key
            Console.WriteLine("\nWhat integer do you want to search: ");
            key = int.Parse(Console.ReadLine());

            //Call the Search algorithm;
            SearchResult = BinarySearchFor1stOccurance(intArray2, key);
            if (SearchResult < 0)
                Console.WriteLine("Not found.");
            else
                Console.WriteLine("found at index number {0}", SearchResult);

            Console.ReadKey();
        }
    }
}
