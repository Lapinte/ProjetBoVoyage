using Projet_UML_CSharp.Affichage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class MenuGestionDossiers
    {
        public static void VoirGestionDossier()
        {
            AfficherEnTete.MethodeAfficherEnTete("GESTION DES DOSSIERS");

            Console.WriteLine("1. Dossiers En Attente");
            Console.WriteLine("2. Dossiers En Cours");
            Console.WriteLine("3. Dossiers Acceptés");
            Console.WriteLine("4. Dossiers Refusés");
            Console.WriteLine("R. Retour");
            Console.WriteLine();
            Console.Write("Votre choix: ");
        }
    }
}
