using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using Projet_UML_CSharp.Affichage;
using Projet_UML_CSharp.UI;
using Projet_UML_CSharp.Stockage_Données;
using Projet_UML_CSharp.Classes_Métiers;

namespace Projet_UML_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Intranet();
        }

        public static void Intranet()
        {
            while (true)
            {
                MenuIntranet.VoirIntranet();

                string saisie = Console.ReadLine();
                switch (saisie.ToUpper())
                {
                    case "1":
                        GestionVoyage();
                        break;
                    case "2":
                        GestionClient();
                        break;

                    case "Q":
                        return;
                }
            }
        }

        public static void GestionClient()
        {
            while (true)
            {
                MenuGestionClients.VoirGestionClient();

                string saisie = Console.ReadLine();
                switch (saisie.ToUpper())
                {
                    case "1":
                        BaseDeDonnéeClient();
                        break;
                    case "2":
                        GestionDossier();
                        break;

                    case "R":
                        return;
                }
            }
        }

        public static void GestionVoyage()
        {
            while(true)
            {
                MenuGestionVoyages.VoirGestionVoyage();

                string saisie = Console.ReadLine();
                switch (saisie.ToUpper())
                {
                    case "1":
                        List<Voyage> listeVoyage = RecupererVoyageDepuisFichier.RecupererVoyage("Voyages.txt");
                        ListerVoyage(listeVoyage, "LISTE DES VOYAGES DISPONIBLES", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();

                        break;
                    case "2":
                        //AjouterVoyage();
                        break;
                    case "3":
                        List<Destination> listeDestination = RecupererDestinationDepuisFichier.RecupererDestination("Destination.txt");
                        ListerDestination(listeDestination, "LISTE DES DESTINATION", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;
                    case "4":
                        //AjouterDestination();
                        break;

                    case "R":
                        return;
                }
            }
        }

        public static void BaseDeDonnéeClient()
        {
            while(true)
            {
                MenuBaseDeDonnéeClient.VoirBaseDeDonnéeClient();

                string saisie = Console.ReadLine();
                switch (saisie.ToUpper())
                {
                    case "1":
                        List<Client> listeClients = RecupererClientDepuisFichier.RecupererClient("ListeClients.txt");
                        ListerClients(listeClients, "LISTE DES CLIENTS", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "R":
                        return;

                }
            }
        }

        public static void GestionDossier()
        {
            while (true)
            {
                MenuGestionDossiers.VoirGestionDossier();

                string saisie = Console.ReadLine();
                switch (saisie.ToUpper())
                {
                    case "1":
                        List<DossierVoyage> listeDossierEnAttente = RecupererDossierDepuisFichier.RecupererDossiers("DossierEnAttente.txt");
                        ListerDossiers(listeDossierEnAttente, "DOSSIERS EN ATTENTE", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;

                    case "2":
                        List<DossierVoyage> listeDossierEnCours = RecupererDossierDepuisFichier.RecupererDossiers("DossierEnCours.txt");
                        ListerDossiers(listeDossierEnCours, "DOSSIERS EN COURS", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;

                    case "3":
                        List<DossierVoyage> listeDossierAccepté = RecupererDossierDepuisFichier.RecupererDossiers("DossierAccepté.txt");
                        ListerDossiers(listeDossierAccepté, "DOSSIERS ACCEPTES", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;
                    case "4":
                        List<DossierVoyage> listeDossierRefusé = RecupererDossierDepuisFichier.RecupererDossiers("DossierRefusé.txt");
                        ListerDossiers(listeDossierRefusé, "DOSSIERS REFUSES", false);
                        AfficherLignePourRetournerAuMenu.LignePourRetournerAuMenu();
                        break;

                    case "R":
                        return;

                    default:
                        Console.WriteLine("Choix non valide, Rééssayez");
                        break;
                }
            }
        }

        public static void ListerDossiers(List<DossierVoyage> listeDossier, string nomRépertoire, bool index)
        {
            AfficherEnTete.MethodeAfficherEnTete(nomRépertoire);
            AfficherListeDossiers.AfficherDossier(listeDossier, index);
        }

        public static void ListerDestination(List<Destination> listeDestination, string nomRépertoire, bool index)
        {
            AfficherEnTete.MethodeAfficherEnTete(nomRépertoire);
            AfficherListeDestinations.AfficherDestination(listeDestination, index);
        }

        public static void ListerVoyage(List<Voyage> listeVoyage, string nomRépertoire, bool index)
        {
            AfficherEnTete.MethodeAfficherEnTete(nomRépertoire);
            AfficherListeVoyages.AfficherVoyage(listeVoyage, index);
        }

        public static void ListerClients(List<Client> listeClients, string nomRépertoire, bool index)
        {
            AfficherEnTete.MethodeAfficherEnTete(nomRépertoire);
            AfficherListeClients.VoirListeClient(listeClients, index);
        }
    }
}
