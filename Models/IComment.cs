namespace Models;

public interface IComment
{
    public Guid Id { get; set; }
    public string CommentText { get; set; }
    public DateTime CreatedAt { get; set; }
}