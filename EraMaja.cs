using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    public class EraMaja : Hoone
    {
        int pindala;
        string info;

        public EraMaja(int pindala = 50, int korrus = 15, int numberMaja = 72) : base(pindala, korrus, numberMaja)
        {

        }

        public string Info  //свойство для поля статус
        {
            get { return info; }    // код - чтение поля статус
        }
        public override void NaitaInfo()
        {
            if (Pindala < 100) info = "vaike maja";
            else if (Pindala >= 100 && Pindala < 150) info = "keskmine maja";
            else if (Pindala < 200) info = "suur maja";
            else info = "liiga suur maja";
            Console.WriteLine($"Mina olen {info}, minu pindala on {Pindala} m2");
        }
    }
}
