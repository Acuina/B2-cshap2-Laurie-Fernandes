using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Service
{
    class CommuneService
    {
        private List<Commune> Communes = new List<Commune>();
        private DemandeAutilisateur _demandeAutilisateur;
        private DepartementService _departementService;
        
        public CommuneService(DemandeAutilisateur demandeAutilisateur,DepartementService departementService)
        {
            this._demandeAutilisateur = demandeAutilisateur;
            this._departementService = departementService;
          
        }
        public Commune CreeCommune()
        {
            Commune result = new Commune();

            result.Nom = _demandeAutilisateur.saisieNom("Nom de la commune :");
            result.CodePost = _demandeAutilisateur.saisieEntier(" Code postal :");
            result.NbHab = _demandeAutilisateur.saisieEntier("nombre d'habitants :");
            Communes.Add(result);
            return result;
        }

        public void AfficheCommune()
        {
            
           foreach (Commune c in Communes)
        {
              Console.WriteLine("Nom commune");
              Console.WriteLine(c.Nom);
              Console.WriteLine("code postale");
              Console.WriteLine(c.CodePost);
              Console.WriteLine("nbr habitant");
              Console.WriteLine(c.NbHab);
              Console.WriteLine("**************");
            }

        }
    }
}
