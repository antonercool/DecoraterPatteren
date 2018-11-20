using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;

namespace DecoraterPatteren.ConcreteComponents
{
    public class Mage : Player
    {
        public int SpellDmg { get; set; }

        public Mage()
        {
            Attack = 5;
            Health = 100;
            Description = "Mage : ";
            SpellDmg = 50;

        }


        public override int CalculateAttackDmg()
        {
            return Attack;
        }

        public override int CalculateHealth()
        {
            return Health;
        }

      
        public override void AttackPlayer(Player playerOther)
        {
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine($"Mage attacking with its hands : Dmg dealt = {Attack}");

            // Decrement Health of other player
            playerOther.Health-= Attack;
            Console.BackgroundColor = ConsoleColor.Black;


        }

        public void AttackWithSpell(Player playerOther)
        {

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Mage attacking with Spell : Dmg dealt = {SpellDmg}");
            // Decrement Health of other player
            playerOther.Health -= Attack;
            Console.BackgroundColor = ConsoleColor.Black;


        }
    }
}
