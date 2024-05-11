namespace DotNet9Demo;
public static class LINQIndexMethodDemo
{
     private static List<Student> GetStudents() => [
            new("Poorna"),
        new("Alexander"),
        new("John"),
        new("Doe"),
        new("Sophia")];

    public static void InDotNet9()
    {
        var students = GetStudents();
      
        foreach (var (index, student) in students.Index())
        {
            Console.WriteLine($"Index: {index} - Name: {student.Name}");
        }
    }

    public static void BeforeDotNet9()
    {
        var students = GetStudents();

        // Before .NET 9
        var query = students.Select((item, index) => (item, index));

        foreach (var student in query)
        {
            Console.WriteLine($"Index: {student.index} - Name: {student.item.Name}");
        }
    }

    public class Student(string name)
    {
        public string Name { get; init; } = name;
    }
}
