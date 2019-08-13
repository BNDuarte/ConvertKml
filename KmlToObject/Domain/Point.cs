using System.Collections.Generic;
using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Point", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Point
    {
        [XmlElement(ElementName = "extrude", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Extrude { get; set; }
        [XmlElement(ElementName = "altitudeMode", Namespace = "http://www.google.com/kml/ext/2.2")]
        public List<string> AltitudeModeList { get; set; }
        [XmlElement(ElementName = "altitudeMode")]
        public string AltitudeMode { get; set; }
        [XmlElement(ElementName = "drawOrder", Namespace = "http://www.google.com/kml/ext/2.2")]
        public string DrawOrder { get; set; }
        [XmlElement(ElementName = "coordinates", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Coordinates { get; set; }
    }
}