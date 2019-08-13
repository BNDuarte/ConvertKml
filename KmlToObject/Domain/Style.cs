using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Style", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Style
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlElement(ElementName = "IconStyle", Namespace = "http://www.opengis.net/kml/2.2")]
        public IconStyle IconStyle { get; set; }
        [XmlElement(ElementName = "PolyStyle", Namespace = "http://www.opengis.net/kml/2.2")]
        public PolyStyle PolyStyle { get; set; }
        [XmlElement(ElementName = "LineStyle", Namespace = "http://www.opengis.net/kml/2.2")]
        public LineStyle LineStyle { get; set; }
        [XmlElement(ElementName = "LabelStyle", Namespace = "http://www.opengis.net/kml/2.2")]
        public LabelStyle LabelStyle { get; set; }
    }
}