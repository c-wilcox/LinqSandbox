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

            IEnumerable<XElement> gpxDoc = GpxLoader.LoadWaypoints(@"C:\Users\serverside6\Documents\My Source Code\LinqSandbox\GeocachingGPXProcessor\GPX Files\List of My HIdes.gpx");

            foreach (XElement n in gpxDoc)
            {
                Console.WriteLine($"{n}\r\n=================================");
            }

            Console.WriteLine("Document Loaded!");
            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
