using System; 
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Map
{
    public class Map
    {
        public static string[,] playingField = new string[20,112]; 

        public static void BuildPlayingfield()
        {
            for (int i = 0; i < playingField.GetLength(0); i++)
            {
                for (int z = 0; z < playingField.GetLength(1); z++)
                {
                    playingField[i, z] = " ";
                }
            }

            playingField[17, 42] = "@";
            playingField[17, 43] = ">";
   
            //playingField[18, 40] = "-";
            //playingField[18, 41] = "-";
            //playingField[18, 43] = "-";
            //playingField[18, 44] = "-";
            //playingField[18, 42] = "0";

            //playingField[19, 41] = "/";
            //playingField[19, 43] = "\\";

        }
        public static void DrawPlayingField(string[,] strArr)
        {
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
