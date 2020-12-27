using System;
using System.Globalization;

namespace class6_data_input_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            double salary1, salary2;
            string name1, name2;
            int age;
            char genre;

            Console.Write("Name of the first person: ");
            name1 = Console.ReadLine();
            Console.Write("Salary of the first person: ");
            salary1 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Name of the second person: ");
            name2 = Console.ReadLine();
            Console.Write("Salary of the second person: ");
            salary2 = double.Parse(Console.ReadLine(), CI);

            Console.Write("Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Genre (F/M): ");
            genre = char.Parse(Console.ReadLine());

            Console.WriteLine("Name 1: " + name1);
            Console.WriteLine("Salary 1: " + salary1.ToString("F2", CI));
            Console.WriteLine("Name 2: " + name2);
            Console.WriteLine("Salary 2: " + salary2.ToString("F2", CI));
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Genre: " + genre);
        }
    }
}
