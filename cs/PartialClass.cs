using System;

public partial class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Points { get; set; }
}
public partial class Course
{
    public void PrintCourse()
    {
        Console.WriteLine("module code: " + Id);
        Console.WriteLine("name: " + Name);
        Console.WriteLine("credit: " + Points);
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Course course = new Course();
        course.Id = 1001;
        course.Name = "C# partial";
        course.Points = 3;
        course.PrintCourse();
    }
}