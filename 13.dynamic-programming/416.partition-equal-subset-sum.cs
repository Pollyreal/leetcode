public partial class DynamicProgrammingSolution
{
    // 416. 分割等和子集 没解出来
    public bool CanPartition(int[] nums)
    {
        var sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }
        if (sum % 2 > 0)
        {
            return false;
        }

        int dest = sum / 2;
        // 
        int tryDest = 0;
        var queue = new Queue<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            tryDest = tryDest + nums[i] <= dest ? tryDest + nums[i] : tryDest;
            if (tryDest == dest) return true;
        }
        return false;
    }
}