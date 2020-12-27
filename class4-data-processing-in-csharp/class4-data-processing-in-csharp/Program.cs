using System;
using System.Globalization;

namespace class4_data_processing_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            int x1, y1;
            x1 = 5;
            y1 = 2 * x1;
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            int x2;
            double y2;
            x2 = 5;
            y2 = 2 * x2;
            Console.WriteLine(x2);
            Console.WriteLine(y2.ToString("F1", CI));

            double b1, b2, h, area;
            b1 = 6.0;
            b2 = 8.0;
            h = 5.0;
            area = (b1 + b2) / 2.0 * h;
            Console.WriteLine(area);

            int a, b, result;
            a = 5;
            b = 2;
            result = a / b;
            Console.WriteLine(result);

        }
    }
}
