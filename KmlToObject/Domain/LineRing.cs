using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "LinearRing", Namespace = "http://www.opengis.net/kml/2.2")]
    public class LinearRing
    {
        [XmlElement(ElementName = "coordinates", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Coordinates { get; set; }
    }
}