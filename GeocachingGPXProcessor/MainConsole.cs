using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace GeocachingGPXProcessor
{
    class MainConsole
    {
        static void Main()
        {
            Console.WriteLine("Loading Document...");

            IEnumerable<XElement> waypoints = GpxLoader.LoadWaypoints(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\GeocachingGPXProcessor\GPX Files\Simplified My Hides.gpx");

            var csvList = new List<string>();

            foreach (XElement wpt in waypoints)
            {
                MyWaypointInfo wptInfo = CreateWaypointInfo(wpt);
                csvList.Add(wptInfo.ToCsvLine());

                Console.WriteLine($"{wptInfo.ToCsvLine()}");
            }

            WriteCsvListToFile(csvList);
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }


        private static void WriteCsvListToFile(List<string> csvList)
        {
            //todo
        }


        private static MyWaypointInfo CreateWaypointInfo(XElement wpt)
        {
            if (wpt == null)
            {
                throw new ArgumentNullException();
            }

            var info = new MyWaypointInfo
            {
                Name = wpt.Element("name")?.Value,
                Description = wpt.Element("desc")?.Value,
                HealthRating = DetermineHealthRating(wpt),
                Latitude = wpt.Attribute("lat")?.Value,
                Longitude = wpt.Attribute("lon")?.Value,
                Status = DetermineStatus(wpt)
            };

            return info;
        }


        private static string DetermineStatus(XElement wpt)
        {
            // todo
            return "available";
        }


        private static string DetermineHealthRating(XElement wpt)
        {
            //todo
            return "Good to Go!";
        }
    }


    public class MyWaypointInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Status { get; set; }
        public string HealthRating { get; set; }

        public string ToCsvLine()
        {
            return $"{Name},{Description},{Status},{HealthRating},{Latitude},{Longitude}";
        }

        public override string ToString()
        {
            //Todo: This should be different/better reading than ToCsvLine(); Make it so ....
            return ToCsvLine();
        }
    }
}
