using System.Collections.Generic;


namespace DataSources
{
    public class JobProspect
    {
        public JobProspect()
        {
            Interviews = new List<InterviewInfo>();    
        }
        
        public int ProspectId { get; set; }
        public string CompanyName { get; set; }
        public string RecruiterName { get; set; }
        public string RecruiterOrgName { get; set; }
        public string InitiationDate { get; set; }
        public string ProspectTown { get; set; }
        public string ProspectPhone { get; set; }
        public string ProspectContactName { get; set; }
        public List<InterviewInfo> Interviews { get; set; }
        public int  PersonalImpression { get; set; }
        public int OverallImpression { get; set; }
        public string Notes { get; set; }
    }
}