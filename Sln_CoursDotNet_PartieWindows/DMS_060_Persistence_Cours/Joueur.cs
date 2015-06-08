using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Cours
{
    public class Joueur
    {
        [XmlAttribute()]
        public string Nom { get; set; }
        [XmlAttribute()]
        public string Prenom { get; set; }
        [XmlAttribute()]
        public string Address { get; set; }
    }
}
