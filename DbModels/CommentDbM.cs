namespace DbModels;

using Models;

public class CommentDbM : Comment
{
    public override Guid Id { get; set; }
    public override string CommentText { get; set; }
    public override DateTime CreatedAt { get; set; }
    public bool Equals(CommentDbM other) => (other != null) && (CommentText == other.CommentText && CreatedAt == other.CreatedAt);

    public override bool Equals(object obj) => Equals(obj as CommentDbM);

    public override int GetHashCode() => (CommentText, CreatedAt).GetHashCode();
}