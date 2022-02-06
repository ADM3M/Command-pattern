using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    static class CommandReals
    {
        public class SimpleCommand : ICommand
        {
            private string arg1;

            public SimpleCommand(string source)
            {
                this.arg1 = source;
            }

            public void Execute()
            {
                Console.WriteLine(arg1);
            }
        }

        public class Plus : ICommand
        {
            int[] args;
            Receivers.MathReceiver receiver;

            public Plus(Receivers.MathReceiver receiver, params int[] args)
            {
                this.args = args;
                this.receiver = receiver;
            }

            public void Execute()
            {
                Console.WriteLine(receiver.Sum(this.args));
            }
        }

        
    }
}
