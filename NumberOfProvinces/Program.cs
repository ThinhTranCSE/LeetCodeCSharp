namespace NumberOfProvinces;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] isConnected = new int[][]
        {
            new int[] { 1, 1, 0 },
            new int[] { 1, 1, 0 },
            new int[] { 0, 0, 1 }
        };
        int result = solution.FindCircleNum(isConnected);
        Console.WriteLine(result);
    }
}

public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        var visited = new HashSet<int>();
        int result = 0;
        for (int city = 0; city < isConnected.Length; city++)
        {
            if (visited.Contains(city))
            {
                continue;
            }
            var stack = new Stack<int>();
            stack.Push(city);
            while (stack.Count > 0)
            {
                int visitingCity = stack.Pop();
                if (visited.Contains(visitingCity))
                {
                    continue;
                }
                visited.Add(visitingCity);
                var isConnectedCities = isConnected[visitingCity];
                for (int isConnectedCity = 0; isConnectedCity < isConnectedCities.Length; isConnectedCity++)
                {
                    if (isConnectedCities[isConnectedCity] == 1)
                    {
                        stack.Push(isConnectedCity);
                    }
                }
            }
            result++;
        }
        return result;
    }
}