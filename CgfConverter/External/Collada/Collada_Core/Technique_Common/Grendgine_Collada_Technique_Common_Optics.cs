using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Technique_Common_Optics : Grendgine_Collada_Technique_Common
    {

        [XmlElement(ElementName = "orthographic")]
        public Grendgine_Collada_Orthographic Orthographic;

        [XmlElement(ElementName = "perspective")]
        public Grendgine_Collada_Perspective Perspective;
    }
}

