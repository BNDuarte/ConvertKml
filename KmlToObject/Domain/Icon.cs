using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Icon", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Icon
    {
        [XmlElement(ElementName = "href", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Href { get; set; }
    }
}