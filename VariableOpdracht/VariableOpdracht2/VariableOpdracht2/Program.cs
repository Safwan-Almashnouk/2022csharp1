using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();


            //name, waarde: je favoriete streamer
            //lastStreamName, waarde: de streamname van de laatste keer
            //streamGame, waarde een nieuwe instance van Game (new Game("naam van de game hier"})
            //followers, waarde: hoeveel followers
            //automod, waarde: staat automod aan?
            twitchStream.name = "Pyrocynical";
            twitchStream.LastStreamName = "Wales is SHIT";
            Game streamGame = new Game("Blooodborne");
           
            twitchStream.followers = 2550;
            twitchStream.automod = true;
           



            Console.WriteLine("his new game is "+ streamGame.name);

        }
    }
}