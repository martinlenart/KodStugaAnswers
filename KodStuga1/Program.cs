﻿namespace KodStuga2
{
    public enum GrapeVariants
    {
        CabernetSauvignon, PinotNoir, Corvina, Shiraz, Merlot, Chablis,
        Riesling, Tempranillo
    }
    public enum GrapeRegions
    {
        Bordeaux, Burgundy, Veneto, Piedmonte, RiberaDelDuero,
        NapaValley, Puglia, Pfalz
    }
    public struct Wine
    {
        public int? Year;                   // null = undefined
        public string Name;
        public GrapeVariants? Grape;
        public GrapeRegions? Region;

        /// <summary>
        /// Creates a string representing the content of the Wine struct
        /// </summary>
        /// <returns>string that can be printed out using Console.WriteLine</returns>
        public override string ToString()
        {
            //Your code
            return $"Wine {Year} {Name} is made of {Grape} from {Region}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            const int maxNrBottles = 20;
            Wine[] myCellar = new Wine[maxNrBottles];

            Console.WriteLine($"My cellar can have maximum {maxNrBottles} bottles");

            Wine wine1 = new Wine { Year = 2000, Name = "Château Lafite Rothschild", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.Bordeaux };
            bool bOK = InsertWine(myCellar, wine1);

            Wine wine2 = new Wine { Year = 2010, Name = "Domaine de la Romanée-Conti", Grape = GrapeVariants.PinotNoir, Region = GrapeRegions.Burgundy };
            bOK = InsertWine(myCellar, wine2);

            Wine wine3 = new Wine { Year = 2005, Name = "Giuseppe Quintarelli Amarone", Grape = GrapeVariants.Corvina, Region = GrapeRegions.Veneto };
            bOK = InsertWine(myCellar, wine3);

            Wine wine4 = new Wine { Year = 2008, Name = "Sierra Cantabria", Grape = GrapeVariants.Tempranillo, Region = GrapeRegions.RiberaDelDuero };
            bOK = InsertWine(myCellar, wine4);

            Wine wine5 = new Wine { Year = 1992, Name = "Screaming Eagle", Grape = GrapeVariants.CabernetSauvignon, Region = GrapeRegions.RiberaDelDuero };
            bOK = InsertWine(myCellar, wine5);


            Console.WriteLine();
            PrintWines(myCellar);

            Console.WriteLine();
            Console.WriteLine(NrOfBottles(myCellar));

            Console.WriteLine();
            Console.WriteLine(NrOfBottles(myCellar, GrapeVariants.CabernetSauvignon));

        }

        /// <summary>
        /// Inserts a wine into myCellar at first available position
        /// </summary>
        /// <param name="myCellar"></param>
        /// <param name="wine"></param>
        /// <returns>true - if insertion was possible, otherwise false</returns>
        private static bool InsertWine(Wine[] myCellar, Wine wine)
        {
            //Your code
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i].Year == null)
                {
                    myCellar[i].Year = wine.Year;
                    myCellar[i].Name = wine.Name;
                    myCellar[i].Region = wine.Region;
                    myCellar[i].Grape = wine.Grape;

                    //alternative
                    myCellar[i] = wine;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Print out all the wines in myCellar
        /// </summary>
        /// <param name="myCellar"></param>
        private static void PrintWines(Wine[] myCellar)
        {
            //Your code
            foreach (var item in myCellar)
            {
                if (item.Year != null)
                {
                    Console.WriteLine(item);
                }
            }
        }

        /// <summary>
        /// Counts the number of bottles in myCellar. 
        /// </summary>
        /// <param name="myCellar"></param>
        /// <returns>Number of bottles in myCellar</returns>
        private static int NrOfBottles(Wine[] myCellar)
        {
            //Your code
            int c = 0;
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i].Year != null)
                {
                    c++;
                }
            }
            return c;
        }


        /// <summary>
        /// Counts the number of bottles in myCellar with a certain GrapeVariant 
        /// </summary>
        /// <param name="myCellar"></param>
        /// <param name="grape"></param>
        /// <returns></returns>
        private static int NrOfBottles(Wine[] myCellar, GrapeVariants grape)
        {
            //Your code
            int c = 0;
            for (int i = 0; i < myCellar.Length; i++)
            {
                if (myCellar[i].Year != null && myCellar[i].Grape == grape)
                {
                    c++;
                }
            }
            return c;
        }

    }
}
