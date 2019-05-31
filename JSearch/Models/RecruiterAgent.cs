using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class RecruiterAgent
    {
        public RecruiterAgent()
        {
            ProspectiveEmployer = new HashSet<ProspectiveEmployer>();
            RecruiterAgentInteraction = new HashSet<RecruiterAgentInteraction>();
        }

        public long PkRecruiterAgent { get; set; }
        public long FkRecruiter { get; set; }

        public virtual Recruiter FkRecruiterNavigation { get; set; }
        public virtual ICollection<ProspectiveEmployer> ProspectiveEmployer { get; set; }
        public virtual ICollection<RecruiterAgentInteraction> RecruiterAgentInteraction { get; set; }
    }
}
