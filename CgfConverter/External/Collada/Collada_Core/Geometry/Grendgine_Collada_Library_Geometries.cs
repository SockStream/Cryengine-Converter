using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Library_Geometries
    {
        [XmlAttribute("id")]
        public string ID;

        [XmlAttribute("name")]
        public string Name;


        [XmlElement(ElementName = "geometry")]
        public Grendgine_Collada_Geometry[] Geometry;

        [XmlElement(ElementName = "asset")]
        public Grendgine_Collada_Asset Asset;

        [XmlElement(ElementName = "extra")]
        public Grendgine_Collada_Extra[] Extra;
    }
}

