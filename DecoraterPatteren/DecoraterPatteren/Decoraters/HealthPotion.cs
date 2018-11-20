using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Components;

namespace DecoraterPatteren.Decoraters
{
    public class HealthPotion : PlayerAddOnDecorater
    {
        public HealthPotion(Player player) : base(player)
        {
            player.Health += 100;
        }



    }
}
