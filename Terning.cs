namespace Kodekassen
{
    // Figur 7
    public partial class Terning
    {
        private Random rnd;
        private int Værdi;

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        // Bemærk - bør kodes som en readonly egenskab
        // men for artiklens skyld er der skabt en metode
        public int HentVærdi()
        {
            return this.Værdi;
        }

        public void Skriv()
        {
            Console.WriteLine($"[{this.HentVærdi()}]");
        }

        public Terning()
        {
            rnd = new Random();
            this.Ryst();
        }
    }






}