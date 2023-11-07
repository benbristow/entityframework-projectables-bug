namespace ProjectablesExample.Models;

public sealed class Comment
{
    public int Id { get; set; }
    public string Text { get; set; } = null!;
    public int? StudentId { get; set; }
    public int? TeacherId { get; set; }
}