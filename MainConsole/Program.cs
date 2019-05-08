using System;
using System.Collections.Generic;
using System.Linq;
using DataSources;

namespace MainConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEnumerable<TestDataItem> dataItems = DataSourceBuilder.GetTestDataItems();

            var query = dataItems.Where(i => i.DataItemId > 1900);

            foreach (var item in query)
            {
                Console.WriteLine(item.DataItemId);
            }

            Console.ReadLine();
        }
    }
}
