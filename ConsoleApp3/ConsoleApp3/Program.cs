using System.Runtime.Serialization;

class Stringformatter
{
    static void Format (string text)
    {
        // to change the lower case alphabet to upper case letter
        Console.WriteLine(text.ToUpper());
    } 
    static void Format (string text, int repeat)
    {
        // to print repeat number of times the text.
        for(int i = 0; i < repeat; i++)
        {
            Console.WriteLine(text + " ");
        }
    }
    static void Format(string text1, string text2)
    {
        // to concatenate the given texts.
        string result = string.Concat(text1, text2);
        Console.WriteLine(result);
    }
    public static void Main(string[] args)
    {
        Stringformatter str = new Stringformatter();
        String upper = "hello";
        Format(upper);
        Format(upper, 3);
        Format(upper, upper);
        // a programm to see how we overload the string functions

    }
}
