using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public abstract class Hoone
    {
        public int Pindala { get; set; }
        public int Korrus { get; set; }
        public int NumberMaja { get; set; }
        public Hoone_materjal Hoone_materjal { get; }
        public Uks uks;
        public KorteriteMaja korteri;

        public Hoone(int pindala = 200, int korrus = 10, int numberMaja = 65)
        {
            Pindala = pindala;
            Korrus = korrus;
            NumberMaja = numberMaja;
        }

        public Hoone(int pindala, Hoone_materjal hoone_Materjal)
        {
            Pindala = pindala;
            Hoone_materjal = Hoone_materjal;
        }

        public abstract void NaitaInfo();
        public Uks GetUks()
        {
            return uks;
        }

        public KorteriteMaja GetKorter()
        {
            return korteri;
        }
    }
}
