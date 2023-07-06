public partial class DailyProblemSolution
{
    // 没答出来
    public bool CheckSubarraySum(int[] nums, int k)
    {
        Dictionary<int, int> sum = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            foreach (var j in sum)
            {
                sum[j.Key] = sum[j.Key] + nums[i];
                if (sum[j.Key] % k == 0)
                {
                    return true;
                }
            }
            sum.Add(i, nums[i]);
        }
        return false;
    }
}
