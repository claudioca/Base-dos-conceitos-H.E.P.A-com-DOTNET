namespace demo.src.entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype ;
        }

          public override string  Attack() => this.Name + " lançou sua shuriken ";
    }
}    