using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Components;

namespace DecoraterPatteren.Decoraters
{
    public class AttackBuff : PlayerAddOnDecorater
    {
        public AttackBuff(Player player) : base(player)
        {
            this.Attack += player.Attack + 20;
            this.Health  = player.Health;
        }

        public override void AttackPlayer(Player player)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("BUFF -- > Red Buff is active : 20 Dmg added!");
            Console.BackgroundColor = ConsoleColor.Black;

            // normal attack
            base.AttackPlayer(player);
            
            // Attack Buff Attack
            player.Health -= 20;
            
        }



    }
}
