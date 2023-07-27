public partial class GreedySolution
{
    public int MaxProfit(int[] prices)
    {
        int profit = 0;
        int hold = -1; // 价格可能为0
        // 第二天比今天高就买入，比今天低卖出
        for (int i = 1; i < prices.Length; i++)
        {
            if ((prices[i - 1] < prices[i]) && hold == -1)
            {
                hold = prices[i - 1];
            }
            else if ((prices[i - 1] > prices[i]) && hold != -1)
            {
                profit += prices[i - 1] - hold;
                hold = -1;
            }
            if (i == prices.Length - 1 && hold != -1)
            {
                profit += prices[i] - hold;
                hold = -1;
            }
        }
        return profit;
    }
}