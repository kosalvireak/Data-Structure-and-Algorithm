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
            int length = intArray.Length;
            Console.Write("Index: ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", k);
            Console.WriteLine();
            Console.Write("data:  ");
            for (int k = 0; k < length; k++)
                Console.Write("{0,2}, ", intArray[k]);
            Console.WriteLine();
        }
        public void partitionIt(int lower, int higher)
        {

        }
    }
}
