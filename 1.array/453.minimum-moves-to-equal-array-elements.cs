public partial class ArraySolution
{
    // 给你一个长度为 n 的整数数组，
    // 每次操作将会使 n - 1 个元素增加 1 。
    // 返回让数组所有元素相等的最小操作次数。

    public int MinMoves1(int[] nums)
    {
        // 1. 暴力破解，判断是否相等，不相等的话，除了最大值都+1 
        // 结果：超出时间限制
        int times = 0;
        var max = nums.Max();
        var min = nums.Min();
        while (max != min)
        {
            int lastMaxIndex = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    lastMaxIndex = i;
                }
                nums[i] += 1;
            }
            nums[lastMaxIndex] -= 1;
            max = nums.Max();
            min = nums.Min();
            times++;
        }
        return times;
    }
    public int MinMoves(int[] nums)
    {
        // 2. 数学，理解成每个值减少1
        int times = 0;
        var min = nums.Min();
        for (int i = 0; i < nums.Length; i++)
        {
            times += nums[i] - min;
        }
        return times;
    }
}