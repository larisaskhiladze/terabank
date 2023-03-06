using System;

class MyHomeWork3
{
    static void Main(string[] args)
    {
        Console.WriteLine("please enter number X: ");
        int X = Int32.Parse(Console.ReadLine());

        Console.WriteLine("please enter number Y: ");
        int Y = Int32.Parse(Console.ReadLine());

        Console.WriteLine("please enter number Z: ");
        int Z = Int32.Parse(Console.ReadLine());

        int sum = X + (Y * Z);
        Console.WriteLine("answer is: " +  sum);

        // Homework3-2

        Console.Write("please enter your name: ");
        Console.ReadLine();

        Console.Write("please enter your surname: ");
        Console.ReadLine();

        Console.Write("please enter your age: ");
        int age = Int32.Parse(Console.ReadLine());

        Console.Write("please enter your weight:");
        decimal weight = decimal.Parse(Console.ReadLine());

        Console.Write("please enter your height:");
        decimal height = decimal.Parse(Console.ReadLine());


        //homework3-3

        Console.Write("please enter your weight:");
        decimal Weight = decimal.Parse(Console.ReadLine());

        Console.Write("please enter your height:");
        decimal Height = decimal.Parse(Console.ReadLine());

        decimal BMI = weight / (height * height);
        Console.WriteLine("your BMI is: decimal BMI");


        //homework3-4

        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine("___|___|___");
        Console.WriteLine("   |   |   ");
        Console.WriteLine(" 7 | 8 | 9 ");
        Console.WriteLine("   |   |   ");


    }
}

