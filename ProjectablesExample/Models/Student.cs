namespace ProjectablesExample.Models;

public sealed class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Comment>? Comments { get; set; }
    public ICollection<Course>? Courses { get; set; }
}