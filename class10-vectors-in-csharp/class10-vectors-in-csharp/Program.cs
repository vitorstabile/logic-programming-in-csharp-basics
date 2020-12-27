using System;
using System.Globalization;

namespace class10_vectors_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;
            int N, i;

            Console.Write("How many numbers will be enter? ");
            N = int.Parse(Console.ReadLine());

            double[] vet = new double[N];
           
            for (i = 0; i < N; i++)
            {
                Console.Write("Enter a number: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            Console.WriteLine();
            Console.WriteLine("Typed Numbers:");
            for (i = 0; i < N; i++)
            {
                Console.WriteLine(vet[i].ToString("F1", CI));
            }
        }
    }
}
