using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.UI
{
    class AfficherListeClients
    {
        public static void VoirListeClient(List<Client> liste, bool afficherIndex)
        {
            if (liste.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Aucun client pour le moment");
                return;
            }
            var lignesBuilder = new StringBuilder();

            // Construction de la ligne d'en-tête
            if (afficherIndex)
            {
                lignesBuilder.AppendFormat("{0,-5} ", "NUM");
            }
            lignesBuilder.AppendFormat("{0,-10} {1,-10} {2,-15} {3,-15} {4,-50} {5,-18} {6,-40}", "NUM SEQ", "CIVILITE", "NOM", "PRENOM", "ADRESSE", "TEL", "EMAIL");
            lignesBuilder.AppendLine();

            for (int i = 0; i < liste.Count; i++)
            {
                var client = liste[i];

                if (afficherIndex)
                {
                    lignesBuilder.AppendFormat($"{i,-5} ");
                }
                lignesBuilder.Append($"{client.NuméroSéquentiel,-10} {client.Civilité,-10} {client.Nom,-15} {client.Prénom,-15} {client.Adresse,-50} {client.NuméroTéléphone,-18} {client.Email,-40}");
                lignesBuilder.AppendLine();
            }

            Console.Write(lignesBuilder.ToString());
        }
    }
}
