public partial class DailyProblemSolution
{
    // 递归法：代码少 效率低
    // public int Fib1(int n)
    // {
    //     if (n == 0) return 0;
    //     if (n == 1) return 1;
    //     return Fib1(n - 1) + Fib1(n - 2);
    // }


    // 动规 ＜（＾－＾）＞
    public int Fib(int n)
    {
        if (n <= 1) return n;
        int dp0 = 0, dp1 = 1, sum = 0;
        for (int i = 1; i < n; i++)
        {
            sum = dp0 + dp1;
            dp0 = dp1;
            dp1 = sum;
        }
        return sum;
    }
}
