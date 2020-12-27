using System;

namespace class7_conditional_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int time;
            Console.Write("Enter a time of day: ");
            time = int.Parse(Console.ReadLine());

            if (6 <= time && time < 12)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (12 <= time && time < 18)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
