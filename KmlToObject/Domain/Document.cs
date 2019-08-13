using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KmlToObject.Domain
{
    [XmlRoot(ElementName = "Document", Namespace = "http://www.opengis.net/kml/2.2")]
    public class Document
    {
        [XmlElement(ElementName = "name", Namespace = "http://www.opengis.net/kml/2.2")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Style", Namespace = "http://www.opengis.net/kml/2.2")]
        public List<Style> Styles { get; set; }
        [XmlElement(ElementName = "StyleMap", Namespace = "http://www.opengis.net/kml/2.2")]
        public List<StyleMap> StylesMaps { get; set; }
        [XmlElement(ElementName = "Placemark", Namespace = "http://www.opengis.net/kml/2.2")]
        public List<Placemark> Placemarks { get; set; }

        public static implicit operator List<object>(Document v)
        {
            throw new NotImplementedException();
        }
    }
}