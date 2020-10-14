using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ConsoleApp4.Service
{
    class HabitantService
    {
        private DemandeAutilisateur _demandeAutilisateur;
        private CommuneService _communeService;
        private HabitantService _habitantService;
        private List<Habitant> ListeHabitants = new List<Habitant>();
        public HabitantService(DemandeAutilisateur demandeAutilisateur,CommuneService communeService)
        {
            this._demandeAutilisateur = demandeAutilisateur;
            this._communeService = communeService;
        }

    

        public void AfficheHabitans()
        {
            foreach (Habitant h in ListeHabitants)
            {
                Console.WriteLine(h.nom);
                Console.WriteLine("Les communes: ");

                if (h.Communes != null)
                {
                    foreach (Commune c in h.Communes)
                    {
                        Console.WriteLine(c.Nom);
                    }
                }
            }
           
        }
        public Habitant CreatHabitants()
        {
            Habitant h = new Habitant();
            h.nom = _demandeAutilisateur.saisieNom("Nom de l'habitant :");
            h.age = _demandeAutilisateur.saisieEntier("Quel age as tu :");
            ListeHabitants.Add(h);
            return h;
        }
    }
}
