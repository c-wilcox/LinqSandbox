using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class RecruiterAgentInteraction
    {
        public long PkRecruiterAgentInteraction { get; set; }
        public long FkRecruiterAgent { get; set; }

        public virtual RecruiterAgent FkRecruiterAgentNavigation { get; set; }
    }
}
