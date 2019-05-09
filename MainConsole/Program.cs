using System;
using LinqExercises;


namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheBigStart();
            
            var ex1 = new Exercise1();
            ex1.Execute();
            
            DoTheBigFinish();
        }

        private static void DoTheBigStart() 
        {
            Console.WriteLine("Program Started...\r\n");
        }

        private static void DoTheBigFinish()
        {
            Console.WriteLine("\r\nHit enter to exit...");            
            Console.ReadLine();
        }
    }
}
