using System;

namespace OOP
{
    public class Student : Humand
    {
        private int age = 10;
        public void Study()
        {
            
            Console.WriteLine("I'm studying" + base.a);
        }
        public override string Speak()
        {
            return base.Speak() + " and now i am student";
        }
    }
}