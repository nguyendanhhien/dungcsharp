public class Student
{
    private string name;
    private int rollno;
    private static string college = "BBDIT";
    public Student(string n, int r)
    {
        name = n;
        rollno = r;
    }
    public static void ChangeCollege(string newCollege)
    {
        college = "CODEGYM";
    }
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll No: " + rollno);
        Console.WriteLine("College: " + college);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student("Hien", 101);
        Student s2 = new Student("Son", 102);
        
        Console.WriteLine("Before changing college:");
        s1.Display();
        s2.Display();
        
        Student.ChangeCollege("CODEGYM");
        
        Console.WriteLine("\nAfter changing college:");
        s1.Display();
        s2.Display();
    }
}
