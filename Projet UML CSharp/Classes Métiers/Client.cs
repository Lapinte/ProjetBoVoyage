using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp
{
    public class Client : Participant
    {
        public string NuméroCarteBleue { get; set; }
        public DossierVoyage DossierVoyage { get; set; }
    }
}
