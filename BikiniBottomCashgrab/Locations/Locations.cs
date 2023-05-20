using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BikiniBottomCashgrab.Locations
{
    internal class Locations
    {

        public BigInteger CashEarningsPerSecond;
        Location[] arrayLocations = { new PrettyPatties(), new TentacleAcres() };


        public Locations() {}

        public BigInteger ReturnCost(int numberItems, int option)
        {
            return arrayLocations[option].CalculateCost(numberItems);
        }

        public void PurchaseLocation(int option, int numberItems)
        {
            arrayLocations[(option)].numberOwned += numberItems;
        }

        public int GetNumberOwned(int options)
        {
            return arrayLocations[options].numberOwned;
        }

        public void CalculateEarningsPerSecond()
        {
            BigInteger sum = BigInteger.Zero;
            foreach(var location in arrayLocations)
            {
               sum = BigInteger.Add(sum, location.CalculateEarnings());
            }
            CashEarningsPerSecond = sum;
        }
    }

    abstract class Location
    {
        public int numberOwned { get; set; }
        public int startingCost;
        public BigInteger earnings;
        public int startingEarnings;

        public abstract BigInteger CalculateCost(int numberItems);
        public abstract BigInteger CalculateEarnings();
    }

    class PrettyPatties : Location
    {

        public PrettyPatties()
        {
            numberOwned = 0;
            startingCost = 1;
            earnings = BigInteger.Zero;
            startingEarnings = 1;
        }

        /// <summary>
        /// This function calculates the cost at each index less than number of items to buy, sums them together, and returns the sum.
        /// </summary>
        /// <param name="numberItems">Number of items with which to calculate total cost to buy...</param>
        /// <returns>Total cost involved in purchasing numberItems items.</returns>
        public override BigInteger CalculateCost(int numberItems)
        {
            BigInteger sum = BigInteger.Zero;
            for(int i = 0; i < numberItems; i++)
            {
                int currentCostIndex = i + numberOwned;
                BigInteger cur = new BigInteger(
                    ((currentCostIndex+1)* startingEarnings) +
                    Math.Pow((1 / 10.0) * currentCostIndex, 1.3) +
                    Math.Pow((1 / 20.0)*currentCostIndex, 2) +
                    Math.Pow((1 / 100.0) * currentCostIndex, 8) +
                    Math.Pow((1 / 500.0) * currentCostIndex, 12) +
                    Math.Pow((1 / 1000.0) * currentCostIndex, 16) +
                    Math.Pow((1 / 2000.0) * currentCostIndex, 20) +
                    Math.Pow((1 / 3000.0) * currentCostIndex, 23) +
                    Math.Pow((1 / 4000.0) * currentCostIndex, 25) +
                    Math.Pow((1 / 5000.0) * currentCostIndex, 50)
                    );
                sum = BigInteger.Add(sum, cur);
            }

            //return the sum
            return sum;
        }

        public override BigInteger CalculateEarnings()
        {
            BigInteger cur = new BigInteger(
                    (Math.Pow((1 / 10.0) * numberOwned, 1.1) +
                    Math.Pow((1 / 20.0) * numberOwned, 1.5) +
                    Math.Pow((1 / 100.0) * numberOwned, 4) +
                    Math.Pow((1 / 500.0) * numberOwned, 8) +
                    Math.Pow((1 / 1000.0) * numberOwned, 12) +
                    Math.Pow((1 / 2000.0) * numberOwned, 16) +
                    Math.Pow((1 / 3000.0) * numberOwned, 20) +
                    Math.Pow((1 / 4000.0) * numberOwned, 24) +
                    Math.Pow((1 / 5000.0) * numberOwned, 40) + 
                    1) *
                    startingEarnings * numberOwned
                    );
            earnings = cur;
            return earnings;
        }
    }

    class TentacleAcres : Location
    {
        public TentacleAcres()
        {
            numberOwned = 0;
            startingCost = 100000;
            earnings = BigInteger.Zero;
            startingEarnings = 10000;
        }

        /// <summary>
        /// This function calculates the cost at each index less than number of items to buy, sums them together, and returns the sum.
        /// </summary>
        /// <param name="numberItems">Number of items with which to calculate total cost to buy...</param>
        /// <returns>Total cost involved in purchasing numberItems items.</returns>
        public override BigInteger CalculateCost(int numberItems)
        {
            BigInteger sum = BigInteger.Zero;
            for (int i = 0; i < numberItems; i++)
            {
                int currentCostIndex = i + numberOwned;
                BigInteger cur = new BigInteger(
                    ((currentCostIndex + 1) * startingCost) +
                    Math.Pow((1 / 10.0) * currentCostIndex, 1.5) +
                    Math.Pow((1 / 20.0) * currentCostIndex, 4) +
                    Math.Pow((1 / 100.0) * currentCostIndex, 12) +
                    Math.Pow((1 / 500.0) * currentCostIndex, 15) +
                    Math.Pow((1 / 1000.0) * currentCostIndex, 19) +
                    Math.Pow((1 / 2000.0) * currentCostIndex, 20) +
                    Math.Pow((1 / 3000.0) * currentCostIndex, 22) +
                    Math.Pow((1 / 4000.0) * currentCostIndex, 24) +
                    Math.Pow((1 / 5000.0) * currentCostIndex, 30)
                    );
                sum = BigInteger.Add(sum, cur);
            }

            //return the sum
            return sum;
        }

        public override BigInteger CalculateEarnings()
        {
            BigInteger cur = new BigInteger(
                    (Math.Pow((1 / 10.0) * numberOwned, 2) +
                    Math.Pow((1 / 20.0) * numberOwned, 4) +
                    Math.Pow((1 / 100.0) * numberOwned, 6) +
                    Math.Pow((1 / 500.0) * numberOwned, 8) +
                    Math.Pow((1 / 1000.0) * numberOwned, 10) +
                    Math.Pow((1 / 2000.0) * numberOwned, 12) +
                    Math.Pow((1 / 3000.0) * numberOwned, 14) +
                    Math.Pow((1 / 4000.0) * numberOwned, 16) +
                    Math.Pow((1 / 5000.0) * numberOwned, 35) +
                    1) *
                    startingEarnings * numberOwned
                    );
            earnings = cur;
            return earnings;
        }
    }
}
