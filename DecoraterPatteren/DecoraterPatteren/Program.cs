using System;
using DecoraterPatteren.Component;
using DecoraterPatteren.ConcreteComponents;
using DecoraterPatteren.ConcreteDecoraters;
using DecoraterPatteren.Decorater;


namespace DecoraterPatteren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(150,50);


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
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Attack + 20");
            Console.BackgroundColor = ConsoleColor.Black;
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



            // Add Health Potion to Mage And Warrior
            Console.WriteLine("Adding 3 Health Potions to Mage and Warrior");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Health + 300");
            Console.BackgroundColor = ConsoleColor.Black;
            magePlayer = new HealthPotion(magePlayer);
            magePlayer = new HealthPotion(magePlayer);
            magePlayer = new HealthPotion(magePlayer);

            warriorPlayer = new HealthPotion(warriorPlayer);
            warriorPlayer = new HealthPotion(warriorPlayer);
            warriorPlayer = new HealthPotion(warriorPlayer);

            // Mage attacks  Warrior agian
            Console.WriteLine("Mage Attack warrior agian");
            magePlayer.AttackPlayer(warriorPlayer);
            PrintCurrentStats(magePlayer, warriorPlayer);


            // Removing Sword
            Console.WriteLine("Removing sword from mage");
            ((PlayerAddOnDecorater)magePlayer).RemoveDecorater("Sword", magePlayer);

            PrintCurrentStats(magePlayer, warriorPlayer);


            // Mage attacks Warrior after removing Sword
            Console.WriteLine("Mage attacks Warrior after removing Sword");
            magePlayer.AttackPlayer(warriorPlayer);
            PrintCurrentStats(magePlayer, warriorPlayer);

            Console.ReadKey();


        }



        public static void PrintCurrentStats(Player player1, Player player2)
        {
            string aliveStatusPlayer1 = (player1.CalculateHealth() <= 0) ? $"DEAD : {player1.CalculateHealth().ToString()}": player1.CalculateHealth().ToString();
            string aliveStatusPlayer2 = (player2.CalculateHealth() <= 0) ? $"DEAD : {player2.CalculateHealth().ToString()}"  : player2.CalculateHealth().ToString();

           
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write($"Mage: Health = {aliveStatusPlayer1}, Attack = {player1.CalculateAttackDmg()} \t");
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write($"Warrior: Health = {aliveStatusPlayer2}, Attack = {player2.CalculateAttackDmg()}");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("");
            Console.WriteLine("");



        }
    }
}
