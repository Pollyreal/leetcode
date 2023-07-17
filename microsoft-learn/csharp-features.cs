/// <summary>
/// <para>
/// 1. 如何选择运行框架的C#版本
/// https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/configure-language-version#defaults 
/// </para>
/// <para>
/// 2. C# 代码约定
/// https://learn.microsoft.com/zh-cn/dotnet/csharp/fundamentals/coding-style/coding-conventions
/// </para>
/// </summary>
public class LearnSolution
{
    public async Task<int> RetrieveDocsHomePage()
    {
        var client = new HttpClient();
        byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/");

        Console.WriteLine($"{nameof(RetrieveDocsHomePage)}: Finished downloading.");
        return content.Length;
    }

    /// <summary> 
    /// C# 8.0 features - Switch expression
    /// <para>switch语句及switch表达式，支持的匹配模式参考以下链接
    /// https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/operators/patterns?source=recommendations
    /// </para></summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public string TestPatternMatch(string parameter) =>
    parameter switch
    {
        "Hey" => "hey hey!",
        "Hello" => "Hello world!",
        _ => "are you ok?" // _ 为弃元模式 discard pattern 来匹配任何表达式，包括 null
    };

    /// <summary>
    /// new 运算符实例对象的简洁形式
    /// </summary>
    public void NewOperator()
    {
        // 简洁形式
        var instance2 = new LearnSolution();
        // since c# 9.0
        LearnSolution instance1 = new();
    }
}