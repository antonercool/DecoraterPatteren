using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;

namespace DecoraterPatteren.ConcreteComponents
{
    public class Warrior : Player
    {
        
        public Warrior()
        {
            Attack = 30;
            Health = 120;
            Description = "Warrior :";
        }

        public override int CalculateAttackDmg()
        {
            return Attack;
        }

        public override int CalculateHealth()
        {
            return Health;
        }

      
        public override void AttackPlayer(Player player)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine( $"Warrior attacking with Its hands : Dmg dealt ={this.CalculateAttackDmg()}");
            Console.BackgroundColor = ConsoleColor.Black;

            player.Health -= this.CalculateAttackDmg();
        }
    }
}
