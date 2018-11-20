using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Components;

namespace DecoraterPatteren.Decoraters
{
    public class Sword : PlayerAddOnDecorater
    {
        public Sword(Player player) : base(player)
        {
            this.Attack = 250;
            this.Health = player.Health;

        }


        public override void AttackPlayer(Player player)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Attack with Sword! : Dmg dealt ={this.Attack}");

            player.Health -= 250;
            Console.BackgroundColor = ConsoleColor.Black;

        }
    }
}
