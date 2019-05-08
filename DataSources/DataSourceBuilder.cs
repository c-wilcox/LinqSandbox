using System.Collections.Generic;



namespace DataSources
{
    public static class DataSourceBuilder
    {
        public static IEnumerable<TestDataItem> GetTestDataItems()
        {
            var items = new List<TestDataItem>();

            for (int i = 1; i < 2000; i++)
            {
                var item = new TestDataItem
                {
                    DataItemId = i
                };

                items.Add(item);
            }

            return items;
        }
    }

    public class TestDataItem
    {
        public int DataItemId { get; set; }
    }
}
