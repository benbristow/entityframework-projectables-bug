using Microsoft.EntityFrameworkCore;
using ProjectablesExample.Models;

namespace ProjectablesExample;

public sealed class ProjectablesContext : DbContext
{
    public ProjectablesContext()
    {
    }

    public ProjectablesContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Comment> Comments { get; init; }
    public DbSet<Course> Courses { get; init; }
    public DbSet<Student> Students { get; init; }
}