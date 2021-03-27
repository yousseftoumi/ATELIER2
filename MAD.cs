using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtelierN1
{
    class MAD
    {
        private double valeur;
        public MAD()
        {
            valeur = 0;
        }
        public MAD(double val)
        {
            valeur = val;
        }
        public void print()
        {
            Console.Write(valeur+" MAD\n");
        }
        public static MAD operator +(MAD M,MAD N)
        {
            MAD mad = new MAD(M.valeur + N.valeur);
            return mad;
        }
        //Lambda expression
        //public static MAD operator +(MAD M, MAD N) => new MAD(M.valeur + N.valeur);

        public static MAD operator -(MAD M,MAD N)
        {
            MAD mad = new MAD(M.valeur - N.valeur);
            return mad;
        }
        public static MAD operator *(MAD M,double d)
        {
            return new MAD(M.valeur * d);
        }
        public static MAD operator /(MAD M,double d)
        {
            return new MAD(M.valeur / d);
        }
        //public static MAD operator =(MAD m, MAD n)
        //{
        //    m.valeur = n.valeur;
        //    return m;
        //}
        public static bool operator >(MAD M,MAD N)
        {
            return M.valeur>N.valeur;
        }
        public static bool operator <(MAD M,MAD N)
        {
            return M.valeur<N.valeur;
        }
        //public MAD Plus(MAD M)
        //{
        //    MAD mad = new MAD(0);
        //    mad.valeur = this.valeur + M.valeur;
        //    return mad;
        //}
        //public MAD Moins(MAD M)
        //{
        //    MAD mad = new MAD(0);
        //    mad.valeur = this.valeur - M.valeur;
        //    return mad;
        //}
        public MAD Egal(MAD M)
        {
            this.valeur = M.valeur;
            return this;
        }
        //public bool Superieur(MAD M)
        //{
        //    return valeur > M.valeur;
        //}
        //public bool Inferieur(MAD M)
        //{
        //    return valeur < M.valeur;
        //}
    }
}
