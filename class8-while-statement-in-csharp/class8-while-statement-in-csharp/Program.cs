using System;

namespace class8_while_statement_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum;
            sum = 0;
            Console.Write("Enter the first number: ");
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                sum = sum + x;
                Console.Write("Enter another number: ");
                x = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("SUM = " + sum);
        }
    }
}
