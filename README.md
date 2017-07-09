# IntroEventHandler
An event handler is a callback routine that operates asynchronously and handles inputs received into a program (events).


My EventArgs.cs file:

using System;

namespace IntroEventHandler
{
    class myEventArgs : EventArgs
    {
        public string Message { get; set; }
        public string Name { get; set; }

    }
}



CustomeClass.cs File:

using System;

namespace IntroEventHandler
{
    class CustomeClass
    {
        public event EventHandler OnComplete;

        public void DoSomeWork()
        {
            myEventArgs args = new myEventArgs();
            args.Message = "This is work done!";
            OnComplete(this, args);
        }
    }
}



Program.cs file:

using System;

namespace IntroEventHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomeClass aCustomeClass = new CustomeClass();
            aCustomeClass.OnComplete += new EventHandler(PrintMessage);
            aCustomeClass.DoSomeWork();
        }


        private static void PrintMessage(object sender, EventArgs e)

        {
            Console.WriteLine("Event fired!");
            Console.ReadKey();

        }
    }
}


