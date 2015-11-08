using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;
using Task3;

namespace ConsoleForTasks
{
    class Program
    {

        class EventNumber
        {
            public int Number { get; set; }
            public EventNumber(int number,CounterEvent cE)
            {
                this.Number = number;
                cE.TimeEvent += Reaction;
            }

            public void Reaction(Object sender, MyEventArgs e)
            {
                Console.WriteLine("Event{0}:\t{1}\n" ,Number ,e.Message);
            }
        }

        
        static void Main(string[] args)
        {
            /*var test = new CounterEvent();
            var timer = new EventNumber(1,test);
            var timer2 = new EventNumber(2,test);
            test.StartEvent(3);

            Console.WriteLine("\nFibonacci");
            foreach (var number in Fibonacci.GetNumbers(5))
            {
                Console.WriteLine(number);
            }

            */

            var qqq = new CustomQueue<int>();
            qqq.Enqueue(112);
            qqq.Enqueue(14);
            qqq.Enqueue(1);
            qqq.Enqueue(662);
            qqq.Enqueue(909);
            qqq.Enqueue(112);
            qqq.Enqueue(5555);

            Console.WriteLine("QueueElements:");
            foreach (var q in qqq)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("Dequeue");
            Console.WriteLine(qqq.Dequeue());
             Console.WriteLine(qqq.Dequeue());
            Console.WriteLine("QueueElements:");
            foreach (var q in qqq)
            {
                Console.WriteLine(q);
            }
            Console.WriteLine("Peek:");
            Console.WriteLine(qqq.Peek());
            Console.WriteLine("QueueElements:");
            foreach (var q in qqq)
            {
                Console.WriteLine(q);
            }
            Console.ReadKey();
        }
    }
}
