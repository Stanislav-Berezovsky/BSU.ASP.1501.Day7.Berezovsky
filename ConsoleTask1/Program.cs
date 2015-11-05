using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;
using Task2;

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
            var test = new CounterEvent();
            var timer = new EventNumber(1,test);
            var timer2 = new EventNumber(2,test);
            test.StartEvent(3);

            Console.WriteLine("\nFibonacci");
            foreach (var number in Fibonacci.GetNumbers(5))
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();
        }
    }
}
