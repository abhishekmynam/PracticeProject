using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class BuySellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Count()== 0)
            {
                return 0;
            }

            int min = prices[0];
            int profit = 0;

            for (int i = 1; i < prices.Count(); i++)
            {
                if (prices[i] < min)
                {

                    min = prices[i];
                }
                else
                {
                    if (prices[i] - min > profit)
                    {
                        profit = prices[i] - min;
                    }

                }
            }
            return profit;
            
        }
    }
}
