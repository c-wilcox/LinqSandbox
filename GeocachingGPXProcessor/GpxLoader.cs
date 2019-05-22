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
            XDocument doc = XDocument.Load(fullPath);

            var mainNode = (XElement)doc.FirstNode;
            IEnumerable<XElement> wayPoints = from node in mainNode.Nodes()
                where ((XElement) node).Name.LocalName.Equals("wpt")
                select (XElement)node;

            return wayPoints;
        }
        
    }
}