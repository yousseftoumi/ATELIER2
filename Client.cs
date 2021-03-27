using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private List<Compte> comptes;

        public Client(string n,string p,string a )
        {
            nom = n;
            prenom = p;
            adresse = a;
            comptes = new List<Compte>();
        }
        public void afficher()
        {
            Console.WriteLine("\tNom : "+nom+ "\n\tPrenom : " + prenom+ "\n\tAdresse : " + adresse);
        }
    }
}
