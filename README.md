<h1 align="center"> C# </h1>

# Content

1. [Chapter 1: The C# Language](#chapter1)
    - [Chapter 1 - Part 1: First Program in C#](#chapter1part1)
    - [Chapter 1 - Part 2: Variables Types in C#](#chapter1part2)
    - [Chapter 1 - Part 3: Data Output in C#](#chapter1part3)
    - [Chapter 1 - Part 4: Data Processing in C#](#chapter1part4)
    - [Chapter 1 - Part 5: Data Casting in C#](#chapter1part5)
    - [Chapter 1 - Part 6: Data Input in C#](#chapter1part6)
    - [Chapter 1 - Part 7: Conditional Statement in C#](#chapter1part7)
    - [Chapter 1 - Part 8: While Statement in C#](#chapter1part8)
    - [Chapter 1 - Part 9: For Statement in C#](#chapter1part9)
    - [Chapter 1 - Part 10: Vectors in C#](#chapter1part10)
    - [Chapter 1 - Part 11: Matrix in C#](#chapter1part11)
2. [Chapter 2: Object Oriented](#chapter2)
    - [Chapter 2 - Part 1: Abstraction](#chapter2part1)
    - [Chapter 2 - Part 2: Encapsulation](#chapter2part2)
    - [Chapter 2 - Part 3: Inheritance](#chapter2part3)
    - [Chapter 2 - Part 4: Polymorphism](#chapter2part4)
  
## <a name="chapter1"></a>Chapter 1: The C# Language

#### <a name="chapter1part1"></a>Chapter 1 - Part 1: First Program in C#

```cs

using System;

namespace class1_first_program_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

```

#### <a name="chapter1part2"></a>Chapter 1 - Part 2: Variables Types in C#

```cs

using System;

namespace class2_variables_types_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double salary, height;
            char genre;
            string name;

            age = 20;
            salary = 5800.5;
            height = 1.63;
            genre = 'F';
            name = "Maria Silva";

            Console.WriteLine(age);
            Console.WriteLine(salary);
            Console.WriteLine(height);
            Console.WriteLine(genre);
            Console.WriteLine(name);
        }
    }
}

```

#### <a name="chapter1part3"></a>Chapter 1 - Part 3: Data Output in C#

```cs

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

```

#### <a name="chapter1part4"></a>Chapter 1 - Part 4: Data Processing in C#

```cs

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

```

#### <a name="chapter1part5"></a>Chapter 1 - Part 5: Data Casting in C#

```cs

using System;

namespace class5_data_casting_in_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            int b;
            a = 5.0;
            b = (int)a;
            Console.WriteLine(b);
        }
    }
}

```

#### <a name="chapter1part6"></a>Chapter 1 - Part 6: Data Input in C#

```cs

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

```

#### <a name="chapter1part7"></a>Chapter 1 - Part 7: Conditional Statement in C#

```cs

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

```

#### <a name="chapter1part8"></a>Chapter 1 - Part 8: While Statement in C#

```cs

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

```

#### <a name="chapter1part9"></a>Chapter 1 - Part 9: For Statement in C#

```cs

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

```

#### <a name="chapter1part10"></a>Chapter 1 - Part 10: Vectors in C#

```cs

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

```

#### <a name="chapter1part11"></a>Chapter 1 - Part 11: Matrix in C#

```cs

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

```

## <a name="chapter2"></a>Chapter 2: Object Oriented

#### <a name="chapter2part1"></a>Chapter 2 - Part 1: Abstraction

How it represents a real object in our system. It must have identity (Class) given by properties (attributes) and methods (functions).

o Class: Structured type that can contain members - Representation of an entity (Product, Customer), service (ProductService, CustomerService), drivers (ProductController), utilities (calculator) and others (views, repositories).
o Attributes (Data or Fields - Ex: Customer has attribute name, email, cpf and etc.)
o Methods (Class functions and operations - Ex: Consult email, consult cpf, change cpf)

• A class can also have:
o Constructors (Special class operation, performed at instantiation of the class. Used to start attribute values ​​or to force the object to receive data or dependency on its instantiation (Dependency injection))
o Overload of constructors or methods (Esoecify more than one constructor or method in the class)
Encapsulation (Getters and Setters)
o Inheritance (from whom this class inherits)
Polymorphism (A class has several forms or functions)

• Object: They are the instance of the class or instance of the type - Ex: Product p1, Client customer1
• Class: It is the definition of the type (Customer Class, Product Class)

• Instantiation: When we instantiate primitive variables (double, int, String ...) it is instantiated in the memory stack. When the command New in Objects, Arrays and Lists is communicated, the dynamic location of memory occurs, where the object is allocated in another area of memory, called Heap and the object will point to the memory address.

• Advantages of object orientation:
o Reuse of the code and delegation of responsibilities

#### <a name="chapter2part2"></a>Chapter 2 - Part 2: Encapsulation

Adds security to an object-oriented application, as it hides class properties.

o An object must not expose any attributes (use of access modifiers - private, protected ...)
o Class attributes are usually accessed by special methods (Getters and Setters), avoiding direct access to the object's property.
o Analogy with a television: When you click on the call button, we do not know what happens internally on the TV. We can say that the methods that connect the TV are encapsulated.

#### <a name="chapter2part3"></a>Chapter 2 - Part 3: Inheritance

Type of association between classes that allows a class to inherit all data and behavior from another

o Can be used for code reuse
o Used for polymorphism - A class has several uses
The whole class java me, inherits from Object (Warper Classes)

#### <a name="chapter2part4"></a>Chapter 2 - Part 4: Polymorphism

A feature that allows variables of the same more generic type to be able to point to objects of different specific types, thus having different behaviors according to each specific type. In some cases, we must perform the upcasting or dowcasting of the object.

<!-- URL's -->
