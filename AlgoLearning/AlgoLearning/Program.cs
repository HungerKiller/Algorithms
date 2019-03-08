using System;
using AlgoLearning.Recursive;
using AlgoLearning.Test;

namespace AlgoLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //TowerOfHanoi.hanoi(4, 1, 2, 3);

            MyStack stack = new MyStack(10000);

            Console.WriteLine("Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");

            for (int i = 0; i < 10000; i++) // fill the stack
                stack.Push("a large, large, large, large, string " + i);

            for (int i = 0; i < 10000; i++) // empty the stack
                stack.Pop();

            Console.WriteLine("Memory Use (approx.): " + (GC.GetTotalMemory(true) / 1024) + " KBytes");

            Console.ReadKey();
        }
    }
}
