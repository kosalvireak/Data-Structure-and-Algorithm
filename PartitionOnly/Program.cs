using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QSBasic myQuickSort;

            int length;
            do
            {
                Console.Write("Enter number of elements (1-15) for the array: ");
                length = int.Parse(Console.ReadLine());
            } while (length < 1 || length > 15);

            myQuickSort = new QSBasic(length);
            myQuickSort.DisplayArray();

            Console.WriteLine("\nAfter Quick sort: ");
            myQuickSort.recQuickSort(0, length - 1);
            myQuickSort.DisplayArray();

            Console.WriteLine("\nAfter 1st partitioning: ");
            myQuickSort.partitionIt(0, (length - 1));
            myQuickSort.DisplayArray();

            Console.Write("\nPick lower index of 2nd interval: ");
            int lowerIndex = int.Parse(Console.ReadLine());
            Console.Write("Pick upper index of 2nd interval: ");
            int upperIndex = int.Parse(Console.ReadLine());

            myQuickSort.partitionIt(lowerIndex, upperIndex);
            myQuickSort.DisplayArray();
            
            Console.ReadKey();
        }
    }
}
