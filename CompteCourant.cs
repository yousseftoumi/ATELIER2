using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class CompteCourant : Compte
    {
        public MAD decouvert;

        public CompteCourant(Client C,MAD solde,MAD dec) : base(C, solde)
        {
            decouvert = dec;
        }

        public override void Afficher()
        {
            base.Afficher();
            Console.WriteLine("Découvert : " );
            decouvert.print();
        }

        public override void Debiter(MAD montant)
        {
            if (solde - montant > decouvert)
            {
                base.Debiter(montant);
            }
            else
            {
                Console.WriteLine("Operation de debit échouée : Découvert atteint");
            }
        }
    }
}
