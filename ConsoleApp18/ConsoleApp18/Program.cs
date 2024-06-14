namespace Linq_excercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = Enumerable.Range(1, 1000).Select(_ => random.Next(1, 1001)).ToArray();
            var average = numbers.Average();
            Console.WriteLine($"Average is :  {average}");
            var maxi = numbers.Max();
            var mini = numbers.Min();
            Console.WriteLine($"maximum number is : {maxi}");
            Console.WriteLine($"minimum number is : {mini}");
            var evenCount = numbers.Count(n => n % 2 == 0);
            var oddsum = numbers.Where(n => n % 2 != 0).Sum();
            Console.WriteLine($"Total even numbers :{evenCount}");
            Console.WriteLine($"Total odd numbers : {oddsum}");
            var extract = Enumerable.Range(1 , 1000).OrderByDescending(n => n).Take(10);
            foreach(var i in extract)
            {
                Console.WriteLine(i);
            }

        }
    }
}
