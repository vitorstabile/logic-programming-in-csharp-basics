using System;

namespace class11_matrix_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N, i, j;

            Console.Write("How many rows the matrix will be? ");
            M = int.Parse(Console.ReadLine());
            Console.Write("How many columns the matrix will be? ");
            N = int.Parse(Console.ReadLine());

            int[,] mat = new int[M, N];

            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write("Element [" + i + "," + j + "]: ");
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Typed Matrix:");
            for (i = 0; i < M; i++)
            {
                for (j = 0; j < N; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
