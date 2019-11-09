using System;
using System.Threading;

namespace GameConsolePlattform
{
    class Program
    {
       static PlayerModel.PlayerProcessor playerProcessor = new PlayerModel.PlayerProcessor();

        static void Main(string[] args)
        {
            Map.Map.BuildFrame();
            var player = playerProcessor.CreatePlayer();

            Map.PlayerInfoOnMap.ShowPlayerNameOnMap(player.Name);
            Map.Map.BuildPlayingfield(player.Head, player.Body);
            Map.Map.DrawPlayingField(Map.Map.playingField);
           
            
            while (true)
            {
                Movement.Movement.MoveCharacter();
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
