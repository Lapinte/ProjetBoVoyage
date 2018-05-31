using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Affichage
{
    public static class AfficherEnTete
    {
        public static void MethodeAfficherEnTete(string libelle)
        {
            Console.Clear();

            // Comme j'utilise "| " et " |", la ligne doit avoir 4 caractères en plus
            var ligneTraits = new string('*', libelle.Length + 4);
            CentrerLeTexte.Centrer(ligneTraits);
            CentrerLeTexte.Centrer($"| { libelle } |");
            CentrerLeTexte.Centrer(ligneTraits);
        }
    }
}
