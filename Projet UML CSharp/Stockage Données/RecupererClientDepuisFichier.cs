using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_UML_CSharp.Stockage_Données
{
    class RecupererClientDepuisFichier
    {
        public static List<Client> RecupererClient(string nomDeFichier)
        {
            var listeClient = new List<Client>();

            if (File.Exists(nomDeFichier))
            {
                var lignes = File.ReadAllLines(nomDeFichier);

                foreach (var ligne in lignes)
                {
                    string[] champs = ligne.Split(';');
                    var client = new Client
                    {
                        NuméroSéquentiel = int.Parse(champs[0]),
                        Civilité = champs[1],
                        Nom = champs[2],
                        Prénom = champs[3],
                        Adresse = champs[4],
                        NuméroTéléphone = champs[5],
                        Email = champs[6],
                    };

                    listeClient.Add(client);
                }
            }

            return listeClient;
        }

    }
}
