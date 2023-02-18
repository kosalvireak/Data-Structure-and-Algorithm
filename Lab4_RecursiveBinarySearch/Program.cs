using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Lab4_RecursiveBinarySearch
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

        static int RecursiveBinarySearch(int[] dataArray, int min, int max, int key)
        {

            if (min > max)
            {
                return -1;
            }
            int mid = (max + min) / 2;


            if (dataArray[mid] == key)
            {
                return mid;
            }
            else if (dataArray[mid] < key)
            {
                return RecursiveBinarySearch(dataArray, mid+1, max, key);
            }
            else
            {
                return RecursiveBinarySearch(dataArray, min, mid-1, key);
            }


        }

        static void Main(string[] args)
        {
            int[] intArray1 = new int[] { 1, 6, 7, 10, 12, 13, 16, 17, 21 };
            int[] intArray2 = new int[] { 2, 3, 4, 7, 10, 11, 13, 16, 19 };

            //int length;

            //Display the array contents
            Console.WriteLine("Array 1:");
            DisplayArray(intArray1, intArray1.Count());

            //ask for a search key
            Console.WriteLine("\nWhat integer do you want to search: ");
            int key = int.Parse(Console.ReadLine());

            //Call the Search algorithm;
            int SearchResult = RecursiveBinarySearch(intArray1, 0, intArray1.Length - 1, key);

            if (SearchResult < 0)
                Console.WriteLine("Not found.");
            else
                Console.WriteLine("found at index number {0}", SearchResult);

            //------ repeat with second array ---------------------------------
            //Display the array contents
            Console.WriteLine("\n\nArray 2:");
            DisplayArray(intArray2, intArray2.Count());

            //ask for a search key
            Console.WriteLine("\nWhat integer do you want to search: ");
            key = int.Parse(Console.ReadLine());

            //Call the Search algorithm;
            SearchResult = RecursiveBinarySearch(intArray2, 0, intArray2.Length - 1, key);
            if (SearchResult < 0)
                Console.WriteLine("Not found.");
            else
                Console.WriteLine("found at index number {0}", SearchResult);

            Console.ReadKey();
        }
    }
}