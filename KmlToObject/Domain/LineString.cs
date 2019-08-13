using System.Collections.Generic;
using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "LineString", Namespace = "http://www.opengis.net/kml/2.2")]
    public class LineString
    {
        [XmlElement(ElementName = "extrude", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Extrude { get; set; }
        [XmlElement(ElementName = "tessellate", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Tessellate { get; set; }
        [XmlElement(ElementName = "altitudeMode", Namespace = "http://www.google.com/kml/ext/2.2")]
        public List<string> AltitudeModeList { get; set; }
        [XmlElement(ElementName = "altitudeMode")]
        public string AltitudeMode { get; set; }
        [XmlElement(ElementName = "coordinates", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Coordinates { get; set; }
    }
}