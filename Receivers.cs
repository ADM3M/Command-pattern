using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    static class Receivers
    {
        public class MathReceiver
        {
            public int Sum(params int[] items)
            {
                int sum = 0;
                foreach (int item in items)
                {
                    sum += item;
                }

                return sum;
            }

            public int Diff(params int[] items)
            {
                int sum = items[0];
                foreach (int item in items)
                {
                    sum -= item;
                }

                return sum;
            }
        }
    }
}
