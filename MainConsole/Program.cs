using System;
using LinqExercises;


namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheBigStart();

            switch (GetExerciseNumber())
            {
                case 1:
                    var ex1 = new Exercise1();
                    ex1.Execute();
                    break;
                
                default:
                    Console.WriteLine("Go Pound!");
                    break;
            }

            DoTheBigFinish();
        }

        private static int GetExerciseNumber()
        {
            return 1;
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
