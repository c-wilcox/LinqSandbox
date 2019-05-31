using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class ProspectiveEmployerInteraction
    {
        public long PkProspectiveEmployerInteraction { get; set; }
        public long FkProspectiveEmployer { get; set; }

        public virtual ProspectiveEmployer FkProspectiveEmployerNavigation { get; set; }
    }
}
