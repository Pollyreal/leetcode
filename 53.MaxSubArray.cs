public partial class Solution
{
    public int MaxSubArray(int[] arr)
    {
        var res = arr[0]; // 最大值
        var dp = arr[0]; // 当前合
        for (var i = 1; i < arr.Length; i++)
        {
            dp = Math.Max(arr[i], dp + arr[i]);
            res = Math.Max(res, dp);
        }
        return res;
    }
}
