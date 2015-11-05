using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class MyEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public MyEventArgs()
        {
            this.Message = "Countdown Started!";
        }
    }
}
