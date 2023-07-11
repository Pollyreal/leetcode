public partial class ArraySolution
{
    // 给定一个数组 nums，编写一个函数将所有 0 移动到数组的末尾，同时保持非零元素的相对顺序。
    // 请注意 ，必须在不复制数组的情况下原地对数组进行操作。
    public void MoveZeroes1(int[] nums)
    {
        // append 实际创建了新数组，此方案不可行
        var len = nums.Length;
        var zeroCount = 0;
        for (int i = 0; i < len; i++)
        {
            if (nums[i] != 0)
            {
                nums.Append(nums[i]);
            }
            else
            {
                zeroCount++;
            }
        }
        for (int j = 0; j > zeroCount; j++)
        {
            nums.Append(0);
        }
        nums = nums.Take(new Range(len - 1, 2 * len - 1)).ToArray();
    }

    public void MoveZeroes(int[] nums)
    {
        var len = nums.Length;
        var zeroCount = 0;
        for (int i = 0, j = 0; i < len; i++, j++)
        {
            if (i >= len - zeroCount)
            {
                nums[i] = 0;
                continue;
            }
            while (nums[j] == 0 && j < len - 1) // 考虑数组长度为1
            {
                j++;
                zeroCount++;
            }
            nums[i] = nums[j];
        }
    }
}