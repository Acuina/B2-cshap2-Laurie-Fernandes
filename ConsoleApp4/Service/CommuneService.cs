using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

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
            result.NbHab = _demandeAutilisateur.saisieEntier("Combien y a-t-il d'habitants :");
            Communes.Add(result);
            return result;
        }
       /* public void calculNbtotalHabs(List<Commune> Communes)
        {
            int Nbtot = 0;
            foreach (Commune c in Communes)
            {
                Nbtot = Nbtot + c.NbHab;
            }
            var culture = CultureInfo.GetCultureInfo("en-GB");
            string nb = string.Format(culture, "{0:n0}", Nbtot);
            nb = nb.Replace(",", ".");
            string message = "Nombre total d'habitants: " + nb;
            Console.WriteLine(message);
        }

        internal void AfficheCommune()
        {
            throw new NotImplementedException();
        }

        public void affiche(List<Commune> Communes)
        {
            Console.WriteLine("Liste des communes créées:");
            foreach (Commune c in Communes)
            {
                var culture = CultureInfo.GetCultureInfo("en-GB");
                string nb = string.Format(culture, "{0:n0}", c.NbHab);
                nb = nb.Replace(",", ".");
                string message_p1 = "Nom: " + c.Nom + " Code Postal: " + c.CodePost;
                string message_p2 = "Nombre d'habitants: " + nb;
                Console.WriteLine(message_p1);
                Console.WriteLine(message_p2);
            }
        }

        internal void calculNbtotalHabs(object communes)
        {
            throw new NotImplementedException();
        } */
    }
}

