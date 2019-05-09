using System.Collections.Generic;



namespace DataSources
{
    public static class DataSourceBuilder
    {
        public static IEnumerable<JobProspect> GetTestDataItems()
        {
            var items = new List<JobProspect>();

            for (int i = 1; i < 2000; i++)
            {
                var item = new JobProspect
                {
                    ProspectId = i,
                    CompanyName = "Fred" + i,
                };
                
                items.Add(item);
            }

            return items;
        }
    }
}
