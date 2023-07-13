public partial class BitwiseOperationSolution
{
    // 颠倒给定的 32 位无符号整数的二进制位。

    // 逐位颠倒
    public uint reverseBits1(uint n)
    {
        uint rev = 0;
        for (int i = 0; i < 32 && n != 0; i++)
        {
            rev |= (n & 1) << (31 - i); // |= 是赋值，n & 1是取最右位，<<左移相应位数
            n >>= 1;
        }
        return rev;
    }
    // 位运算分治
    public uint reverseBits(uint n)
    {
        // 思路
        //↑ 32 交换奇偶
        //| 16 交换奇偶
        //| 8 交换奇偶
        //| 4 交换奇偶
        //| 2 交换奇偶
        //|从下至上

        // 怎么做 先缓缓
        return 0;
    }
}