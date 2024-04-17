using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bizonyitvanyCli
{
    internal class Bizi
    {
        string nev;
        string osztaly;
        int magyar;
        int matek;
        int angol;
        int tori;
        int info;
        int igazolt;
        int igazolatlan;

        public Bizi(string n, string o, int magy, int mat, int ang,int tor,int inf,int ig,int iglan)
        {
            nev = n;
            osztaly = o;
            magyar = magy;
            matek = mat;
            angol = ang;
            tori = tor;
            info = inf;
            igazolt = ig;
            igazolatlan = iglan;
        }
        public double atlagszamitas()
        {
            double atlag = (magyar + matek + angol + tori + info) / 5;
            return Math.Round(atlag, 1);
        }

        public string legjobbosztalyzatVissza()
        {
            int[] jegyek = new int[5];
            jegyek[0] = magyar;
            jegyek[1] = matek;
            jegyek[2] = angol;
            jegyek[3] = tori;
            jegyek[4] = info;

            int max = 0;
            int maxertek = 0;
            for(int i = 1; i < jegyek.Length; i++)
            {
                if (jegyek[i] > jegyek[max])
                {
                    max = i;
                    maxertek = jegyek[max];
                }
            }
            List<int> lista = new List<int>();
            for (int i = 0; i < jegyek.Length; i++)
            {
                if(maxertek == jegyek[i])
                {
                    lista.Add(i);
                }
            }
            string tantargyak = "";
            for (int i = 0;i < lista.Count; i++)
            {
                if (lista[i] == 0)
                    tantargyak = tantargyak+"magyar";
                if (lista[i] == 1)
                    tantargyak = tantargyak + "matek";
                if (lista[i] == 2)
                    tantargyak = tantargyak + "angol";
                if (lista[i] == 3)
                    tantargyak = tantargyak + "tori";
                if (lista[i] == 4)
                    tantargyak = tantargyak + "info";
            }
            return tantargyak;
        }
        public string levelkuldes()
        {
            string uzenet = "";
            if(igazolatlan >= 10)
            {
                uzenet = "Figyelem! " + nev + " Igazolatlan huányzásai (" + igazolatlan + " óra) miatt a szülőnek levelet kell írnia!";
            }
            else if(igazolt > 10)
            {
                uzenet = "Figyelem! " + nev + " Igazolatlan huányzásai (" + igazolt + " óra) miatt a szülőnek levelet kell írnia!";
            }
            else
            {
                uzenet = "Nincs teendő a hiányzásokkal kapcsolatban!";
            }
            return uzenet;
        }

    }
}
