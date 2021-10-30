using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        // //static fields
        // static int x = 10, y;
        //
        // // static contructor
        // static Program()
        // {
        //     y = 10;
        // }
        //
        // //static method
        // static void calcute()
        // {
        //     y = x * x;
        //     Console.WriteLine(y);
        // }
        
        static void Main(string[] args)
        {
            
            // ----------- Partial class -------------
            // People Tri = new People();
            // Tri.Method1();
            // Tri.Method2();
            
            // ----------- Static class -------------
            // Program.calcute();
            // var x = Program.x;
            // var y = Program.y;

            // ----------- Overloading -------------
            Caculator caculator = new Caculator();
            caculator.Add(1, 4);
            caculator.Add(1.2, 1.4);
            caculator.Add(1.2,3,7);
            
            // ----------- Overwritting -------------
            Student tri = new Student();
            Console.WriteLine(tri.Speak());
            tri.Walking();
            tri.Study();

            Humand phi = new Humand();
            Console.WriteLine(phi.Speak());
            
            
        }
    }
}