using System;

namespace IfOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            //we gaan de AND opertator (&&) gebruiken
            //een lekker ijsje, alleen welke smaken kiezen we?

            //maak van 2 false hieronder true
            bool chocola = true;
            bool vanilla = false;
            bool banana = true;



            if (vanilla && chocola)//test hier of je chocola AND vanilla hebt gekozen 
            {
                Console.WriteLine("hier is je chocola vanilla ijsje"); 
            }
            else if (chocola && banana)//test hier of je chocola AND aardbei hebt gekozen 
            {
                Console.WriteLine("hier is je chocola banana ijsje"); 
            }
            else if (vanilla && banana)//test hier of je vanilla AND aardbei hebt gekozen 
            {
                Console.WriteLine("hier is je vanilla banana ijsje"); 
            }
        }
    }
}