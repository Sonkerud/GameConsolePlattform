﻿using GameConsolePlattform.Movement;
using System; 
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Map
{
    public class Map
    {
        public static string[,] playingField = new string[25,112]; 

        public static void BuildPlayingfield()
        {
            for (int i = 0; i < playingField.GetLength(0); i++)
            {
                for (int z = 0; z < playingField.GetLength(1); z++)
                {
                    playingField[i, z] = " ";
                }
            }

            for (int i = 0; i < playingField.GetLength(1); i++)
            {
                playingField[20,i] = "T";
            }

            //Hinder
            for (int i = 0; i < playingField.GetLength(0); i++)
            {
               
                    playingField[18, 60] = ".";
                    playingField[19, 60] = ".";

                    playingField[18, 21] = ".";
                    playingField[19, 21] = ".";

                    playingField[16, 20] = ".";
                    playingField[17, 20] = ".";

                    playingField[18, 20] = ".";
                    playingField[19, 20] = ".";

                    playingField[14, 19] = "O";



            }


            playingField[Movement.Movement.playerPositionY, Movement.Movement.playerPositionX] = "@";
            //playingField[17, 43] = ">";
   
            //playingField[18, 40] = "-";
            //playingField[18, 41] = "-";
            //playingField[18, 43] = "-";
            //playingField[18, 44] = "-";
            playingField[Movement.Movement.playerPositionY+1, Movement.Movement.playerPositionX] = "0";

            //playingField[19, 41] = "/";
            //playingField[19, 43] = "\\";

        }
        public static void DrawPlayingField(string[,] strArr)
        {
            Console.SetCursorPosition(2, 13);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[9, i]);
            }
            Console.SetCursorPosition(2, 14);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[10, i]);
            }
            Console.SetCursorPosition(2, 15);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[11, i]);
            }
            Console.SetCursorPosition(2, 16);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[12, i]);
            }
            Console.SetCursorPosition(2, 17);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[13, i]);
            }
            Console.SetCursorPosition(2, 18);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[14, i]);
            }
            Console.SetCursorPosition(2, 19);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[15, i]);
            }
            Console.SetCursorPosition(2, 20);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[16, i]);
            }
            Console.SetCursorPosition(2, 21);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[17, i]);
            }
            Console.SetCursorPosition(2,22);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[18, i]);
            }
            Console.SetCursorPosition(2, 23);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[19, i]);
            }
            Console.SetCursorPosition(2, 24);
            for (int i = 0; i < strArr.GetLength(1); i++)
            {
                Console.Write(strArr[20, i]);
            }
            Console.SetCursorPosition(116,28);
        }

        public static void BuildFrame()
        {
            string top = " ________________________________________________________________________________________________________________";
            string bottom = "|________________________________________________________________________________________________________________|";
           
            
            Console.SetCursorPosition(1, 0);
            Console.Write(top);
            for (int row = 1; row < 28; row++)
            {
                Console.SetCursorPosition(1, row);
                Console.Write("|");
                Console.SetCursorPosition(114, row);
                Console.Write("|");
            }
            Console.SetCursorPosition(1, 28);
            Console.Write(bottom);
        }
        public static void BuildGround()
        {
            string ground = "TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT";
            var h = ground.Length;
            char[] groundArr = ground.ToCharArray();
            Console.SetCursorPosition(2, 24);
            foreach (var item in groundArr)
            {
                Console.Write(item);
            }
        }
    }
}
