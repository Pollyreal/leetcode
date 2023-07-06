public partial class Solution
{
    public int PivotInteger(int n)
    {
        // SUM(1 : n) = n(n+1)/2
        // SUM(1 : x) = x(x+1)/2
        // SUM(x : n) = n(n+1)/2 - x(x-1)/2
        for (var x = 1; x <= n; x++)
        {
            if (x * (x + 1) == (n * (n + 1) - x * (x - 1)))
            {
                return x;
            }
        }
        return -1;
    }
}