using System;

namespace FunctionOpdracht2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program program= new Program();
            int nummer = program.MijnFavorietNummer();//deze werkt nu niet, pas de code onder aan om het te laten werken

            Console.WriteLine($"mijn favoriet nummer {nummer}");
        }

        //laat deze function een 'int' teruggeven
        private int MijnFavorietNummer()
        {

            int num = 7;

            return num;
        }

    }
}