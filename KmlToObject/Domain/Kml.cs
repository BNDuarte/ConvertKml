using System.Collections.Generic;
using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "kml", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Kml
    {
        [XmlElement(ElementName = "Document", Namespace = "http://www.opengis.net/kml/2.2")]
        public List<Document> Document { get; set; }

        public Kml()
        {
            Document = new List<Document>();
        }
    }
}