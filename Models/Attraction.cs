namespace Models;

public class Attraction : IAttraction
{
    public virtual string Name { get; set; }
    public virtual Guid Id { get;  set; }
    public virtual string Description { get;  set; }

    public Attraction(string name, string description, Guid id)
    {
        Name = name;
        Description = description;
        Id = id;
    }

    public Attraction()
    {
    }
}