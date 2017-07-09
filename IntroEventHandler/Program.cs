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
