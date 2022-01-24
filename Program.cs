using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassi_Hoone_loomine
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*Hoone_materjal materjal = Hoone_materjal.Palkmaja;
            Hoone hoone = new Hoone(135, materjal);
            hoone.NaitaInfo();*/

            EraMaja majake = new EraMaja();
            
            Inimene mees = new Inimene("Juku");
            majake.uks = new Uks("must");
            majake.NaitaInfo();
            majake.korteri = new KorteriteMaja("valge");
            mees.hoone = majake;
            mees.NaitaInfo();

            Console.ReadLine();

            /*Console.WriteLine($"Mina olen {info}, minu pindala on {Pindala} m2");
            Console.WriteLine($"Mina olen {Hoone_materjal}, minu pindala on {Pindala} m2");
            Console.WriteLine($"Mina olen maja, minu pindala on {Pindala} m2");
            Console.WriteLine($"Mina olen maja, mul on {Korrus} korrused ");
            Console.WriteLine($"Mina olen maja, minu number on {NumberMaja}");*/
        }
    }
}
