public partial class BisectionSearchSolution
{
    public int[] SearchRange(int[] nums, int target)
    {
        if (nums.Length == 0)
        {
            return new int[] { -1, -1 };
        }
        int start = 0;
        int end = nums.Length - 1;
        while (start <= end)
        {
            Console.WriteLine("Step 1 {0}-{1}", start, end);
            var middleIndex = (start + end) / 2;
            var middle = nums[middleIndex];

            if (middle == target || middleIndex < 2 || middleIndex > nums.Length - 3)
            {
                while (start <= end)
                {
                    if (nums[start] != target)
                    {
                        start++;
                    }
                    else if (nums[end] != target)
                    {
                        end--;
                    }
                    else
                    {
                        return new int[] { start, end };
                    }
                    Console.WriteLine("Step 2 {0}-{1}", start, end);
                }
                return new int[] { -1, -1 };
            }
            if (middle < target)
            {
                if (start == middleIndex)
                {
                    break;
                }
                start = middleIndex;
            }
            else if (middle > target)
            {
                if (end == middleIndex)
                {
                    break;
                }
                end = middleIndex;
            }

        }

        return new int[] { -1, -1 };
    }
}