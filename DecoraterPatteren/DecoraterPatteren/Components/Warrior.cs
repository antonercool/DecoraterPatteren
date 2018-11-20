using System;
using System.Collections.Generic;
using System.Text;

namespace DecoraterPatteren.Components
{
    public class Warrior : Player
    {
        
        public Warrior()
        {
            Attack = 30;
            Health = 120;
        }
        public override void AttackPlayer(Player player)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine( $"Warrior attacking with Its hands : Dmg dealt ={this.Attack}");
            Console.BackgroundColor = ConsoleColor.Black;

            player.Health -= this.Attack;
        }
    }
}
