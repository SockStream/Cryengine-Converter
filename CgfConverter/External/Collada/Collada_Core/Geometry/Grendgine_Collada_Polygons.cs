using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Polygons : Grendgine_Collada_Geometry_Common_Fields
    {

        [XmlElement(ElementName = "ph")]
        public Grendgine_Collada_Poly_PH[] PH;

    }
}

