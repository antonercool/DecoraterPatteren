using System;
using DecoraterPatteren.Components;
using DecoraterPatteren.Decoraters;

namespace DecoraterPatteren
{
    class Program
    {
        static void Main(string[] args)
        {
          
            // Create two new Concrete players // Mage and Warrior
            Player magePlayer = new Mage();
            Player warriorPlayer = new Warrior();

            Console.WriteLine("Initial stats");
            PrintCurrentStats(magePlayer, warriorPlayer);


            Console.WriteLine("Mage Attacks Warrior with normal Attack");
            magePlayer.AttackPlayer(warriorPlayer);
            PrintCurrentStats(magePlayer, warriorPlayer);
            
            // Adding Attack Buffs to both players
            Console.WriteLine("Players with added buffs");
            magePlayer = new AttackBuff(magePlayer);
            warriorPlayer = new AttackBuff(warriorPlayer);

            PrintCurrentStats(magePlayer, warriorPlayer);


            // Mage Player now attacks Warrior
            Console.WriteLine("Mage attacks Warrior with Buff Active");
            magePlayer.AttackPlayer(warriorPlayer);

            PrintCurrentStats(magePlayer, warriorPlayer);


            // Mage Now gets a Sword
            Console.WriteLine("Mage is now attacking with sword");
            magePlayer = new Sword(magePlayer);
            magePlayer.AttackPlayer(warriorPlayer);

            PrintCurrentStats(magePlayer, warriorPlayer);





            Console.ReadKey();


        }



        public static void PrintCurrentStats(Player player1, Player player2)
        {
            string aliveStatusPlayer1 = (player1.Health <= 0) ? "DEAD": player1.Health.ToString();
            string aliveStatusPlayer2 = (player2.Health <= 0) ? "DEAD" : player2.Health.ToString();

           
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write($"Mage: Health = {aliveStatusPlayer1}, Attack = {player1.Attack} \t\t");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Write($"Warrior: Health = {aliveStatusPlayer2}, Attack = {player2.Attack}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("");
            Console.WriteLine("");



        }
    }
}
