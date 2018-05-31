using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Stockage_Données
{
    class RecupererDossierDepuisFichier
    {
        public static List<DossierVoyage> RecupererDossiers(string nomDeFichier)
        {
            var listeDossier = new List<DossierVoyage>();

            if (File.Exists(nomDeFichier))
            {
                var lignes = File.ReadAllLines(nomDeFichier);

                foreach (var ligne in lignes)
                {
                    string[] champs = ligne.Split(';');
                    var dossier = new DossierVoyage
                    {
                        NuméroDossier = int.Parse(champs[0]),
                        Destination = champs[1],
                        DateAller = DateTime.Parse(champs[2]),
                        DateRetour = DateTime.Parse(champs[3]),
                        NombreVoyageur = int.Parse(champs[4]),
                        NuméroClient = int.Parse(champs[5]),
                    };

                    listeDossier.Add(dossier);
                }
            }

            return listeDossier;
        }
    }
}
