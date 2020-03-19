using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Arena
    {
        //member variables

        //constructor
        public Arena()
        {
            Player playerOne = new Player("Player One");
            Player playerTwo = new Player("Player Two");
        }
        //member methods
        public void RunGame()
        {
            
        }

        public void DisplayBoard(Player player)
        {
            char char1 = 'A';
            int num1 = 1;

            Console.WriteLine("| |1|2|3|4|5|6|7|8|9|10|");
            Console.WriteLine("------------------------");
            Console.WriteLine($"{char1}|{player.Board");
        }
    }
}
