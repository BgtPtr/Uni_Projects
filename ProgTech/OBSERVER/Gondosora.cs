using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBSERVER
{
    class Gondosora
    {
        private List<Haziorvos> haziorvosok = new List<Haziorvos>();
        private List<Mentos> mentosok = new List<Mentos>();

        private Random rnd = new Random();
        private int Meres()
        {
            return rnd.Next(50, 200);
        }

        public void OrvosFeliratkozas(Haziorvos orvos)
        {
            haziorvosok.Add(orvos);
        }
     
        public void MentosFeliratkozas(Mentos mentos)
        {
            mentosok.Add(mentos);
        }
  
        public void MeresFunkcio()
        {
            int vercukor = Meres();
            int vernyomas = Meres();
            int pulzus = Meres();

       
            if (vercukor >= 70 && vercukor <= 140 && vernyomas >= 90 && vernyomas <= 140 && pulzus >= 60 && pulzus <= 100)
            {
                Console.WriteLine("A mérés eredménye normális.");
                return;
            }

            if ((vercukor < 70 || vercukor > 140) || (vernyomas < 90 || vernyomas > 140) || (pulzus < 60 || pulzus > 100))
            {
                foreach (var orvos in haziorvosok)
                {
                    orvos.Ertesites(vercukor, vernyomas, pulzus);
                }
            }

            if (vercukor < 50 || vercukor > 200 || vernyomas < 80 || vernyomas > 180 || pulzus < 40 || pulzus > 120)
            {
                foreach (var orvos in haziorvosok)
                {
                    orvos.Ertesites(vercukor, vernyomas, pulzus);
                }
                foreach (var mentos in mentosok)
                {
                    mentos.Ertesites(vercukor, vernyomas, pulzus);
                }
            }
        }
    }
}
