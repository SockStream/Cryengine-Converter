using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_Input_Unshared
    {
        [XmlAttribute("semantic")]
        // Commenting out default value as it won't write.
        //[System.ComponentModel.DefaultValueAttribute(Grendgine_Collada_Input_Semantic.NORMAL)]
        public Grendgine_Collada_Input_Semantic Semantic;

        [XmlAttribute("source")]
        public string source;

    }
}

