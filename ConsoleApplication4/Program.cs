using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Test> stack = new Stack<Test>();

            stack.Push(new Test("n0"));
            stack.Push(new Test("n1"));
            stack.Push(new Test("n2"));
            stack.Push(new Test("n3"));
            stack.Push(new Test("n4"));

            Console.WriteLine(stack.Pop());
            Console.WriteLine();

            Queue<Test> queue = new Queue<Test>();
            Console.WriteLine(queue.size());
            queue.Enqueue(new Test("n1"));
            queue.Enqueue(new Test("n2"));
            queue.Enqueue(new Test("n3"));

            Console.WriteLine(queue.size());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.get(0));
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.size());
            Console.WriteLine();

            ArrayList<Test> array = new ArrayList<Test> { };

            array.Add(new Test("13"));
            array.Add(new Test("46"));
            array.Add(new Test("10"));
            array.Add(new Test("32"));
            array.Add(new Test("5"));
            array.Add(new Test("27"));

            Console.WriteLine(array.get(2));
            array.Remove(2);
            Console.WriteLine(array.get(2));
            Console.ReadKey();
        }
    }
}
