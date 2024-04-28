using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVER
{
    class Mentos
    {
        public string Nev { get; set; }
        public string Lakcim { get; set; }

        public Mentos(string nev, string lakcim)
        {
            Nev = nev;
            Lakcim = lakcim;
        }

        // Értesítés funkció
        public void Ertesites(int vercukor, int vernyomas, int pulzus)
        {
            Console.WriteLine($"Mentős {Nev} értesítve! Lakcím: {Lakcim}, Mért adatok: Vércukor: {vercukor}, Vérnyomás: {vernyomas}, Pulzus: {pulzus}");
        }
    }
}
