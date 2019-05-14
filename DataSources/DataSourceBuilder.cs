using System.Collections.Generic;



namespace DataSources
{
    public static class DataSourceBuilder
    {
        public static IEnumerable<JobProspect> GetProspectDataGetTestDataItems()
        {
            int prospectId = 1;
            var items = new List<JobProspect>();

            var item = new JobProspect
            {
                ProspectId = prospectId++,
                CompanyName = "SofterWare",
                ProspectTown = "Fort Washington",
                ProspectPhone = "267-913-5208",
                Notes = "Phone screen went well. F2F sucked; put me in front of laptop while 5 dudes watched me try to code on a laptop keyboard. Ugh!",
                ProspectWebSite = "www.softerware.com",
                
            };
            items.Add(item);

            item = new JobProspect()
            {
                ProspectId = prospectId++,
                CompanyName = "Bank Mobile",
                RecruiterName = "Christian Bet",
                RecruiterEmail = "cbet@missionstaff.com",
                RecruiterOrgName = "Mission Staffing",
                RecruiterPhone = "215-383-2575",
                ProspectTown = "Radnor",
                RecruiterWebSite = "missionstaff.com",
                ProspectWebSite = "https://www.bankmobile.com/",
                InitiationDate = "5-3-2019",
                ProspectContactNames = "Niko, Cassie",
                
            };
            items.Add(item);
   
            item = new JobProspect()
            {
                ProspectId = prospectId++,
                CompanyName = "",
                RecruiterName = "",
                RecruiterEmail = "",
                RecruiterOrgName = "",
                RecruiterPhone = "",
                ProspectTown = "",
                RecruiterWebSite = "",
                ProspectWebSite = "",
                InitiationDate = "",
                ProspectContactNames = "",
                
            };
            items.Add(item);
   
            return items;
        }
    }
}
