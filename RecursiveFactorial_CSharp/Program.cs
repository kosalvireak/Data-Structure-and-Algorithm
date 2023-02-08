using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFactorial_CSharp
{
    internal class Program
    {
        static int iteractiveFactorial(int N)
        { // Iterative Function Using Loop
            int Fact = 1;
            while (N > 1)
            {
                Console.Write("{0} * ", N);
                //cout << N << " * ";
                Fact *= N--;
            }
            Console.Write("{0} ", N);
            //cout << N;
            return Fact;
        }

        static int recursiveFactorial(int N)
        { // Recursive Function
            if (N <= 0)
            {
                Console.WriteLine("1");
                return 1;
            }
            else
            {
                Console.Write("{0} * ", N);
                return N*(recursiveFactorial(N-1));

            }
        }

        static void Main(string[] args)
        {
            int N;
            do
            {
                Console.Write("Enter a positive integer (maximum value 10): ");
                N = int.Parse(Console.ReadLine());
            } while (N <= 0 || N > 15);
            Console.WriteLine("\n");
            Console.WriteLine("\nIterative Factorial {"+N+"} = " + iteractiveFactorial(N).ToString());
            Console.WriteLine("\n");
            Console.WriteLine("\nRecursive Factorial {" + N +"} = " + recursiveFactorial(N).ToString());
            Console.ReadKey();
        }
    }
}
