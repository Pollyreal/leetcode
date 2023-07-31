if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}
// Console.WriteLine(new DailyProblemSolution().CheckOverlap(1583, -829, -112, 700, -720, 918, -399));
// Console.WriteLine(new DailyProblemSolution().PivotInteger(1));
// Console.WriteLine(new DailyProblemSolution().MaximumSum(new int[] { 1, -4, -5, -2, 5, 0, -1, 2 }));
// Console.WriteLine(new DailyProblemSolution().Fib(2));
// var res = new DailyProblemSolution().ReconstructMatrix(5, 5, new int[] { 2, 1, 2, 0, 1, 0, 1, 2, 0, 1 });

// var res = new DailyProblemSolution().IsCircularSentence("I like Leetcode");
// Console.WriteLine(res);

// Console.WriteLine(await new LearnSolution().RetrieveDocsHomePage());
// Console.WriteLine(new LearnSolution().TestPatternMatch("Hello"));
// Console.WriteLine(new NumberAndPlaceValueSolution().Multiply("299999", "33"));
// Console.WriteLine(new HashTableSolution().LongestConsecutive(new int[] { 1, 2, 3, 4, 5 ,9}));
// Console.WriteLine(new GreedySolution().MaxProfit(new int []{1,2}));

var res = new BisectionSearchSolution().SearchRange(new int[] { 2, 2 }, 4);
Console.WriteLine("{0}-{1}", res[0], res[1]);