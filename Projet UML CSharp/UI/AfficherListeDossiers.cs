using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class AfficherListeDossiers
    {
        public static void AfficherDossier(List<DossierVoyage> liste, bool afficherIndex)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Aucun dossier pour le moment");
                return;
            }
            var lignesBuilder = new StringBuilder();

            // Construction de la ligne d'en-tête
            if (afficherIndex)
            {
                lignesBuilder.AppendFormat("{0,-5} ", "NUM");
            }
            lignesBuilder.AppendFormat("{0,-15} {1,-15} {2,-25} {3,-25} {4,-15} {5,-10}", "NUM DOSSIER", "DESTINATION", "DATE DEBUT", "DATE FIN", "NB VOYAGEURS", "NUM CLIENT");
            lignesBuilder.AppendLine();

            for (int i = 0; i < liste.Count; i++)
            {
                var dossier = liste[i];

                if (afficherIndex)
                {
                    lignesBuilder.AppendFormat($"{i,-5} ");
                }
                lignesBuilder.Append($"{dossier.NuméroDossier,-15} {dossier.Destination,-15} {dossier.DateAller.ToShortDateString(),-25} {dossier.DateRetour.ToShortDateString(),-25} {dossier.NombreVoyageur,-15} {dossier.NuméroClient,-10}");
                lignesBuilder.AppendLine();
            }

            Console.Write(lignesBuilder.ToString());
        }
    }
}
