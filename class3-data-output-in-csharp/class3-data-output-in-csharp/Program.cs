using System;
using System.Globalization;

namespace class3_data_output_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Good Morning");
            Console.Write("Good Night");

            Console.WriteLine();

            Console.WriteLine("Good Morning");
            Console.WriteLine("Good Night");

            int x, y;
            x = 10;
            y = 20;
            Console.WriteLine(x);
            Console.WriteLine(y);

            double z;
            z = 2.3456;
            Console.WriteLine(z.ToString("F2", CI));

            int age;
            double salary;
            string name;
            char genre;

            age = 32;
            salary = 4560.9;
            name = "Maria Silva";
            genre = 'F';

            Console.WriteLine("The employee " + name + ", genre " + genre + ", earn " + salary.ToString("F2", CI) + " and have " + age + " years old");

        }
    }
}
