using System;

public class MatrixDisplay
{
    public static void EnterDetails(int[,] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write("Enter number of row " + (i + 1) + " of coluimn " + (j + 1) + ": ");
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }
    
    public static void DisplayDetails(int[,] arr)
    {
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine();
            for (int j  = 0; j < 3; j++)
            {
                Console.Write(arr[i,j] + "  ");
            }
        }
    }
    
    public static void Main(String[] param)
    {
        int[,] arr = new int[3, 3];
        EnterDetails(arr);
        DisplayDetails(arr);
    }
}
