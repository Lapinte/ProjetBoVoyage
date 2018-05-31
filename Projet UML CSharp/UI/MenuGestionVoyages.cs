using Projet_UML_CSharp.Affichage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class MenuGestionVoyages
    {
        public static void VoirGestionVoyage()
        {
            AfficherEnTete.MethodeAfficherEnTete("GESTION VOYAGE");

            Console.WriteLine("1. Liste des voyages");
            Console.WriteLine("2. Ajouter un voyage");
            Console.WriteLine("3. Liste des destinations");
            Console.WriteLine("4. Ajouter une destination");
            Console.WriteLine("R. Retour");
            Console.WriteLine();
            Console.Write("Votre choix: ");
        }
    }
}
