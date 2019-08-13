using System.Collections.Generic;
using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "StyleMap", Namespace = "http://www.opengis.net/kml/2.2")]
    public class StyleMap
    {
        [XmlElement(ElementName = "Pair", Namespace = "http://www.opengis.net/kml/2.2")]
        public List<Pair> Pair { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }
}