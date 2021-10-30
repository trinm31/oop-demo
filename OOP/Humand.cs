using System;

namespace OOP
{
    public class Humand
    {
        protected int a = 20;
        public void Walking()
        {
            Console.WriteLine("I am walking");
        }
        public virtual string Speak()
        {
            return "hello i am human";
        }
    }
}