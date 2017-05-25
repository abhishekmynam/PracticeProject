using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Count() == 0) return 0;
            int profit = int.MinValue;
            int min = prices[0];
            foreach (int i in prices)
            {
                if (i < min) min = i;
                if (profit < i - min) profit = i - min;
            }
            return profit;
        }
    }
}
