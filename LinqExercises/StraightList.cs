using System;
using System.Collections.Generic;
using System.Linq;
using DataSources;


namespace LinqExercises
{
    public class StraightList : IDataSurfacer
    {
        public void SurfaceData()
        {
            IEnumerable<JobProspect> prospects = DataSourceBuilder.GetProspectDataGetTestDataItems();
            var query = from prospect in prospects
                select prospect;

            foreach (JobProspect item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}