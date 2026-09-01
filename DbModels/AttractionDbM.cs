namespace DbModels;
using Models;

public class AttractionDbM : Attraction , IEquatable<AttractionDbM>
{
   public override Guid Id { get; set; }

  public override string Name { get; set; }
  public override string Description { get; set; }

    public bool Equals(AttractionDbM other) => (other != null) && (Name == other.Name && Description == other.Description);

    public override bool Equals(object obj) => Equals(obj as AttractionDbM);

    public override int GetHashCode() => (Name, Description).GetHashCode();

}