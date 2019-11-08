using System;
using System.Threading;

namespace GameConsolePlattform
{
    class Program
    {
        private static object tread;

        static void Main(string[] args)
        {
            Map.Map.BuildFrame();
            //Map.Map.BuildGround();
            Map.Map.BuildPlayingfield();
            Map.Map.DrawPlayingField(Map.Map.playingField);
            while (true)
            {

                
                    Movement.Movement.MoveCharacter();
               
                
                Thread.Sleep(100);
            }
         
            //Player.Character.CreateCharacter();
            //Player.Character.DrawCharacter(40,21);



            Console.ReadLine();
        }
    }
}
