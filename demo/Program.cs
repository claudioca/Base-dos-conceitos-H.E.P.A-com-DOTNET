
using demo.src.entities;

class program 
    {
      static void Main(string [] args)
      {
         knight arus = new knight("Arus", 23 , "knight");
         wizard wizard = new wizard("Jenica", 23 , "white wizard");
         Ninja ninja = new Ninja("wedge" , 42 , "ninja");
         BlackWizard blackWizard = new BlackWizard("Topapa", 42 , "Black Wizard" );

         
          Console.WriteLine(arus.Attack());
          Console.WriteLine(wizard.Attack(1));
          Console.WriteLine(wizard.Attack(7));
          Console.WriteLine(ninja.Attack());
          Console.WriteLine(blackWizard.Attack(1));
          Console.WriteLine(blackWizard.Attack(7));
          
      } 
    }
