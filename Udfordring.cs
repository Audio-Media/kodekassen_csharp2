namespace Kodekassen
{


    using System.Linq;

    public partial class Terning
    {
        // Så kan man oprette en terning med en værdi
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
    }

    public partial class Bæger
    {

        // Så kan man oprette en terning med værdier
        public Bæger(int t1, int t2, int t3, int t4, int t5)
        {
            terninger = new Terning[] { new Terning(t1), new Terning(t2), new Terning(t3), new Terning(t4), new Terning(t5) };
        }

        // Finder en liste af grupper 

        // Hvis bægeret indeholder 1, 1, 2, 3, 4 er grupper = 
        // [{ Værdi: 1, Antal: 2 },
        // { Værdi: 2, Antal: 1 },
        // { Værdi: 3, Antal: 1 },
        // { Værdi: 4, Antal: 1 },
        // { Værdi: 5, Antal: 0 },
        // { Værdi: 6, Antal: 0 }]

        // Grupper kan efterfølgende bruges i mange af metoderne
        private List<TerningGruppe> FindGrupper()
        {
            List<TerningGruppe> grupper = new List<TerningGruppe>();
            for (int i = 1; i < 7; i++)
                grupper.Add(new TerningGruppe { Værdi = i, Antal = terninger.Count(t => t.HentVærdi() == i) });
            return grupper;
        }

        public bool EtPar()
        {
            return FindGrupper().Any(i => i.Antal >= 2);
        }

        public bool ToPar()
        {
            return FindGrupper().Where(i => i.Antal >= 2).Count() == 2;
        }

        public bool TreEns()
        {            
            return FindGrupper().Any(i => i.Antal >= 3);
        }

        public bool FireEns()
        {
            return FindGrupper().Any(i => i.Antal >= 4);
        }

        public bool FuldtHus()
        {
            // Hvis der præcis to grupper og én gruppe med tre ens, så er der fuldt hus
            if ((FindGrupper().Count(i => i.Antal >= 2) == 2) && (FindGrupper().Count(i => i.Antal == 3) == 1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Lav()
        {
            var t = terninger.OrderBy(i => i.HentVærdi()).ToList();
            return t[0].HentVærdi() == 1 && t[1].HentVærdi() == 2 && t[2].HentVærdi() == 3 && t[3].HentVærdi() == 4 && t[4].HentVærdi() == 5;
        }

        public bool Høj()
        {
            var t = terninger.OrderBy(i => i.HentVærdi()).ToList();
            return t[0].HentVærdi() == 2 && t[1].HentVærdi() == 3 && t[2].HentVærdi() == 4 && t[3].HentVærdi() == 5 && t[4].HentVærdi() == 6;
        }


        public bool Yatzy()
        {
            return FindGrupper().Any(i => i.Antal == 5);
        }

        private class TerningGruppe
        {
            public int Værdi { get; set; }
            public int Antal { get; set; }
        }
    }


}