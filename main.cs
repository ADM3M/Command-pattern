
using System;

namespace CommandPattern
{
    class main
    {
        static void Main(string[] args)
        {
            var plusButton = new ButtonPlus();
            plusButton.ButtonClick();

            var customButton = new CustomButton(new CommandReals.SimpleCommand("sasd"));
            customButton.ButtonClick();

            customButton.SetCommand(
                new CommandReals.Plus(
                    new Receivers.MathReceiver(), 1, 2));
            customButton.ButtonClick();
        }
    }
}
