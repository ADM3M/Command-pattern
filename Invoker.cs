using System;
using System.Collections.Generic;

namespace CommandPattern
{
    class Invoker
    {
        List<ICommand> commandList;
        int current;

        public Invoker(params ICommand[] args)
        {
            this.commandList = new List<ICommand>(args);
            this.current = 0;
        }

        public void AddCommand(params ICommand[] args)
        {
            foreach (var item in args)
            {
                this.commandList.Add(item);
            }
        }

        public void InvokeNext()
        {
            if (this.current >= this.commandList.Count)
            {
                throw new ArgumentException("index was outside bounds of commands list");
            }

            this.commandList[current++].Execute();
        }

        public void InvokeAll()
        {
            foreach (var item in this.commandList)
            {
                item.Execute();
            }
        }
    }
}
