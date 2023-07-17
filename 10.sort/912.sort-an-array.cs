// --- 八大排序 ---
// 冒泡排序	912. 排序数组
// 选择排序	215. 数组中的第K个最大元素
// 插入排序	147. 对链表进行插入排序
// 快速排序	973. 最接近原点的 K 个点
// 归并排序	23. 合并 K 个升序链表
// 堆排序	347. 前 K 个高频元素
// 桶排序	1648. 销售价值减少的颜色球 // 220. 存在重复元素 III
// 计数排序 75. 颜色分类
public partial class SortSolution
{
    // 912. 给你一个整数数组 nums，请你将该数组升序排列。

    // 冒泡排序：直接超时
    public int[] SortArray1(int[] nums)
    {
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

    // 选择排序
    public int[] SortArray2(int[] nums)
    {
        return null;
    }

    // 插入排序
    public int[] SortArray3(int[] nums)
    {
        return null;
    }

    // 快速排序
    public int[] SortArray4(int[] nums)
    {
        return null;
    }

    // 归并排序
    public int[] SortArray5(int[] nums)
    {
        return null;
    }

    // 堆排序
    public int[] SortArray6(int[] nums)
    {
        return null;
    }

    // 桶排序
    public int[] SortArray7(int[] nums)
    {
        return null;
    }

    // 计数排序
    public int[] SortArray8(int[] nums)
    {
        return null;
    }

}