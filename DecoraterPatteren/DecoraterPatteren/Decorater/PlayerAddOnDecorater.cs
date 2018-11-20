using System;
using System.Collections.Generic;
using System.Text;
using DecoraterPatteren.Component;


namespace DecoraterPatteren.Decorater
{
    public abstract class PlayerAddOnDecorater : Player
    {
        protected Player _curretPlayer;


        public void RemoveDecorater(string addOnToRemove, Player current)
        {
            string test = ((PlayerAddOnDecorater) ((PlayerAddOnDecorater) current)._curretPlayer).GetType().ToString();
            if (current.GetType().ToString() == "Mage" || current.GetType().ToString() == "Warrior" )
            {
                return;
            }
            else if (((PlayerAddOnDecorater)current)._curretPlayer == null)
            {
                return;

            }else if (((PlayerAddOnDecorater)((PlayerAddOnDecorater)current)._curretPlayer)
                .GetType().ToString().Contains(addOnToRemove))
            {
                ((PlayerAddOnDecorater) current)._curretPlayer =
                    ((PlayerAddOnDecorater) ((PlayerAddOnDecorater) current)._curretPlayer)._curretPlayer;
                return;
            }
            else
            {
                RemoveDecorater(addOnToRemove, ((PlayerAddOnDecorater)current)._curretPlayer);
            }
        }

        public PlayerAddOnDecorater(Player newCurrent)
        {
            _curretPlayer = newCurrent;
        }

        public override int CalculateAttackDmg()
        {
            return _curretPlayer.CalculateAttackDmg();
        }

        public override int CalculateHealth()
        {
            return _curretPlayer.CalculateHealth();
        }

        public override void AttackPlayer(Player player)
        {
            _curretPlayer.AttackPlayer(player);
        }
    }
}
