using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    public delegate void EventHandler(object sender, MyEventArgs e);
    public class CounterEvent
    {
        public event EventHandler TimeEvent;

        public void StartEvent(int number)
        {
            IsEvent(new MyEventArgs());
            for (int i = 0; i < number; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Please wait {0} seconds", number - i);
            }            
        }
        protected virtual void IsEvent(MyEventArgs e)
        {
            EventHandler eH = TimeEvent;
            if (eH != null)
                eH(this, e);
        }
    }


}
