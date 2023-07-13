public partial class SortSolution
{
    // 给你一个整数数组 nums，请你将该数组升序排列。
    public int[] SortArray1(int[] nums)
    {
        // 冒泡排序 直接超时
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] < nums[j])
                {
                    var temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        return nums;
    }
}