using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "LabelStyle", Namespace = "http://www.opengis.net/kml/2.2")]
    public class LabelStyle
    {
        [XmlElement(ElementName = "color", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Color { get; set; }
    }
}