using System.Collections;

namespace VD915
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue intQueue = new Queue();
            for (int i = 0; i < 5; i++)
            {
                intQueue.Enqueue(i * 5);
            }
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            Console.WriteLine($"\nDequeue\t{intQueue.Dequeue()}");
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            Console.WriteLine($"\nDequeue\t{intQueue.Dequeue()}");
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);

            Console.WriteLine($"\nPeek\t{intQueue.Peek()}");
            Console.Write("intQueue values:\t");
            PrintValues(intQueue);
        }

        static void PrintValues(IEnumerable myCollection)
        {
            IEnumerator myEnumerator = myCollection.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                Console.Write($"{myEnumerator.Current}");
                Console.WriteLine();
            }
        }
    }
}