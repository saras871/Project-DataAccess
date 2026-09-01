namespace DbModels;
using Models;

public class AttractionDbM : Attraction , IEquatable<AttractionDbM>
{
   public AttractionDbM(string name) : base(name) { }

    public bool Equals(AttractionDbM other) => (other != null) && (Name == other.Name);

    public override bool Equals(object obj) => Equals(obj as AttractionDbM);

    public override int GetHashCode() => Name.GetHashCode();

}