using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Service
{
    class DepartementService
    {
        public DemandeAutilisateur _demandeAutilisateur;
        List<Departement> departements = new List<Departement>();
        public DepartementService (DemandeAutilisateur demandeAutilisateur)
        {
            this._demandeAutilisateur = demandeAutilisateur;
        }
        public Departement CreeDepartement()
        {
            Departement d = new Departement();
            d.nom = _demandeAutilisateur.saisieNom("Nom de departement");
            d.numD = _demandeAutilisateur.saisieEntier("Numero du departement");
            d.nbreH = _demandeAutilisateur.saisieEntier("Nombre d'habitants");
            departements.Add(d);
            return d;
        }
        public Departement DemandeDepartements()

        {

            Departement result = null;
            while (result == null)
            {
                string saisieUtilisateur = _demandeAutilisateur.saisieNom("Nom du departement ?");
                foreach (Departement d in departements)
                {

                    {
                        {
                            Console.WriteLine("**************");
                            Console.WriteLine("Nom du département : ");
                            Console.WriteLine(d.nom);
                            Console.WriteLine("Numero du département : ");
                            Console.WriteLine(d.numD);
                            Console.WriteLine("Nombre d'habitants : ");
                            Console.WriteLine(d.nbreH);
                            Console.WriteLine("**************");

                        }
                    }
                }
            }
            return result;
        }
    }
}
