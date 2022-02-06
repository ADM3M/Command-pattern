using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class ButtonPlus
    {
        ICommand invoker = new CommandReals.SimpleCommand("+");

        public void ButtonClick()
        {
            this.invoker.Execute();
        }
    }

    class CustomButton
    {
        private ICommand invoker;

        public CustomButton(ICommand command)
        {
            this.invoker = command;
        }

        public void ButtonClick()
        {
            this.invoker.Execute();
        }

        public void SetCommand(ICommand invoker)
        {
            this.invoker = invoker;
        }
    }
}
