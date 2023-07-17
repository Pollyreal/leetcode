public partial class ArraySolution
{
    // 给定一个整数数组 nums，将数组中的元素向右轮转 k 个位置，其中 k 是非负数。
    public void Rotate(int[] nums, int k)
    {
        int[] nums2 = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            nums2[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums2[i];
        }
    }
}