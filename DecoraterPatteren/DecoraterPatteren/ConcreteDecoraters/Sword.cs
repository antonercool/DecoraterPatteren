using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;
using DecoraterPatteren.Decorater;

namespace DecoraterPatteren.ConcreteDecoraters
{
    public class Sword : PlayerAddOnDecorater
    {
        public Sword(Player player) : base(player)
        {
            Attack = 150;
        }


        public override void AttackPlayer(Player player)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Attack with Sword! : Dmg dealt ={Attack}");
            _curretPlayer.AttackPlayer(player);

            player.Health -= Attack;
            Console.BackgroundColor = ConsoleColor.Black;

        }


        public override int CalculateAttackDmg()
        {
            return _curretPlayer.CalculateAttackDmg() + Attack;
        }
    }
}
