using System;

class testBashCS
{
    static void Main(string[] a)
    {
        int sum = 0;
        for (int i = 0; i < 2; i++)
        {
            sum += Convert.ToInt32(a[i]);
        }

        Console.WriteLine("Sum is " + sum);

    }

}
