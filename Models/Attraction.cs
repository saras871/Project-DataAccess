namespace Models;

public class Attraction : IAttraction
{
    public virtual string Name { get; set; }

    public Attraction(string name)
    {
        Name = name;
    }

    public Attraction()
    {
    }
}