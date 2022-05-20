namespace demo.src.entities
{
    public class knight : Hero
    {
        public knight(string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype ;
        }
    }
}