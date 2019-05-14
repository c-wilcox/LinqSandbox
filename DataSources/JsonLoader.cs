using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;



namespace DataSources
{
    public class JsonLoader
    {

        public List<Recruiter> ReadRecruiterFile()
        {
            string jsonText = File.ReadAllText(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\DataSources\Json Data\RecruiterData.json");

            var recruiters = JsonConvert.DeserializeObject<List<Recruiter>>(jsonText);

            return recruiters;
        }


        public List<RecruiterAgent> ReadRecruiterAgentFile()
        {
            string jsonText = File.ReadAllText(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\DataSources\Json Data\RecruiterAgentData.json");

            var recruiterAgents = JsonConvert.DeserializeObject<List<RecruiterAgent>>(jsonText);

            return recruiterAgents;
        }


        public List<RecruiterInteraction> ReadRecruiterInteractionFile()
        {
            string jsonText = File.ReadAllText(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\DataSources\Json Data\RecruiterInteractionData.json");

            var recruiterInteraction = JsonConvert.DeserializeObject<List<RecruiterInteraction>>(jsonText);

            return recruiterInteraction;
        }


        public List<ProspectiveEmployer> ReadProspectFile()
        {
            string jsonText = File.ReadAllText(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\DataSources\Json Data\ProspectData.json");

            var prospectiveEmployers = JsonConvert.DeserializeObject<List<ProspectiveEmployer>>(jsonText);

            return prospectiveEmployers;
        }



        public List<ProspectiveEmployerInteraction> ReadProspectInteractionFile()
        {
            string jsonText = File.ReadAllText(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\DataSources\Json Data\ProspectInteractionData.json");

            var prospectiveEmployerInteractions = JsonConvert.DeserializeObject<List<ProspectiveEmployerInteraction>>(jsonText);

            return prospectiveEmployerInteractions;
        }
    }


    public class Recruiter
    {
        public string CompanyShortName { get; set; }
    }


    public class RecruiterAgent
    {
        public string CompanyShortName { get; set; }
    }


    public class RecruiterInteraction
    {
        public string CompanyShortName { get; set; }
    }


    public class ProspectiveEmployer
    {
        public string CompanyShortName { get; set; }
    }


    public class ProspectiveEmployerInteraction
    {
        public string CompanyShortName { get; set; }
    }
}