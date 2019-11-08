using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Movement
{
    public class Movement
    {
        public static int playerPositionX = 42;
        public static int playerPositionY = 17;

        public static void MoveCharacter()
        {
            if (Console.KeyAvailable)
            {
                var command = Console.ReadKey().Key;

                switch (command)
                {
                    case ConsoleKey.DownArrow:
                        Crouch(playerPositionY,playerPositionX);
                        break;
                    case ConsoleKey.UpArrow:
                        Jump(playerPositionY,playerPositionX);
                        break;
                    case ConsoleKey.LeftArrow:
                        MoveLeft(playerPositionY, playerPositionX);
                        break;
                    case ConsoleKey.RightArrow:
                        MoveRight(playerPositionY, playerPositionX);
                        break;
                }
            }
        }

        public static void MoveRight(int y, int x)
        {

            Map.Map.playingField[y, x + 1] = Map.Map.playingField[y, x];
            //Map.Map.playingField[y, x + 2] = Map.Map.playingField[y, x + 1];

            Map.Map.playingField[y, x] = " ";
            //Map.Map.playingField[y, x + 1] = " ";

            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionX = playerPositionX + 1;
        }
        public static void MoveLeft(int y, int x)
        {
            Map.Map.playingField[y, x - 1] = Map.Map.playingField[y, x];
            //Map.Map.playingField[y, x - 2] = Map.Map.playingField[y, x - 1];

            Map.Map.playingField[y, x] = " ";
            //Map.Map.playingField[y, x - 1] = " ";

            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionX = playerPositionX - 1;
        }

        public static void Jump(int y, int x)
        {
            Map.Map.playingField[y - 1, x] = Map.Map.playingField[y, x];
            Map.Map.playingField[y, x] = " ";
            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionY = playerPositionY - 1;
        }
        public static void Crouch(int y, int x)
        {
            Map.Map.playingField[y + 1, x] = Map.Map.playingField[y, x];
            Map.Map.playingField[y, x] = " ";
            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionY = playerPositionY + 1;
        }

    }
}
