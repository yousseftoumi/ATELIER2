using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client C = new Client("Sbai", "Nizar", "Oulfa");
            Client C2 = new Client("Toumi", "Youssef", "Ain Chock");
            Compte Cmp1 = new Compte(C,new MAD(10000));
            Compte Cmp2 = new Compte(C2,new MAD(5000));
            Cmp1.Afficher();
            
            Cmp1.Crediter(new MAD(2000));
            Cmp1.ConsulterSolde();
            Cmp1.Verser(Cmp2,new MAD(6000));
            Cmp2.Debiter(new MAD(100));
            Cmp2.ConsulterSolde();
            Cmp2.Afficher();
            Console.WriteLine("\n\n\n");
            Operation Op = new Operation(new MAD(3000), "debit");
            Op.Afficher();
            Cmp1.ConsulterOperations();
            Cmp2.ConsulterOperations();
            Console.ReadKey();
        }
    }
}
