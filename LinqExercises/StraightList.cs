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
            IEnumerable<JobProspect> dataSource = DataSourceBuilder.GetTestDataItems();
            var query = from item in dataSource
                where item.ProspectId == 50
                orderby item.ProspectId descending
                select item;

            foreach (JobProspect item in query)
            {
                Console.WriteLine($"{item.CompanyName}");
            }
        }
    }
}