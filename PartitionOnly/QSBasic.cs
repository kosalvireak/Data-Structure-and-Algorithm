using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartitionOnly
{
    internal class QSBasic
    {
        public int length;
        int[] intArray = new int[15];

        public void GenerateRandomIntegers( int length)
        {
            Random r = new Random();
            for (int k = 0; k < length; k++)
                intArray[k] = r.Next() % 100 + 1; 
        }
        public QSBasic(int length)
        {
            GenerateRandomIntegers(length);
            this.length = length;
        }
        public void DisplayArray()
        {
            //int length = intArray.Length;
            Console.Write("Index: ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", k);
            Console.WriteLine();
            Console.Write("data:  ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", intArray[k]);
            Console.WriteLine();
        }

        public void swap(int left, int right)
        {
            int temp = intArray[left];
            intArray[left] = intArray[right];
            intArray[right] = temp;
        }
        public int partitionIt(int left, int right)
        {
            int pivot = intArray[right];
            int leftMark = left - 1;
            int rightMark = right;
            while (true)
            {
                while (intArray[++leftMark] < pivot) ;
                while (rightMark > 0 && intArray[--rightMark]>pivot) ;
                if (leftMark >= rightMark) break;
                else  swap(leftMark,rightMark) ;

            }
            swap(leftMark,right);
            return leftMark;
        }
        public void recQuickSort(int left, int right) //recursive sort
        {
            if (right - left <= 0)                  //if size <= 1,
                return;                             //already sorted
            else                                    //size is 2 or larger
            {
                int pivot = intArray[right];        //rightmost item
                                                    //partition range
                int partition = partitionIt(left, right);
                recQuickSort(left, partition - 1);  //sort left side
                recQuickSort(partition + 1, right); //sort right side
            }
        }  //end recQuickSort()

    }
}
