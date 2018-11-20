using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;
using DecoraterPatteren.Decorater;

namespace DecoraterPatteren.ConcreteDecoraters
{
    public class HealthPotion : PlayerAddOnDecorater
    {
        public HealthPotion(Player player) : base(player)
        {
            Health = 100;
        }


        public override int CalculateHealth()
        {
            return _curretPlayer.CalculateHealth() + Health;
        }
    }
}
