using KmlToObject.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace KmlToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Bruno\Downloads\KML\QUADRA J.kml";
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(path);

            Document document = new Document
            {
                Name = "Importação",
                Placemarks = DeserializarPlacemark(xmldoc),
                Styles = DeserializarStyle(xmldoc),
                StylesMaps = DeserializarStyleMap(xmldoc)
            };

            Console.ReadKey();
        }

        public static T ConvertNode<T>(XmlNode node) where T : class
        {
            MemoryStream stm = new MemoryStream();

            StreamWriter stw = new StreamWriter(stm);
            stw.Write(node.OuterXml);
            stw.Flush();

            stm.Position = 0;

            XmlSerializer ser = new XmlSerializer(typeof(T));
            T result = (ser.Deserialize(stm) as T);

            return result;
        }

        private static List<Placemark> DeserializarPlacemark(XmlDocument xmldoc)
        {
            XmlNodeList nodeList = xmldoc.GetElementsByTagName("Placemark");
            List<Placemark> placemarks = new List<Placemark>();
            foreach (XmlNode node in nodeList)
            {
                Placemark placemark = new Placemark();
                placemarks.Add(ConvertNode<Placemark>(node));
            }


            return placemarks;
        }

        private static List<Style> DeserializarStyle(XmlDocument xmldoc)
        {
            XmlNodeList nodeList = xmldoc.GetElementsByTagName("Style");
            List<Style> styles = new List<Style>();
            foreach (XmlNode node in nodeList)
            {
                styles.Add(ConvertNode<Style>(node));
            }
            return styles;
        }

        private static List<StyleMap> DeserializarStyleMap(XmlDocument xmldoc)
        {
            XmlNodeList nodeList = xmldoc.GetElementsByTagName("StyleMap");
            List<StyleMap> stylesMaps = new List<StyleMap>();
            foreach (XmlNode node in nodeList)
            {
                stylesMaps.Add(ConvertNode<StyleMap>(node));
            }
            return stylesMaps;
        }
    }
}
