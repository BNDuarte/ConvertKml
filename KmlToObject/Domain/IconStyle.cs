using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "IconStyle", Namespace = "http://www.opengis.net/kml/2.2")]
    public class IconStyle
    {
        [XmlElement(ElementName = "scale", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Scale { get; set; }
        [XmlElement(ElementName = "Icon", Namespace = "http://www.opengis.net/kml/2.2")]
        public Icon Icon { get; set; }
        [XmlElement(ElementName = "hotSpot", Namespace = "http://www.opengis.net/kml/2.2")]
        public HotSpot HotSpot { get; set; }
        [XmlElement(ElementName = "color", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Color { get; set; }
    }
}