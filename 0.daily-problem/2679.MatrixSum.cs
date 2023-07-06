public partial class Solution
{
    public int MatrixSum(int[][] nums)
    {
        int row = nums.Length;
        int column = nums[0].Length;
        int max = 0;
        int sum = 0;
        for (int j = 0; j < column; j++)
        {
            for (int i = 0; i < row; i++)
            {
                // find and remove max value
                var columnMax = nums[i].Max();
                nums[i] = RemoveMax(nums[i], columnMax);
                if (columnMax > max) max = columnMax;
            }
            // add to sum
            sum += max;
            // reset max
            max = 0;
        }
        return sum;
    }

    private int[] RemoveMax(int[] nums, int max)
    {
        int len = nums.Length;
        bool hasRemove = false;
        int[] res = new int[len - 1];
        int j = 0;
        for (int i = 0; i < len; i++)
        {
            if (nums[i] == max && !hasRemove)
            {
                hasRemove = true;
            }
            else
            {
                res[j] = nums[i];
                j++;
            }
        }
        return res;
    }
}
