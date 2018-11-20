using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;
using DecoraterPatteren.Decorater;

namespace DecoraterPatteren.ConcreteDecoraters
{
    public class AttackBuff : PlayerAddOnDecorater
    {
        public AttackBuff(Player player) : base(player)
        {
            Description = "Red Buff ACTIVE";
            Attack = 20;
            Health = 0;
        }

        // Recursive base case for CalculateAttackDmg
        public override int CalculateAttackDmg()
        {
            return _curretPlayer.CalculateAttackDmg() + Attack;
        }

        // Recursive base case for Calculate Health
        public override int CalculateHealth()
        {
            return _curretPlayer.CalculateHealth() + Health;
        }

        // Recursive base case for attackPlayer
        public override void AttackPlayer(Player player)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Buff : {Description}  : Dmg dealt = {Attack}");
            Console.BackgroundColor = ConsoleColor.Black;

            // normal attack
            _curretPlayer.AttackPlayer(player);

            // With Buff
            player.Health -= Attack;

        }



    }
}
