namespace demo.src.entities
{
    public class wizard : Hero
    {
        public wizard(string Name, int Level, string Herotype) : base(Name, Level, Herotype)
        {
            this.Name = Name;
            this.Level = Level;
            this.Herotype = Herotype ;
        }

          public override string  Attack(){
            return this.Name + " Lançou sua magia ";
        } 

        public string Attack(int bonus){

           if(bonus > 6) {
                return this.Name + " Lançou uma magia super efetiva com bonus de  " + bonus;
           }else{
               return this.Name + " Lançou uma magia com força fraca com bonus de " + bonus ;
           }

            
        }

        
    }
}