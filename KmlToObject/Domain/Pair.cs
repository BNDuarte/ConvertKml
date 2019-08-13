using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Pair", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Pair
    {
        [XmlElement(ElementName = "key", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Key { get; set; }
        [XmlElement(ElementName = "styleUrl", Namespace = "http://www.opengis.net/kml/2.2")]
        public string StyleUrl { get; set; }
    }
}