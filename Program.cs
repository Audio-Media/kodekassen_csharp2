namespace Kodekassen
{
    class Program
    {

        public static void Main()
        {
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

            // Udfordring
            {
                Bæger i = new Bæger(1, 2, 3, 5, 6);
                
                Console.WriteLine($"{i.VærdierSomTekst()} : Et par = " + i.EtPar());
                Bæger b = new Bæger(1, 1, 2, 3, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : Et par = " + b.EtPar());

                Console.WriteLine($"{i.VærdierSomTekst()} : To par = " + i.ToPar());
                b = new Bæger(1, 1, 2, 2, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : To par = " + b.ToPar());

                Console.WriteLine($"{i.VærdierSomTekst()} : Tre ens = " + i.TreEns());
                b = new Bæger(1, 1, 1, 2, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : Tre ens = " + b.TreEns());

                Console.WriteLine($"{i.VærdierSomTekst()} : Fire ens = " + i.FireEns());
                b = new Bæger(1, 1, 1, 1, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : Fire ens = " + b.FireEns());

                Console.WriteLine($"{i.VærdierSomTekst()} : Fuldt hus = " + i.FuldtHus());
                b = new Bæger(1, 2, 1, 2, 1);
                Console.WriteLine($"{b.VærdierSomTekst()} : Fuldt hus = " + b.FuldtHus());

                Console.WriteLine($"{i.VærdierSomTekst()} : Høj = " + i.Høj());
                b = new Bæger(6, 2, 3, 4, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : Høj = " + b.Høj());

                Console.WriteLine($"{i.VærdierSomTekst()} : Lav = " + i.Lav());
                b = new Bæger(1, 2, 3, 4, 5);
                Console.WriteLine($"{b.VærdierSomTekst()} : Lav = " + b.Lav());

                Console.WriteLine($"{i.VærdierSomTekst()} : Yatzy = " + i.Yatzy());
                b = new Bæger(1, 1, 1, 1, 1);
                Console.WriteLine($"{b.VærdierSomTekst()} : Yatzy = " + b.Yatzy());

            }


        }
    }
}