using ConsoleApp4.Model;
using ConsoleApp4.Service;
using System.Collections.Generic;
using System;

namespace ConsoleApp4
{
    class Program
    {
        private static DemandeAutilisateur _demandeAutilisateur = new DemandeAutilisateur();
        static void Main(string[] args)
        {
            DemandeAutilisateur _demandeAutilisateur = new DemandeAutilisateur();
            DepartementService _departementService = new DepartementService(_demandeAutilisateur);

            CommuneService _communeService = new CommuneService(_demandeAutilisateur, _departementService);
            HabitantService _habitantService = new HabitantService(_demandeAutilisateur,_communeService);
            List<Commune> communes = new List<Commune>();
         

            while (true)
            {
                int choix = MenuUtilisateur();
               
                if (choix == 1)
                {
                    _habitantService.CreatHabitants();
                }
                else if (choix == 2)
                {
                    _habitantService.AfficheHabitans() ;
                }
                else if(choix == 3)
                {
                    _communeService.CreeCommune();
                }
                else if (choix == 4)
                {
                    _communeService.AfficheCommune();
                }
                else if (choix == 5)
                {
                    _departementService.CreeDepartement();
                }
                else if (choix == 6)
                {
                    _departementService.DemandeDepartement();
                    
                }
                

            }
        }
        private static int MenuUtilisateur()
        {
            Console.WriteLine("Que voulez-vous faire ?");
            Console.WriteLine("1. Créer un Habitant");
            Console.WriteLine("2. Afficher la liste des habitants");
            Console.WriteLine("3. Créer une commune");
            Console.WriteLine("4. Afficher les communes");
            Console.WriteLine("5. Créer un departement");
            Console.WriteLine("6. Afficher un departement");
            Console.WriteLine("Q. Quitter");
            int choixUtilisateur = _demandeAutilisateur.saisieEntier("");
            return choixUtilisateur;
        }
    }
}
