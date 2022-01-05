using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //While
        private void whileLoop()
        {
            while (true)
            {

            }
        }
        // Do While
        private void DoWhile()
        {
            do
            {
                Console.Write("Hei");
            } while (true);
        }


        //Foreach
        private void ForEach()
        {
            int[] numberArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach(var number in numberArray)
            {
                Console.WriteLine(number);
            }
        }

        //For-loop
        private void ForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("i er: " + i);
            }
        }
             
    }
}
