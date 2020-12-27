using System;

namespace class9_for_statement_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, i, x, sum;

            Console.Write("How many numbers will be enter? ");
            N = int.Parse(Console.ReadLine());

            sum = 0;
            for (i = 1; i <= N; i++)
            {
                Console.Write("Enter a number: ");
                x = int.Parse(Console.ReadLine());
                sum = sum + x;
            }

            Console.WriteLine("SUM = " + sum);
        }
    }
}
