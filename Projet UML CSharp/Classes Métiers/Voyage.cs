using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Classes_Métiers
{
    public class Voyage
    {
        public Destination Destination { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int NombreVoyageurMax { get; set; }
    }
}
