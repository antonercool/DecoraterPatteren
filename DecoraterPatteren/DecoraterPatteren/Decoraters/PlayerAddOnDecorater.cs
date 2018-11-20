using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Components;

namespace DecoraterPatteren.Decoraters
{
    public abstract class PlayerAddOnDecorater : Player
    {
        protected Player _curretPlayer;

        public PlayerAddOnDecorater(Player newCurrent)
        {
            _curretPlayer = newCurrent;
        }
        
        public override void AttackPlayer(Player player)
        {
            _curretPlayer.AttackPlayer(player);
        }
    }
}
