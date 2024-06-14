// See https://aka.ms/new-console-template for more information
namespace inheritance
{

    class Pogram
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue("Manish");
            Console.WriteLine("number of elements in Queue : {0} ", queue.Count());
            while (queue.Count() > 0)
            {

                queue.Dequeue();
                Console.WriteLine("number of elements in queue : {0} ", queue.Count());
            }




        }
    }
}
