using System;

namespace CalculateOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //we gaan nu dingen kopen

            int controllersInMandje = 0;


            //koop 2 controllers
            controllersInMandje = controllersInMandje + 2; 

            //hij is in voorraad snel kopen!
            int ps5 = 0;

            ps5++;        


            //koop de games:

            int eldenRing = 0;
            eldenRing++;

            int shantae = 0;
            shantae++;
            int spongebob = 0;
            spongebob++;

            //hmmm weten we het zeker?
            //haal 1 game weg met -- of -= 1
            spongebob--;
            //nu nog de prijs


            double ps5Prijs = 499.99;
            double controllerPrijs = 69.99;
            double gamePrijs = 59.99;


            double totaalControllerPrijs = controllersInMandje*controllerPrijs;// controllersInMandje keer controllerPrijs
            double gamePrijsTotaal = gamePrijs *2;// game1 keer gamePrijs  + game2 keer gamePrijs (let op je haakjes!)
            


            double totaalPrijs = ps5Prijs + totaalControllerPrijs + gamePrijsTotaal ;// tel hier alles bij elkaar op

            Console.WriteLine("your total is " + totaalPrijs);

            //er moet nu 759.95 staan
        }
    }
}