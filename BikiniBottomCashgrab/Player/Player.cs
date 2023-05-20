using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BikiniBottomCashgrab.Player
{

    public enum enumLocations { PrettyPatties, TentacleAcres };
    internal class Player
    {
        public BigInteger playerCash;
        public Locations.Locations activeSet;

        public Player()
        {
            activeSet = new Locations.Locations();
            playerCash = new BigInteger(1);
        }

        public bool BuyOption(enumLocations option, int numberItems)
        {
            BigInteger cost = activeSet.ReturnCost(numberItems, (int)option);
            if(cost <= playerCash)
            {
                playerCash -= cost;
                activeSet.PurchaseLocation((int)option, numberItems);
                RecalculateEarningsPerSecond();
                return true;
            }
            return false;
        }

        public int GetNumberOwned(enumLocations option)
        {
            return activeSet.GetNumberOwned((int)option);
        }

        public BigInteger GetCost(enumLocations option, int numberItems)
        {
            return activeSet.ReturnCost(numberItems, (int)option);
        }

        public BigInteger GetEarningsPerSecond()
        {
            return activeSet.CashEarningsPerSecond;
        }

        public void RecalculateEarningsPerSecond()
        {
            activeSet.CalculateEarningsPerSecond();
        }
    }
}
