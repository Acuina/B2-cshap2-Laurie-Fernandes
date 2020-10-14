using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Service
{
    class DepartementService
    {
        public DemandeAutilisateur _demandeAutilisateur;
        List<Departement> departement = new List<Departement>();
        public DepartementService (DemandeAutilisateur demandeAutilisateur)
        {
            this._demandeAutilisateur = demandeAutilisateur;
        }
        public Departement CreeDepartement()
        {
            Departement d = new Departement();
            d.nom = _demandeAutilisateur.saisieNom("Nom de departement");
            d.numD = _demandeAutilisateur.saisieEntier("Numero du departement");
            departement.Add(d);
            return d;
        }
        public Departement DemandeDepartement()
        {

            Departement result = null;
            while (result == null)
            {
                string saisieUtilisateur = _demandeAutilisateur.saisieNom("Nom de  departement ?");
                foreach (Departement d in this.departement)
                {

                    {
                        {
                            Console.WriteLine("Nom du département");
                            Console.WriteLine(d.nom);
                            Console.WriteLine("Numero du département");
                            Console.WriteLine(d.numero);
                            Console.WriteLine("**************");

                        }
                    }
                }
            }
            return result;
        }
    }
}
