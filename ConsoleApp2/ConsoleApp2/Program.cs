

class Calculator
{
    public int Sub (int a, int b)
    {
        int substract = a - b;
        return substract;
    }
    public int Sub(int a, int b, int c)
    {
        int substract = a - (b+c);
        return substract;
    }
    public double Sub(double a, double b, double c)
    {
        double substract = a - (b+c);
        return substract;
    }
    public int Mul (int a , int b)
    {
        int mult = a * b;
        return mult;
    }
    public int Mul (int a , int b, int c)
    {
        int mult = a * b * c;
        return mult;
    }
    public static void Main(string[] args)
    {
        // creating object
        // Animal ani = new dog();
        //overriding - run time polymorphism.
        //overloading - static polymorphism - compile time polymorphism.
        Calculator cal = new Calculator();
        int sub1 = cal.Sub(2, 1);
        Console.WriteLine("The Difference is " + sub1);
        double sub2 = cal.Sub(8.2, 2.2 , 1.2);
        Console.WriteLine(" the sum is " + sub2);
        int Mul1 = cal.Mul(2, 1);
        Console.WriteLine(" The product is " + Mul1);
        int Mul2 = cal.Mul(1, 2, 3);
        Console.WriteLine("The product is " + Mul2);
    }
}
