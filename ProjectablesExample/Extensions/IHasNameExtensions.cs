using EntityFrameworkCore.Projectables;
using ProjectablesExample.Models;

namespace ProjectablesExample.Extensions;

public static class IHasNameExtensions
{
    [Projectable]
    public static IEnumerable<Comment> Search(this IEnumerable<Comment> source, string search)
        => source.Where(s => s.Text == search);

    [Projectable]
    public static IEnumerable<Comment> SearchComment(this IEnumerable<Comment> source, string search)
        => source.Where(s => s.Text == search);

    [Projectable]
    public static IEnumerable<Course> Search(this IEnumerable<Course> source, string search)
        => source.Where(s => s.Name == search);

    [Projectable]
    public static IEnumerable<Course> SearchCourse(this IEnumerable<Course> source, string search)
        => source.Where(s => s.Name == search);
}