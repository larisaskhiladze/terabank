using System;
class HomeWork4
{
    static void Main(string[] args)
    {
        Console.ReadLine();
    }
    //Davaleba1
    static int getSum(int x, int y)
    { 
        return x + y;
    }

    // Davaleba2

    static void GetParms()
    { 

    Console.WriteLine("enter Num1:");
    decimal Num1 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("enter Num2:");
    decimal Num2 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("enter Num3:");
    decimal Num3 = decimal.Parse(Console.ReadLine());

    Console.WriteLine("enter Num4:");
    decimal Num4 = decimal.Parse(Console.ReadLine());

     
        if (Num1 <= Num2 && Num1 <= Num3 && Num1 <= Num4)
        {
            Console.WriteLine("The Smallest Number is: " + Num1);
        }
        else if (Num2 <= Num1 && Num2 <= Num3 && Num2 <= Num4)
        {
            Console.WriteLine("The Smallest Number is: " + Num2);
        }
        else if (Num3 <= Num1 && Num3 <= Num2 && Num3 <= Num4)
        {
            Console.WriteLine("The Smallest Number is:" + Num3);
        }
        else if (Num4 <= Num1 && Num4 <= Num2 && Num4 <=Num3)
        {
            Console.WriteLine("The Smallest Number is:" + Num4);
        }
        else
        {
            Console.WriteLine("These Numbers is equal");
        }

        if (Num1 >= Num2 && Num1 >= Num3 && Num1 >= Num4)
        {
            Console.WriteLine("The Largest Number is: " + Num1);
        }
        else if (Num2 >= Num1 && Num2 >= Num3 && Num2 >= Num4)
        {
            Console.WriteLine("The Largest Number is: " + Num2);
        }
        else if (Num3 >= Num1 && Num3 >= Num2 && Num3 >= Num4)
        {
            Console.WriteLine("The Largest Number is:" + Num3);
        }
        else if (Num4 >= Num1 && Num4 >= Num2 && Num4 >= Num3)
        {
            Console.WriteLine("The Largest Number is:" + Num4);
        }
        
    }


    // davaleba3

    static void getParms()
    {
        Console.WriteLine("enter folowing fruits:");
        Console.Write("apple, watermelon, melon, cherry, strawberry");
        string fruits = Console.ReadLine();

        switch (fruits)
        {
            case "apple":
                Console.WriteLine("your entered fruit is apple");
                break;
            case "watermelon":
                Console.WriteLine("your entered fruit is watermelon");
                break;
            case "melon":
                Console.WriteLine("your entered fruit is melon");
                break;
            case "cherry":
                Console.WriteLine("your entered fruit is cherry");
                break;
            case "strawberry":
                Console.WriteLine("your entered fruit is strawberry");
                break;
            default:
                    Console.WriteLine("your entered fruit is wrong");
                break;
        }
    }
}

