using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Placemark", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Placemark
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Name { get; set; }
        [XmlElement(ElementName = "styleUrl", Namespace = "http://www.opengis.net/kml/2.2")]
        public string StyleUrl { get; set; }
        [XmlElement(ElementName = "Polygon", Namespace = "http://www.opengis.net/kml/2.2")]
        public Polygon Polygon { get; set; }
        [XmlElement(ElementName = "LineString", Namespace = "http://www.opengis.net/kml/2.2")]
        public LineString LineString { get; set; }
        [XmlElement(ElementName = "Point", Namespace = "http://www.opengis.net/kml/2.2")]
        public Point Point { get; set; }
    }
}