using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "LineStyle", Namespace = "http://www.opengis.net/kml/2.2")]
    public class LineStyle
    {
        [XmlElement(ElementName = "color", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Color { get; set; }
        [XmlElement(ElementName = "width", Namespace = "http://www.opengis.net/kml/2.2")]
        public int Width { get; set; }
    }
}