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
