namespace demo.src.entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype ;
        }
        public override string  Attack(){
            return this.Name + " Lançou sua magia ";
        } 
        public string Attack(int Especial ){

            if (Especial <= 5)
            {
                return this.Name + " Lançou uma magia Especial de nivel " + Especial;
            }
            else
            {
                return this.Name + " Lançou uma magia Especial de nivel " + Especial;
            }
        }
    }
}