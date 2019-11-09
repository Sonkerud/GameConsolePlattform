using GameConsolePlattform.Movement;
using System; 
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Map
{
    public class Map
    {
        public static string[,] playingField = new string[25,112]; 

        public static void BuildPlayingfield(string head, string body)
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
               
                    playingField[18, 60] = "X";
                    playingField[19, 60] = "X";

                    playingField[18, 19] = "X";
                    playingField[19, 19] = "X";

                    playingField[16, 20] = "X";
                    playingField[17, 20] = "X";

                    playingField[18, 20] = "X";
                    playingField[19, 20] = "X";

                    playingField[14, 21] = "O";



            }

            BuildCharacterInMapArray(head,body);

        }
        public static void DrawPlayingField(string[,] strArr)
        {

            for (int i = 0; i < strArr.GetLength(0)-2; i++)
            {
                Console.SetCursorPosition(2, i + 3);
                for (int z = 0; z < strArr.GetLength(1); z++)
                {
                    Console.Write(strArr[i, z]);
                }
            }

            Console.SetCursorPosition(116,28);
        }
        public static void BuildCharacterInMapArray(string head, string body)
        {
            playingField[Movement.Movement.playerPositionY, Movement.Movement.playerPositionX] = head;
            playingField[Movement.Movement.playerPositionY + 1, Movement.Movement.playerPositionX] = body;
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

        public static void OldDrawPlayingField()
        {
            //Console.SetCursorPosition(2, 13);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[9, i]);
            //}
            //Console.SetCursorPosition(2, 14);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[10, i]);
            //}
            //Console.SetCursorPosition(2, 15);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[11, i]);
            //}
            //Console.SetCursorPosition(2, 16);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[12, i]);
            //}
            //Console.SetCursorPosition(2, 17);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[13, i]);
            //}
            //Console.SetCursorPosition(2, 18);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[14, i]);
            //}
            //Console.SetCursorPosition(2, 19);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[15, i]);
            //}
            //Console.SetCursorPosition(2, 20);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[16, i]);
            //}
            //Console.SetCursorPosition(2, 21);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[17, i]);
            //}
            //Console.SetCursorPosition(2,22);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[18, i]);
            //}
            //Console.SetCursorPosition(2, 23);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[19, i]);
            //}
            //Console.SetCursorPosition(2, 24);
            //for (int i = 0; i < strArr.GetLength(1); i++)
            //{
            //    Console.Write(strArr[20, i]);
            //}
        }
    }
}
