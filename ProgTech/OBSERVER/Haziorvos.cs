using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVER
{
    class Haziorvos
    {
        public string Nev { get; set; }

        public Haziorvos(string nev)
        {
            Nev = nev;
        }

        public void Ertesites(int vercukor, int vernyomas, int pulzus)
        {
            Console.WriteLine($"Háziorvos {Nev} értesítve! Mért adatok: Vércukor: {vercukor}, Vérnyomás: {vernyomas}, Pulzus: {pulzus}");
        }
    }
}
