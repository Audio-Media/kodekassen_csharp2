// Figur 1
{
    // tre værdier
    {
        double temp1 = 8.4;
        double temp2 = 12.3;
        double temp3 = 15.0;
        double sum = temp1 + temp2 + temp3;   // 35.7
        double gns = sum / 3;                 // 11.9
    }

    // fire værdier
    {
        double temp1 = 8.4;
        double temp2 = 12.3;
        double temp3 = 15.0;
        double temp4 = 18.1;
        double sum = temp1 + temp2 + temp3 + temp4; // 53.8
        double gns = sum / 4;                       // 13.45
    }

}


// Figur 2
{
    // tre værdier
    {

        double[] temp = { 8.4, 12.3, 15.0 };
        // Skaber et array
        // |   0  |   1  |   2  |
        // |  8.4 | 12.3 | 15.0 |
        double gns = temp.Average();          // 11.9
    }

    // fire værdier 
    {
        double[] temp = { 8.4, 12.3, 15.0, 18.1 };
        // Skaber et array
        // |   0  |   1  |   2  |  3   |
        // |  8.4 | 12.3 | 15.0 | 18.1 |
        double gns = temp.Average();          // 13.45
    }
}


// Figur 3
{
    DateOnly dato = new DateOnly(2022, 3, 1);   // 2022-03-01
    DateOnly nyDato1 = dato.AddDays(7);         // 2022-03-08
    DateOnly nyDato2 = dato.AddMonths(-100);    // 2013-11-01
}

// Figur 4
{
    // Enkelte variabler
    string Person1Navn = "Abc";
    int Person1Alder = 10;

    string Person2Navn = "Def";
    int Person2Alder = 20;
}

// Figur 6
{
    Person person1 = new Person { Navn = "Abc", Alder = 10 };
    Person person2 = new Person { Navn = "Def", Alder = 20 };
}

// Figur 8
{
    Terning terning1 = new Terning();
    terning1.Skriv();       // Skriver tilfældig værdi som [x]
    terning1.Ryst();        // Finder ny værdi
    terning1.Skriv();       // Skriver tilfældig værdi som [x]
}



// Figur 5
    class Person
    {
        // Variabler i klasser kaldes felter
        // De erklæres her som offentlige så de
        // kan tilgås udefra.
        // Man vil normalt benytte egenskaber
        // for at beskytte felter for at blive
        // tildelt forkerte værdier.
        // Læs mere om egenskaber (properties)
        // på nettet eller i bøger
        public string Navn;
        public int Alder;
    }

// Figur 7
    class Terning
    {
        private Random rnd;
        private int Værdi;

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

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

class Bæger
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

    private string VærdierSomTekst()
    {
        string tekst = "";
        for (int i = 0; i < terninger.Length; i++)
            tekst = tekst + $"[{terninger[i]    }]";
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