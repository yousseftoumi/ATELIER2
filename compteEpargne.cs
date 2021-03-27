using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class CompteEpargne : Compte
    {
        private double TauxInteret;

        public CompteEpargne(Client C, MAD solde, double taux):base(C,solde)
        {
            while (taux < 0 || taux > 100)
            {
                Console.WriteLine("Erreur: Taux Interet invalide ! Veuillez entrez un nombre entre 0 et 100");
                taux = Convert.ToDouble(Console.ReadLine());
            }                
            TauxInteret = taux;
        }
        
        public void calculInteret()
        {
            base.Crediter(this.solde * TauxInteret / 100);
            //this.solde += (this.solde * TauxInteret) / 100;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Taux d'interet : " + TauxInteret);
        }
    }
}
