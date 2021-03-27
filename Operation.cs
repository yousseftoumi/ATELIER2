using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class Operation
    {
        private static int cmp=0;
        private int numero;
        private DateTime date;
        private MAD montant;
        private string libelle;

        public Operation(MAD mnt,string libelle)
        {
            numero = ++cmp;
            date = DateTime.Now;
            montant = mnt;
            while (libelle!="creditation" && libelle != "debit")
            {
                Console.WriteLine("Le libelle d'une operation doit etre soit debit soit creditation");
                libelle = Console.ReadLine();
            }
            this.libelle = libelle;
        }

        public void Afficher()
        {
            string signe = (libelle == "debit") ? "-" : "+";
            Console.Write(date.ToShortDateString()+ " | nº "+numero+" | "+signe);
            montant.print();
        }
    }
}
