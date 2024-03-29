﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace GameConsolePlattform.Movement
{
    public class Movement
    {
        public static int playerPositionX = 3;
        public static int playerPositionY = 18;

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
            FallToGround(playerPositionY, playerPositionX);
            BounceSymbolActivation(playerPositionY, playerPositionX);
        }

        public static void MoveRight(int y, int x)
        {
            var nextPlaceOnPlayingField = Map.Map.playingField[y, x + 1];

            if (nextPlaceOnPlayingField != "X")
            {
                Map.Map.playingField[y, x + 1] = Map.Map.playingField[y, x]; // huvud går ett steg höger
                Map.Map.playingField[y + 1, x + 1] = Map.Map.playingField[y + 1, x]; // kropp går ett steg höger

                Map.Map.playingField[y, x] = " ";
                Map.Map.playingField[y + 1, x] = " ";
                playerPositionX = playerPositionX + 1;
            }

            Map.Map.DrawPlayingField(Map.Map.playingField);
            Thread.Sleep(150);
            MoveCharacter();
        
        }
        public static void MoveLeft(int y, int x)
        {
            var nextPlaceOnPlayingField = Map.Map.playingField[y, x - 1];

            if (nextPlaceOnPlayingField != "X")
            {
                Map.Map.playingField[y, x - 1] = Map.Map.playingField[y, x];
                Map.Map.playingField[y + 1, x - 1] = Map.Map.playingField[y + 1, x]; // kropp går ett steg höger

                Map.Map.playingField[y, x] = " ";
                Map.Map.playingField[y + 1, x] = " ";
                playerPositionX = playerPositionX - 1;
            }
           

            Map.Map.DrawPlayingField(Map.Map.playingField);
            Thread.Sleep(150);
            MoveCharacter();

           
        }
        public static void Jump(int y, int x)
        {
            Map.Map.playingField[y - 2, x] = Map.Map.playingField[y, x];
            Map.Map.playingField[y - 1 , x] = Map.Map.playingField[y + 1, x];

            Map.Map.playingField[y + 1, x] = " ";
            Map.Map.playingField[y , x] = " ";

            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionY = playerPositionY - 2;

            Thread.Sleep(250);
            MoveCharacter();
            Thread.Sleep(100);
            NotJump(playerPositionY, playerPositionX);

        }
        public static void Crouch(int y, int x)

        {
            Map.Map.playingField[y + 1, x] = Map.Map.playingField[y, x];

            Map.Map.playingField[y, x] = " ";
            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionY = playerPositionY + 1;
           
            Thread.Sleep(300);
            NotCrouch(playerPositionY, playerPositionX);

        }
        public static void NotCrouch(int y, int x)
        {
            Map.Map.playingField[y - 1, x] = Map.Map.playingField[y, x];

            Map.Map.playingField[y, x] = "0";
            Map.Map.DrawPlayingField(Map.Map.playingField);
            playerPositionY = playerPositionY - 1;
        }
        public static void NotJump(int y, int x)
        {
            var nextSquareOnPlayingField = Map.Map.playingField[y +3, x];
            var nextPlaceOnPlayingField = Map.Map.playingField[y +2 , x];
            if (nextPlaceOnPlayingField != "X" && nextPlaceOnPlayingField != "T" && nextSquareOnPlayingField != "X" && nextSquareOnPlayingField != "T" && nextSquareOnPlayingField != "O" && nextPlaceOnPlayingField != "O")
            {
                Map.Map.playingField[y + 3, x] = Map.Map.playingField[y + 1, x]; // tom ruta blir kropp
                Map.Map.playingField[y + 2, x] = Map.Map.playingField[y, x];  // kropp blir huvud
                Map.Map.playingField[y + 1, x] = " "; //  Huvud blir tomt fält    
                Map.Map.playingField[y, x] = " "; //  kropp blir tomt fält
                playerPositionY = playerPositionY + 2;
            }
            Map.Map.DrawPlayingField(Map.Map.playingField);
            //FallToGround(playerPositionY, playerPositionX);

        }
        public static void FallToGround(int y, int x) 
        {
            var nextSquareOnPlayingField = Map.Map.playingField[y + 3, x];
            var nextPlaceOnPlayingField = Map.Map.playingField[y + 2, x];
            if (nextPlaceOnPlayingField != "X" && nextPlaceOnPlayingField != "T" && nextSquareOnPlayingField != "X" && nextSquareOnPlayingField != "T" && nextPlaceOnPlayingField != "O" && nextSquareOnPlayingField != "O")
            {
                Map.Map.playingField[y + 3, x] = Map.Map.playingField[y + 1, x]; // tom ruta blir kropp
                Map.Map.playingField[y + 2, x] = Map.Map.playingField[y, x];  // kropp blir huvud
                Map.Map.playingField[y + 1, x] = " "; //  Huvud blir tomt fält    
                Map.Map.playingField[y, x] = " "; //  kropp blir tomt fält
                playerPositionY = playerPositionY + 2;
                Map.Map.DrawPlayingField(Map.Map.playingField);
            }

            else if (nextPlaceOnPlayingField != "X" && nextPlaceOnPlayingField != "T" && nextPlaceOnPlayingField != "O")
            {
                Map.Map.playingField[y + 2, x] = Map.Map.playingField[y + 1, x]; // tom ruta blir kropp
                Map.Map.playingField[y + 1, x] = Map.Map.playingField[y, x];  // kropp blir huvud
                Map.Map.playingField[y , x] = " "; //  Huvud blir tomt fält    
             
                playerPositionY = playerPositionY + 1;
                Map.Map.DrawPlayingField(Map.Map.playingField);
            }
        }
        public static void BounceSymbolActivation(int y, int x)
        {
            var nextPlaceOnPlayingField = Map.Map.playingField[y + 2, x];
            if (nextPlaceOnPlayingField == "O")
            {
                Jump(y,x);
            }
        }
    }
}
