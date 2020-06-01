using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }

        public void Eat()
        {
            Console.WriteLine("{0} is Eating", Name);
        }
        public void GoToSleep()
        {
            Console.WriteLine("{0} is sleeping", Name);
        }
        public void WakeUp()
        {
            Console.WriteLine("{0} just waked up", Name);
        }

        public void GoToWork()
        {
            Console.WriteLine("{0} is at work", Name);
        }
        

    }
}
