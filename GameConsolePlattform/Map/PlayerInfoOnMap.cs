using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.Map
{
    public class PlayerInfoOnMap
    {
        public static void ShowPlayerNameOnMap(string name)
        {
            Console.SetCursorPosition(2, 26);
            Console.WriteLine($"Player: {name}                       ");
        }
    }
}
