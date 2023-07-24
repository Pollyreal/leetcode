public partial class GraphSolution
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        if (!wordList.Contains(endWord))
        {
            return 0;
        }
        wordList.Add(beginWord);
        // 生成wordList的图，每个单词都是一个节点，如果两个单词只有一个字母不同，则两个单词之间有一条边
        var graph = new Dictionary<string, IList<string>>();
        foreach (var word in wordList)
        {
            graph[word] = new List<string>();
        }
        foreach (var word in wordList)
        {
            foreach (var otherWord in wordList)
            {
                if (IsConnected(word, otherWord))
                {
                    graph[word].Add(otherWord);
                }
            }
        }
        // BFS
        var queue = new Queue<string>();
        queue.Enqueue(beginWord);
        var visited = new HashSet<string>();
        visited.Add(beginWord);
        var level = 1;
        while (queue.Count > 0)
        {
            var size = queue.Count;
            for (var i = 0; i < size; i++)
            {
                var word = queue.Dequeue();
                if (word == endWord)
                {
                    return level;
                }
                foreach (var nextWord in graph[word])
                {
                    if (!visited.Contains(nextWord))
                    {
                        queue.Enqueue(nextWord);
                        visited.Add(nextWord);
                    }
                }
            }
            level++;
        }
        return 0;
    }

    private bool IsConnected(string word1, string word2)
    {
        var diff = 0;
        for (var i = 0; i < word1.Length; i++)
        {
            if (word1[i] != word2[i])
            {
                diff++;
            }
        }
        return diff == 1;
    }
}