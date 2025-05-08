using System;

public class Calculator
{
    public static int Addition(int num1, int num2)
    {
        return num1 + num2;
    }
    
    public static int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }
    
    public static int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public static void Division(int num1, int num2)
    {
        double quot = 0;
        
        if (num2 == 0)
        {
            Console.WriteLine("Error: Cannot be divided by zero!");
        }
        else
        {
            quot = (double) num1 / num2;
            Console.WriteLine("The quotient is: " + quot);
        }
    }
    
    public static int numPrompt()
    {
        int num = 0;
        
        Console.Write("What is the number: ");
        num = Convert.ToInt32(Console.ReadLine());
        
        return num;
    }
    
    public static void optionsMenu()
    {
        Console.WriteLine("===================");
        Console.WriteLine("<1> Addition");
        Console.WriteLine("<2> Subtraction");
        Console.WriteLine("<3> Multiplication");
        Console.WriteLine("<4> Division");
        Console.WriteLine("<5> Exit");
        Console.WriteLine("===================");
    }
    
    public static void Main(String[] args)
    {
           bool flag = true;    
           int input = 0;
           int num1, num2;
           num1 = num2 = 0;    
           while (flag)
           {
               optionsMenu();
               Console.Write("What is your input: ");
               input = Convert.ToInt32(Console.ReadLine());
               switch(input)
               {
                    case 1:
                        num1 = numPrompt();
                        num2 = numPrompt();
                        Console.Write("The sum is: ");
                        Console.WriteLine(Addition(num1, num2));
                        break;
                    case 2:
                        num1 = numPrompt();
                        num2 = numPrompt();
                        Console.Write("The difference is: ");
                        Console.WriteLine(Subtraction(num1, num2));
                        break;
                    case 3:
                        num1 = numPrompt();
                        num2 = numPrompt();
                        Console.Write("The product is: ");
                        Console.WriteLine(Multiplication(num1, num2));
                        break;
                    case 4:
                        num1 = numPrompt();
                        num2 = numPrompt();
                        Division(num1, num2);
                        break;
                    case 5:
                        Console.WriteLine("Good Bye!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
               }
           }
    }
}
