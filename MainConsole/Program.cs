using System;
using System.Collections.Generic;
using DataSources;
using LinqExercises;


namespace MainConsole
{
    class Program
    {

        static void Main()
        {

            var loader = new JsonLoader();

            Console.WriteLine("Recruiters\r\n==============");
            List<Recruiter> recruiters = loader.ReadRecruiterFile();
            foreach (Recruiter recruiter in recruiters)
            {
                Console.WriteLine($"Co Short Name:{recruiter.CompanyShortName}");
            }
            Console.WriteLine("\r\n");

            Console.WriteLine("Agents\r\n==============");
            List<RecruiterAgent> recruiterAgents = loader.ReadRecruiterAgentFile();
            foreach (RecruiterAgent recruiterAgent in recruiterAgents)
            {
                Console.WriteLine($"Co Short Name:{recruiterAgent.CompanyShortName}");
            }
            Console.WriteLine("\r\n");


            Console.WriteLine("Recruiter Interactions\r\n==============");
            List<RecruiterInteraction> recruiterInteractions = loader.ReadRecruiterInteractionFile();
            foreach (RecruiterInteraction recruiterInteraction in recruiterInteractions)
            {
                Console.WriteLine($"Co Short Name:{recruiterInteraction.CompanyShortName}");
            }
            Console.WriteLine("\r\n");


            Console.WriteLine("Prospects\r\n==============");
            List<ProspectiveEmployer> prospectiveEmployers = loader.ReadProspectFile();
            foreach (ProspectiveEmployer prospectiveEmployer in prospectiveEmployers)
            {
                Console.WriteLine($"Co Short Name:{prospectiveEmployer.CompanyShortName}");
            }
            Console.WriteLine("\r\n");


            Console.WriteLine("ProspectInteractions\r\n==============");
            List<ProspectiveEmployerInteraction> prospectiveEmployerInteractions = loader.ReadProspectInteractionFile();
            foreach (ProspectiveEmployerInteraction prospectiveEmployerInteraction in prospectiveEmployerInteractions)
            {
                Console.WriteLine($"Co Short Name:{prospectiveEmployerInteraction.CompanyShortName}");
            }
            Console.WriteLine("\r\n");

            DoTheBigFinish();
        }

        private static void DoTheBigFinish()
        {
            Console.WriteLine("\r\nHit enter to exit...");            
            Console.ReadLine();
        }
    }
}
