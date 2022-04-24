namespace Kodekassen
{
    public partial class Bæger
    {

        private Terning[] terninger;

        public Bæger()
        {
            terninger = new Terning[5];
            for (int i = 0; i < 5; i++)
            {
                this.terninger[i] = new Terning();
            }
        }

        public string VærdierSomTekst()
        {
            string tekst = "";
            for (int i = 0; i < terninger.Length; i++)
                tekst = tekst + $"[{terninger[i].HentVærdi()}]";
            return tekst;
        }

        public void Ryst()
        {
            for (int i = 0; i < terninger.Length; i++)
                terninger[i].Ryst();
        }

        public void Skriv()
        {
            Console.WriteLine(this.VærdierSomTekst());
        }
    }






}