using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsolePlattform.PlayerModel
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string Head { get; set; }
        public string Body { get; set; }

        public Player()
        {
            Console.SetCursorPosition(3,3);
            Console.WriteLine("Hey Player! What's your name? ");
            Console.SetCursorPosition(3,4);
            Name = Console.ReadLine();
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Please pick your head. Input one character:");
            Console.SetCursorPosition(47,5);
            Head = Console.ReadLine();
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("Please pick your body. Input one character:");      
            Console.SetCursorPosition(47,6);
            Body = Console.ReadLine();
        }

       
        

    }
}
