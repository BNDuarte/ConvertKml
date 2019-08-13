using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "outerBoundaryIs", Namespace = "http://www.opengis.net/kml/2.2")]
    public class OuterBoundaryIs
    {
        [XmlElement(ElementName = "LinearRing", Namespace = "http://www.opengis.net/kml/2.2")]
        public LinearRing LinearRing { get; set; }
    }
}