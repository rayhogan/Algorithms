using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class GreedyChange
    {

        public static void DetermineChange(int[] coinPurse, Decimal amount)
        {

            /* Euro denominations (IRE)
             *  €2
             *  €1
             *  €0.50
             *  €0.20
             *  €0.10
             *  €0.05
             *  €0.02
             *  €0.01
             */
            if(amount >= 2.0m)
            {
                coinPurse[0] = (int)(amount / 2.0m);
                amount = amount % 2.0m;
            }

            if (amount >= 1.0m)
            {
                coinPurse[1] = (int)(amount / 1.0m);
                amount = amount % 1.0m;
            }

            if (amount >= 0.5m)
            {
                coinPurse[2] = (int)(amount / 0.5m);
                amount = amount % 0.5m;
            }

            if (amount >= 0.5m)
            {
                coinPurse[2] = (int)(amount / 0.5m);
                amount = amount % 0.5m;
            }

            if (amount >= 0.2m)
            {
                coinPurse[3] = (int)(amount / 0.2m);
                amount = amount % 0.2m;
            }

            if (amount >= 0.1m)
            {
                coinPurse[4] = (int)(amount / 0.1m);
                amount = amount % 0.1m;
            }

            if (amount >= 0.05m)
            {
                coinPurse[5] = (int)(amount / 0.05m);
                amount = amount % 0.05m;
            }

            if (amount >= 0.02m)
            {
                coinPurse[6] = (int)(amount / 0.02m);
                amount = amount % 0.02m;
            }

            if (amount > 0.0m)
            {
                coinPurse[7] = 1;
            }
        }

       
    }
}
