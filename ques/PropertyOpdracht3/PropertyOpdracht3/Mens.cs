using System;
using System.Transactions;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        //maak hier een property Leeftijd:
        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (value > leeftijd)
                {
                    leeftijd = value;
                    Console.WriteLine("no problemo mi amigos ");

                }
                else
                {
                    Console.WriteLine("no");
                }
            }
        }
		
		//get: returned leeftijd
		//set:
		// deze moet controlleren of de nieuwe leeftijd wel hoger (>) is dan de huidige
		// als deze hoger is dan zet je de waarde op leeftijd
		//als lager, dan Console.WriteLine("dat kan niet!");

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}