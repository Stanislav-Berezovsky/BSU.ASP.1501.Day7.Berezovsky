using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Fibonacci
    {
        public static IEnumerable<int> GetNumbers(int count)
        {
            int x = 0;
            int y = 1;
            int temp = 0;
            for (int i = 0; i < count; i++)
            {
                temp = x + y;
                x = y;
                y = temp;
                yield return temp;
            }
        }
    }
}
