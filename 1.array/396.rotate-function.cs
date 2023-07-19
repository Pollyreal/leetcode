public partial class ArraySolution
{
    // 没解出来
    public int MaxRotateFunction(int[] nums)
    {
        // 超时
        int max = 0;
        int[] res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                var index = i - j < 0 ? nums.Length - j + i : i - j;

                res[j] += i * nums[index];

                max = res[j] > max ? res[j] : max;
            }
            //  var index = i - 1 < 0 ? nums.Length - 1 + i : i - 1;
            // res[i] += i * nums[i];
            // res[i + 1] += i * nums[index];
        }
        return max;
    }
}