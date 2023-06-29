public partial class Solution
{
    public int MaximumSum(int[] arr)
    {
        // 重置为空合 0
        // 删除一次的数组合 dp1
        // 未删除过的数组合 dp0
        // 最大值 res
        int dp0 = arr[0], dp1 = 0, res = arr[0];
        for (var i = 1; i < arr.Length; i++)
        {
            dp1 = Math.Max(dp0, dp1 + arr[i]);
            dp0 = Math.Max(dp0, 0) + arr[i];
            res = Math.Max(res, Math.Max(dp0, dp1));
        }
        return res;
    }
    public int MaximumSum1(int[] arr)
    {
        var maxNum = arr.Max();
        var minNum = arr.Min();
        // 最大值为负数
        if (maxNum < 0) { return maxNum; }

        var allSum = 0;
        var maxSum = 0;
        var sum = 0;
        // 直接一个循环，如果前面和是负数，就重置为零
        foreach (var a in arr)
        {
            if (sum < 0)
            {
                sum = 0;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
            }
            sum += a;
            allSum += a;

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        // 最小值为负数，且数组长度不为1， 总和减去最小值大于依次累加的情况
        if (minNum < 0 && arr.Length > 1)
        {
            maxSum = allSum - minNum > maxSum ? allSum - minNum : maxSum;
        }
        // 总和减去最小值大于依次累加的情况
        return maxSum;
    }
}