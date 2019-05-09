using System;
using LinqExercises;


namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DoTheBigStart();

            IDataSurfacer surfacer;
            
            switch (GetExerciseNumber())
            {
                case 1:
                    surfacer = new StraightList();
                    break;
                
                default:
                    Console.WriteLine("Go Pound!");
                    throw new Exception("Invalid Option!");
            }

            surfacer.SurfaceData();
            
            DoTheBigFinish();
        }

        
        private static int GetExerciseNumber()
        {
            int optionNumber = 0;

            while (optionNumber < 1 || optionNumber > 1)
            {
                //Get option from user
                optionNumber = 1;
            }
            
            return optionNumber;
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
