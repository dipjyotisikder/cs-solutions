using System;

namespace solutions.instantiation.v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start.. \n");

            var obj = new SomeFreakyClass(1);
            obj.DoIt();

            var obj2 = new SomeFreakyClass(2);
            obj2.DoIt();

            var obj3 = new SomeFreakyClass(3);
            obj3.DoIt();


            //RESULT1: Static constractor work only for first instantiation
            //RESULT2: Static constractor must be parameterless
        }

        public class SomeFreakyClass
        {

            //static SomeFreakyClass(string x) // You Cannot do this.
            static SomeFreakyClass()
            {
                Console.WriteLine("static constractor!");
            }

            public SomeFreakyClass(int val)
            {
                Console.WriteLine($"public constractor {val}!");
            }

            public void DoIt()
            {
                Console.WriteLine("DO point! \n");
            }
        }
    }
}
