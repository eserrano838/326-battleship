using System;

namespace BattleShip
{
    public class Project
    {
        public static void Main(String[] args)
        {
            string player1name;
            string player2name;

            Console.WriteLine("Welcome to BattleShip!");

            Console.Write("Please enter Player 1's name: ");
            player1name = Console.ReadLine();

            Console.Write("Please enter Player 2's name: ");
            player2name = Console.ReadLine();

            Player player1 = new Player(player1name);
            Player player2 = new Player(player2name);

            Console.Write(player1.Name);
            Console.Write(player2.Name);

        }
    }
}
