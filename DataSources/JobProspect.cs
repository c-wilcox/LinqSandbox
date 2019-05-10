using System;
using System.Collections.Generic;
using System.Reflection;


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
        public string ProspectContactNames { get; set; }
        public List<InterviewInfo> Interviews { get; set; }
        public int PersonalImpression { get; set; }
        public int OverallImpression { get; set; }
        public string Notes { get; set; }
        public string ProspectWebSite { get; set; }
        public string RecruiterPhone { get; set; }
        public string RecruiterWebSite { get; set; }
        public string RecruiterEmail { get; set; }

        public override string ToString()
        {
            Dictionary<string, object> props = DictionaryFromType(this);
            string toString = "";

            foreach (string propName in props.Keys)
            {
                toString += $"{propName}: {props[propName]}\r\n";
            }

            toString += "\r\n\r\n";
            return toString;
        }


        public static Dictionary<string, object> DictionaryFromType(object propObject)
        {
            if (propObject == null) return new Dictionary<string, object>();

            PropertyInfo[] props = propObject.GetType().GetProperties();
            Dictionary<string, object> dict = new Dictionary<string, object>();
            foreach (PropertyInfo prp in props)
            {
                object value = propObject.GetType().GetProperty(prp.Name).GetValue(propObject);
                dict.Add(prp.Name, value);
            }

            return dict;
        }
    }
}