using System;
using System.Collections.Generic;
using System.Text;

namespace DecoraterPatteren.Components
{
    public abstract class Player
    {
        private int _health;

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        private int _attack;

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }


        public abstract void AttackPlayer(Player player);

    }
}
