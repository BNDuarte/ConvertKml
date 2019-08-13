using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "PolyStyle", Namespace = "http://www.opengis.net/kml/2.2")]
    public class PolyStyle
    {
        [XmlElement(ElementName = "color", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Color { get; set; }
        [XmlElement(ElementName = "outline", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Outline { get; set; }
    }
}