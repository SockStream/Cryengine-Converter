using System;
using System.Xml;
using System.Xml.Serialization;
namespace grendgine_collada
{

    [Serializable]
    [XmlType(AnonymousType = true)]
    public partial class Grendgine_Collada_SID_Bool
    {
        [XmlAttribute("sid")]
        public string sID;

        [XmlTextAttribute()]
        public bool Value;
    }
}

