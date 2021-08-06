using System;

namespace cs_solutions
{
    public class Program
    {
        //access modifiers are not allowed on static constructors solutions.trickystart.v1

        static Program()
        {
            Console.WriteLine("static!");
        }


        public Program()
        {
            Console.WriteLine("public!");
        }

        //ITS the GOD rule. THE HOLY START POINT.
        static void Main()
        {
            Console.WriteLine("main!");
        }
    }

}
