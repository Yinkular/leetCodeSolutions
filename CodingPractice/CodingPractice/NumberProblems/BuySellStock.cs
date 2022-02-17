using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class BuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if(prices.Length ==0)
            {
                return 0;
            }

            int currentMinPrice = prices[0];
            int currentMaxProfit = 0;

            for(int i=1;i< prices.Length;i++)
            {
                if(prices[i] < currentMinPrice)
                {
                    currentMinPrice = prices[i];
                }
                else if(prices[i] > currentMinPrice)
                {
                    currentMaxProfit = Math.Max(currentMaxProfit, prices[i] - currentMinPrice);
                }

            }

            return currentMaxProfit;
        }
    }
}
