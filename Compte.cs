using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    /*sealed keyword prevents class inheritance*/ class Compte 
    {
        private static int cmp;
        private readonly int numCompte;//Un attribut qui va etre modifié juste dans le constructeur
        private readonly Client titulaire;
        protected MAD solde;
        private static MAD plafond;
        private List<Operation> operations;

        //Constructeur statique qui sert a initialiser les attributs statiques: Pas de parametres et pas de niveau de visibilité
        static Compte()
        {
            cmp = 0;
            plafond = new MAD(5000);
        }
        public Compte(Client C, MAD solde)
        {
            cmp++;
            numCompte = cmp;
            titulaire = C;
            this.solde = solde;
            operations = new List<Operation>();
        }
        //Methodes
        public virtual void Afficher()
        {
            Console.WriteLine("Numero de compte : "+numCompte+"\nInformations du titulaire : ");
            titulaire.afficher();
            Console.Write("Solde : ");
            solde.print();
            Console.Write("Plafond : ");
            plafond.print();
        }
        public void ConsulterSolde()
        {
            Console.Write("Votre nouveau solde est de : ");
            solde.print();
        }
        public void Crediter(MAD montant)
        {
            if (montant > new MAD() )
            {
                solde.Egal(solde+montant);
                //solde.Egal(solde.Plus(montant));
                Console.WriteLine("Opération de Créditation effectuée avec succès");
                operations.Add(new Operation(montant, "creditation"));
            }
            else
                Console.WriteLine("Opération echouée : Montant a créditer non valide");
        }
        public virtual void Debiter(MAD montant)
        {
            if (montant > new MAD() && montant<solde && montant<plafond ) { 
                solde.Egal(solde-montant);
                Console.WriteLine("Opération de Débit effectuée avec succès");
                operations.Add(new Operation(montant, "debit"));

            }
            else
                Console.WriteLine("Opération echouée : Montant a débiter non valide");
        }
        public void Retirer(MAD montant)
        {
            if (montant<plafond && montant>new MAD())
            {
                solde.Egal(solde - montant);
                //solde.Egal(solde.Moins(montant));
            }
            else
                Console.WriteLine("Vous ne pouvez pas depasser le plafond designe");
        }
        public void Verser(Compte C,MAD montant)
        {
            this.Debiter(montant);
            C.Crediter(montant);
        }

        public void ConsulterOperations()
        {
            foreach(Operation op in operations)
            {
                op.Afficher();
            }
        }
    }
}
