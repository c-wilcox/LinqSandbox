using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Xml.Linq;

namespace GeocachingGPXProcessor
{
    public static class GpxLoader
    {
        public static IEnumerable<XElement> LoadWaypoints(string fullPath)
        {
            XElement gpxRoot = XElement.Load(fullPath);

            IEnumerable<XElement> wayPoints = gpxRoot.Elements();

            return wayPoints;
        }
        
    }
}