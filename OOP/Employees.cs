using System;

namespace OOP
{
    public abstract class Employees
    {
        public Employees()
        {
            
        }

        public void working()
        {
            Console.WriteLine("I'm working");
        }

        public abstract void job();
    }
}