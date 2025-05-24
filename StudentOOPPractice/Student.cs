using System;

public class Student : Person
{
    private int studentNumber;
    private string sectionName;

    public void setSectionName(string sectionName)
    {
        this.sectionName = sectionName;
    }
    

    public void setStudentNumber(int studentNumber)
    {
        this.studentNumber = studentNumber;
    
    }
    
    public int getStudentNumber()
    {
        return studentNumber;
    }

    public string getSectionName()
    {
        return sectionName;

    }

    public void enterDetails()
    {
        base.enterDetails();
        Console.Write("Enter student number: ");
        studentNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter section name: ");
        sectionName = Console.ReadLine();
    }

    public void displayDetails()
    {
        base.displayDetails();
        Console.WriteLine("StudentNumber: " + studentNumber);
        Console.WriteLine("Section name: " + sectionName);

    }

}
