using System;

class Practice1
{
    static void FindTheLowestVar(int[] arr)
    {
        int lowest = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < lowest)
            {
                lowest = arr[i];
            }
        }
        
        Console.WriteLine("The Lowest is " + lowest);
    }
    
    static void FindTheHighestVar(int[] arr)
    {
        int highest = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > highest)
            {
                highest = arr[i];
            }
        }
        
        Console.WriteLine("The Highest is " + highest);
    }
    
    static void EnterVar(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("Enter var: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
    static void PrintVar(int[] arr)
    {
        Console.Write("{");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i != arr.Length - 1)
            {
                Console.Write(arr[i] + ", ");
            }
            else
            {
                Console.Write(arr[i]);
            }
        }
        Console.Write("}");
    }
    
    static void Main()
    {
        int[] arr = new int[4];
        EnterVar(arr);
        PrintVar(arr);
        Console.WriteLine(); 
        FindTheLowestVar(arr);
        FindTheHighestVar(arr);
    }
}
