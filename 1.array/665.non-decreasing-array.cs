public partial class ArraySolution
{
    // 给你一个长度为 n 的整数数组 nums ，请你判断在 最多 改变 1 个元素的情况下，该数组能否变成一个非递减数列。
    // 我们是这样定义一个非递减数列的： 对于数组中任意的 i (0 <= i <= n-2)，总满足 nums[i] <= nums[i + 1]。
    public bool CheckPossibility(int[] nums)
    {
        int notMatchTimes = 0;
        // 分析：数组中最多只能有一个不满足的nums[i] <= nums[i + 1]的情况
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (!(nums[i] <= nums[i + 1]))
            {
                notMatchTimes++;
                if (i > 0 && i < nums.Length - 2 && nums[i - 1] > nums[i + 1]
                        && (nums[i] > nums[i + 2]))
                {
                    return false;
                }
            }
            if (notMatchTimes > 1)
            {
                return false;
            }
        }
        return true;
    }
}