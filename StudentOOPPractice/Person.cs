using System;

public class Person
{
    private string name;
    private int age;

    public void setName(string name)
    {
        this.name = name;
    }

    public void setAge(int age)
    {
        this.age = age;
    }

    public string getName()
    {
        return name;
    }
    
    public int getAge()
    {
        return age;
    }

    public void printHello()
    {
        Console.WriteLine("Hello!");
    }

    public void enterDetails()
    {
        Console.Write("Enter name: ");
        name = Console.ReadLine();
        Console.Write("Enter age: ");
        age = Convert.ToInt32(Console.ReadLine());

    }

    public void displayDetails()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);

    }

}
