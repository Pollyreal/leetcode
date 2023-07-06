public partial class DailyProblemSolution
{
    // https://leetcode.cn/problems/longest-common-subsequence/
    int LongestCommonSubsequence(String text1, String text2)
    {
        if (text1.Length == 0 || text2.Length == 0) return 0;
        int m = text1.Length;
        int n = text2.Length;
        int[,] dp = new int[m + 1, n + 1];
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (text1[i - 1] == text2[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                }
                else
                {
                    dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                }
            }
        }
        return dp[m, n];
    }

}
// Console.WriteLine(LongestCommonSubsequence("abc", "ace"));