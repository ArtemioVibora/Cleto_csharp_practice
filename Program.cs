using System;

//Activity for C#
class Program
{
   //This function determines the highest number
    public static void determineHighestNumber()
    {
        int highest = 0;
        int input = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: ");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input > highest)
                {
                    highest = input;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Error!");
            }
        }

        Console.WriteLine("The Highest number is: " + highest);
    }

    //If five is entered while loop will break
    public static void notFive()
    {
        int input = 0;
        while (input != 5)
        {
            Console.Write("Enter number: ");
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid Input! Error!");
            }
        }
        Console.WriteLine("Thank you for entering five hehe"); 
    }

    //Combination of the two 'questions' of activities
    public static void CLI()
    {
        
        bool flag = true;
        int input = 0;

        while(flag)
        {
            Console.WriteLine();
            Console.WriteLine("<1> Highest Number");
            Console.WriteLine("<2> Not Five");
            Console.WriteLine("<3> Exit");
            Console.Write(">>>> ");
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    determineHighestNumber();
                    break;
                case 2:
                    notFive();
                    break;
                case 3:
                    flag = false;
                    break;
                default:
                    break;
            }
        }
    }

    public static void Main(string[] args)
    {
        //Very small CLI 
        CLI();
    }
}
