using ConsoleApp1;
namespace inheritance;

/*class Animal
{
    public Animal()
    {
        Console.WriteLine("Animal's constructor");
    }
    public virtual void sing()
    {
        Console.WriteLine("Animal is singing");
    }
}
class Cow: Animal
{
    public Cow()
    {
        Console.WriteLine("cow's constructor");
    }
    public override void sing()
    {
        Console.WriteLine(" cow is singing");
    }
}*/
class Loans
{
   // public Loans()
    //{
      //  Console.WriteLine("Loans constructor");
    //}
    public virtual void Calculateint()
    {
        Console.WriteLine("Calculate loan interest");
    }
}
class Personalloans : Loans
{
    //public Personalloans()
    //{
      //  Console.WriteLine("Personalloan's constructor");
    //}
    public override void Calculateint()
    {
        Console.WriteLine(" show us the formula to calculate personal loans");
    }
}
class Educationloan : Loans
{
   // public Educationloan()
    //{
      //  Console.WriteLine("Educationloan constructor");
    //}
    public override void Calculateint()
    {
        Console.WriteLine("show us the formula to calculate Education loan");
    }
}
class Program
{
    public static void Main()
    {
        Loans loa = new Personalloans();
        Loans loaed = new Educationloan();
        loa.Calculateint();
        loaed.Calculateint();
     
    }
}
