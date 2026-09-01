namespace Models;

public class Comment : IComment
{
    public virtual Guid Id { get; set; }
    public virtual string CommentText { get; set; }
    public virtual DateTime CreatedAt { get; set; }

    public Comment(string commentText, DateTime createdAt, Guid id)
    {
        CommentText = commentText;
        CreatedAt = createdAt;
        Id = id;
    }

    public Comment()
    {
    }
}