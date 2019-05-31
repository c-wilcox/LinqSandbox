using System;


namespace MainConsole
{
    class MainConsole
    {

        static void Main()
        {

            WriteTitle("Recruiters");
            WriteTitle("Agents");
            WriteTitle("Recruiter Interactions");
            WriteTitle("Prospects");
            WriteTitle("ProspectInteractions");

            DoTheBigFinish();
        }

        private static void WriteTitle(string title)
        {
            Console.WriteLine($"{title}\r\n==============");
        }

        private static void WriteBreak()
        {
            Console.WriteLine("\r\n");
        }

        private static void DoTheBigFinish()
        {
            Console.WriteLine("\r\nHit enter to exit...");            
            Console.ReadLine();
        }
    }
}
