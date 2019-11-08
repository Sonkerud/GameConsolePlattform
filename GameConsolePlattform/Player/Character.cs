using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Player
{
    public class Character
    {
        public static string[,] CharacterArr { get; set; } = new string[3, 5];
        public static string[,] EmptyCharacterArr { get; set; } = new string[3, 5];


        public static string[,] CreateCharacter()
        {
            for (int i = 0; i < CharacterArr.GetLength(0); i++)
            {
                for (int x = 0; x < CharacterArr.GetLength(1); x++)
                {
                    CharacterArr[i, x] = " ";
                }
            }
            CharacterArr[0, 2] = "@";
            CharacterArr[0, 3] = ">";
            CharacterArr[1, 0] = "-";
            CharacterArr[1, 1] = "-";
            CharacterArr[1, 3] = "-";
            CharacterArr[1, 4] = "-";

            CharacterArr[1, 2] = "0";
            CharacterArr[2, 1] = "/";
            CharacterArr[2, 3] = "\\";
            return CharacterArr;

            
        }
        public static void BuildEmptyCharacter(int x, int y)
        {
            for (int i = 0; i < EmptyCharacterArr.GetLength(0); i++)
            {
                for (int z = 0; z < EmptyCharacterArr.GetLength(1); z++)
                {
                    EmptyCharacterArr[i, z] = " ";
                }
            }
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[0, i]);
            }
            Console.SetCursorPosition(x, y + 1);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[1, i]);
            }
            Console.SetCursorPosition(x, y + 2);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[2, i]);
            }


        }
        public static void DrawCharacter(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[0, i]);
            }
            Console.SetCursorPosition(x, y+1);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[1, i]);
            }
            Console.SetCursorPosition(x, y+2);
            for (int i = 0; i < CharacterArr.GetLength(1); i++)
            {
                Console.Write(CharacterArr[2, i]);
            }
            
        }

    }


}
