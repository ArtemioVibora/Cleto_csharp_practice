using System;

public class GettingStarted
{

    public static double div(int a, int b)
    {
        double quot = (double) a / b;
        return quot;
    }

    public static int sub(int a, int b)
    {
        return a - b;
    }

    public static int multi(int a, int b)
    {
        return a * b;
    }

    public static int add(int a, int b)
    {
        return a + b;
    }
    public static void Main(String[] a)
    {   
        int num1, num2;
        num1 = num2 = 0;

        Console.Write("Enter Number 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Number 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("===============================");
        Console.WriteLine("Number 1: " + num1 + " | Number 2: " + num2);
        Console.WriteLine();

        Console.WriteLine("Addition");
        Console.WriteLine(add(num1, num2));
        Console.WriteLine("Subtraction");
        Console.WriteLine(sub(num1, num2));
        Console.WriteLine("Multiplication");
        Console.WriteLine(multi(num1, num2));
        Console.WriteLine("Division");
        Console.WriteLine(div(num1, num2));
        Console.WriteLine("==============================");
    }

}
