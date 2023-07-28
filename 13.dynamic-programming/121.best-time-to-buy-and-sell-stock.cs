public partial class DynamicProgrammingSolution
{
    public int MaxProfit(int[] prices)
    {
        var res = 0;
        var min = prices[0];
        for (int i = 1; i < prices.Length; i++)
        {
            min = Math.Min(prices[i], min);
            res = Math.Max((prices[i] - min), res);
        }
        return res;
    }
}