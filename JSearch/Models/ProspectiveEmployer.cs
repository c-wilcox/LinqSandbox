using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class ProspectiveEmployer
    {
        public ProspectiveEmployer()
        {
            ProspectiveEmployerAgent = new HashSet<ProspectiveEmployerAgent>();
            ProspectiveEmployerInteraction = new HashSet<ProspectiveEmployerInteraction>();
        }

        public long PkProspectiveEmployer { get; set; }
        public long? FkRecruiterAgent { get; set; }

        public virtual RecruiterAgent FkRecruiterAgentNavigation { get; set; }
        public virtual ICollection<ProspectiveEmployerAgent> ProspectiveEmployerAgent { get; set; }
        public virtual ICollection<ProspectiveEmployerInteraction> ProspectiveEmployerInteraction { get; set; }
    }
}
