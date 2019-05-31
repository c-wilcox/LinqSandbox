namespace DataSources
{
    public class RecruiterAgent
    {
        public int RecruiterAgentId { get; set; }
        public Recruiter RecruitmentFirm { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string DirectPhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
    }
}