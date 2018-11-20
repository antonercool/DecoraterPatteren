using System;
using System.Collections.Generic;
using System.Text;

namespace DecoraterPatteren.Components
{
    public class Mage : Player
    {

        public Mage()
        {
            Attack = 5;
            Health = 100;

        }
        public override void AttackPlayer(Player playerOther)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Mage attacking with its hands : Dmg dealt ={this.Attack}");

            // Decrement Health of other player
            playerOther.Health -= this.Attack;
            Console.BackgroundColor = ConsoleColor.Black;


        }

        public void AttackWithSpell(Player playerOther)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Mage attacking with Spell : Dmg dealt ={this.Attack + 20}");
            // Decrement Health of other player
            playerOther.Health -= this.Attack+20;
            Console.BackgroundColor = ConsoleColor.Black;


        }
    }
}
