using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class ProspectiveEmployerAgent
    {
        public long PkProspectiveEmployerAgent { get; set; }
        public long FkProspectiveEmployer { get; set; }

        public virtual ProspectiveEmployer FkProspectiveEmployerNavigation { get; set; }
    }
}
