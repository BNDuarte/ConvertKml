using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "hotSpot", Namespace = "http://www.opengis.net/kml/2.2")]
    public class HotSpot
    {
        [XmlAttribute(AttributeName = "x")]
        public string X { get; set; }
        [XmlAttribute(AttributeName = "y")]
        public string Y { get; set; }
        [XmlAttribute(AttributeName = "xunits")]
        public string Xunits { get; set; }
        [XmlAttribute(AttributeName = "yunits")]
        public string Yunits { get; set; }
    }
}