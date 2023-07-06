public partial class DailyProblemSolution
{
    public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
    {
        // 当圆心落在矩形内
        if (xCenter >= x1 && xCenter <= x2 && yCenter >= y1 && yCenter <= y2)
        {
            return true;
        }
        // 圆心落在矩形外，但x、y至少一个在范围内，两边到圆心的距离小于等于圆的半径
        else if (xCenter >= x1 && xCenter <= x2 && (Math.Abs(yCenter - y1) <= radius || Math.Abs(yCenter - y2) <= radius)
        || yCenter >= y1 && yCenter <= y2 && (Math.Abs(xCenter - x1) <= radius || Math.Abs(xCenter - x2) <= radius))
        {
            return true;
        }
        // 圆心落在矩形外，且x、y均不在范围内，矩形四个点圆心的距离小于等于圆的半径
        else if (Math.Sqrt(Math.Pow(x1 - xCenter, 2) + Math.Pow(y1 - yCenter, 2)) <= radius
        || Math.Sqrt(Math.Pow(x2 - xCenter, 2) + Math.Pow(y2 - yCenter, 2)) <= radius
        || Math.Sqrt(Math.Pow(x1 - xCenter, 2) + Math.Pow(y2 - yCenter, 2)) <= radius
        || Math.Sqrt(Math.Pow(x2 - xCenter, 2) + Math.Pow(y1 - yCenter, 2)) <= radius)
        {
            return true;
        }
        return false;
    }
}