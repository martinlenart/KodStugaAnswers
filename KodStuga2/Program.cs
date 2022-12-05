namespace KodStuga2
{

    class Program
    {
        static void Main(string[] args)
        {

            WineCellar abwc = new WineCellar();
            Console.WriteLine($"My cellar can have maximum {WineCellar.maxNrBottles} bottles");

            Wine wine1 = new Wine { Year = 2000, Name = "Château Lafite Rothschild", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux };
            bool bOK = abwc.InsertWine(wine1);

            Wine wine2 = new Wine { Year = 2010, Name = "Domaine de la Romanée-Conti", Grape = GrapeVariants.PinotNoir, Region = GrapeRegions.Burgundy };
            bOK = abwc.InsertWine(wine2);

            Wine wine3 = new Wine { Year = 2005, Name = "Giuseppe Quintarelli Amarone", Grape = GrapeVariants.Corvina, Region = GrapeRegions.Veneto };
            bOK = abwc.InsertWine(wine3);

            Wine wine4 = new Wine { Year = 2008, Name = "Sierra Cantabria", Grape = GrapeVariants.Tempranillo, Region = GrapeRegions.RiberaDelDuero };
            bOK = abwc.InsertWine(wine4);

            Wine wine5 = new Wine { Year = 1992, Name = "Screaming Eagle", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.RiberaDelDuero };
            bOK = abwc.InsertWine(wine5);


            Console.WriteLine();
            abwc.PrintWines();

            Console.WriteLine();
            Console.WriteLine(abwc.NrOfBottles());

            Console.WriteLine();
            Console.WriteLine(abwc.NrOfBottles(GrapeVariants.CabernetSauvignon));


            WineCellar abwc1 = new WineCellar();
            abwc1.InsertWine(new Wine { Year = 2000, Name = "An even better wine", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux });
 
            Console.WriteLine();
            Console.WriteLine(abwc1.NrOfBottles());

            Console.WriteLine();
            Console.WriteLine(abwc.NrOfBottles());

        }
    }
}
