// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    
    public static void arrInput(int[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.Write("Enter number: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    public static void arrDisplay(int[] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("Number in index " + i + " is " + arr[i]);
        }
    }
    
    public static void Main(string[] args)
    {
        int[] num = new int[3];
        arrInput(num);
        arrDisplay(num);
    }
}
