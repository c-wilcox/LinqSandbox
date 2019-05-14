using System;
using System.Collections.Generic;
using System.Linq;
using DataSources;


namespace MainConsole
{
    class Program
    {

        static void Main()
        {

            var loader = new JsonLoader();

            WriteTitle("Recruiters");
            IEnumerable<string> recruiters = loader.ReadRecruiterFile().Select(r => $"Co Short Name: {r.CompanyShortName}");

            foreach (string recruiter in recruiters)
                Console.WriteLine(recruiter);

            WriteBreak();


            WriteTitle("Agents");
            IEnumerable<string> agents = loader.ReadRecruiterAgentFile().Select(a => $"Co Short Name: {a.CompanyShortName}");

            foreach (string agent in agents)
                Console.WriteLine(agent);
            WriteBreak();


            WriteTitle("Recruiter Interactions");
            IEnumerable<string> recInteractions = loader.ReadRecruiterInteractionFile().Select(ra => $"Co Short Name: {ra.CompanyShortName}");

            foreach (string recInteraction in recInteractions)
                Console.WriteLine(recInteraction);

            WriteBreak();


            WriteTitle("Prospects");
            IEnumerable<string> prospects = loader.ReadProspectFile().Select(p => $"Co Short Name: {p.CompanyShortName}");

            foreach (string prospect in prospects)
                Console.WriteLine(prospect);

            WriteBreak();


            WriteTitle("ProspectInteractions");
            IEnumerable<string> prospectInteractions = loader.ReadProspectInteractionFile().Select(pi => $"Co Short Name: {pi.CompanyShortName}");

            foreach (string prospectInteraction in prospectInteractions)
                Console.WriteLine(prospectInteraction);

            WriteBreak();

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
