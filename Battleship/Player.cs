using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Player
    {
        //member variables
        string name;
        List<Ship> shipsLeft = new List<Ship>();
        Board selfBoard;
        Board opponentBoard;

        //constructor
        public Player(string name)
        {
            this.name = name;
            Console.WriteLine($"What is {name}'s name?");
            this.name = Console.ReadLine();

            Board selfBoard = new Board("selfBoard");
            Board opponentBoard = new Board("opponentBoard");

            Ship destroyer = new Ship("Destroyer", 2);
            Ship submarine = new Ship("Submarine", 3);
            Ship battleship = new Ship("Battleship", 4);
            Ship carrier = new Ship("Aircraft CArrier", 5);
        }
        //member methods
    }
}
