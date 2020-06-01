using MyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                Name = "Sophia",
                Gender = "Female"
            };

            p1.GoToSleep();
            p1.WakeUp();
            p1.Eat();
            p1.GoToWork();
            p1.SayHello();
            Console.ReadLine();

        }
    }

    public static class PersonExtension
    {
        public static void SayHello(this Person p1)
        {
            Console.WriteLine("{0} Says Hello", p1.Name);
        }
    }
}
