using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp
{
    public class DossierVoyage
    {
        public string Statut { get; set; }
        public int NuméroDossier { get; set; }
        public string Destination { get; set; }
        public DateTime DateAller { get; set; }
        public DateTime DateRetour { get; set; }
        public int NombreVoyageur { get; set; }
        public int NuméroClient { get; set; }
        public Client Client { get; set; }
    }
}
