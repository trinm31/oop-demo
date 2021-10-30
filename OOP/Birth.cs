using System;

namespace OOP
{
    public class Birth: IAnimal
    {
        public int numberOfLeg { get; set; }
        public void speak()
        {
            Console.WriteLine("Liu lo");
        }

        public void fly()
        {
            
        }
    }
}