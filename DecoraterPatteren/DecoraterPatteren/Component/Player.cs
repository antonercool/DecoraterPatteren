using System;
using System.Collections.Generic;
using System.Text;

namespace DecoraterPatteren.Component
{
    public abstract class Player
    {
        public int Attack { get; set; }

        public int Health { get; set; }

        public string Description { get; set; }



        public abstract int CalculateAttackDmg();

        public abstract int CalculateHealth();

        public abstract void AttackPlayer(Player player);

    }
}
