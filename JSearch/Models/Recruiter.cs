using System;
using System.Collections.Generic;

namespace JSearch.Models
{
    public partial class Recruiter
    {
        public Recruiter()
        {
            RecruiterAgent = new HashSet<RecruiterAgent>();
        }

        public long PkRecruiter { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<RecruiterAgent> RecruiterAgent { get; set; }
    }
}
