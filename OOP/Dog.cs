using System;

namespace OOP
{
    public class Dog :IAnimal
    {
        public int numberOfLeg { get; set; }
        public void speak()
        {
            Console.WriteLine("Go Go Go");
        }
    }
}