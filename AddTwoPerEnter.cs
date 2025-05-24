using System;

public class AddTwoPerEnter
{


    public static int addTwo()
    {
        int number = 0;

        Console.Write("Enter number: ");
        number = Convert.ToInt32(Console.ReadLine());

        return number + 2;

    }

    public static void Main(string[] a)
    {
        int num = 0;
        num = addTwo();
        
        Console.WriteLine("Two added: " + num);
        

    }
}
