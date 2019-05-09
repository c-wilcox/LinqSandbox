using System;
using System.Collections.Generic;
using System.Linq;
using DataSources;


namespace LinqExercises
{
    public class Exercise1
    {
        public void Execute()
        {
            IEnumerable<TestDataItem> dataSource = DataSourceBuilder.GetTestDataItems();
            var query = from item in dataSource
                where item.DataItemId == 50
                orderby item.DataItemId descending
                select item;

            foreach (TestDataItem item in query)
            {
                Console.WriteLine($"{item.FirstName}");
            }
        }
    }
}