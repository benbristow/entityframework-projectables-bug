using Microsoft.EntityFrameworkCore;
using ProjectablesExample;
using ProjectablesExample.Extensions;
using ProjectablesExample.Models;

var context = new ProjectablesContext(new DbContextOptionsBuilder<ProjectablesContext>()
    .UseInMemoryDatabase("ProjectablesExample")
    .UseProjectables()
    .Options);
await context.Database.EnsureDeletedAsync();
await context.Database.EnsureCreatedAsync();

var student = new Student
{
    Name = "Joe",
    Comments = new List<Comment>
    {
        new() { Text = "foo" }
    },
    Courses = new List<Course>
    {
        new() { Name = "bar" }
    }
};
await context.Students.AddAsync(student);
await context.SaveChangesAsync();

Console.WriteLine("test 1");
await context.Students
    .Select(s =>
        new
        {
            CommentCount = s.Comments.SearchComment("foo").Count(),
            CourseCount = s.Courses.SearchCourse("bar").Count(),
        })
    .ToListAsync();
Console.WriteLine("pass 1");

Console.WriteLine("test 2");
await context.Students
    .Select(s =>
        new
        {
            CommentCount = s.Comments.Search("foo").Count(),
            CourseCount = s.Courses.Search("bar").Count(),
        })
    .ToListAsync();
Console.WriteLine("pass 2");
