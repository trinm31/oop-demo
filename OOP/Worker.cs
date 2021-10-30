using System;

namespace OOP
{
    public class Worker: Employees
    {
        public override void job()
        {
            Console.WriteLine("I am a plumber");
        }

        public void test()
        {
            base.working();
        }
    }
}