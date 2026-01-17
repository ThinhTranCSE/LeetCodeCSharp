namespace NumberOfInslands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] grid = new char[][]
            {
              new char[] {'1', '1', '1', '1', '0'},
              new char[] {'1', '1', '0', '1', '0'},
              new char[] {'1', '1', '0', '0', '0'},
              new char[] {'0', '0', '0', '0', '0'}
            };

            var solution = new Solution();
            var result = solution.NumIslands(grid);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            int numIslands = 0;
            var traverseds = new HashSet<(int, int)>();
            for (int x = 0; x < grid.Length; x++)
            {
                for (int y = 0; y < grid[x].Length; y++)
                {
                    if (traverseds.Contains((x, y)) || !IsLand(grid, x, y))
                    {
                        continue;
                    }
                    numIslands++;
                    var stack = new Stack<(int, int)>();
                    stack.Push((x, y));
                    while (stack.Count > 0)
                    {
                        var (i, j) = stack.Pop();
                        traverseds.Add((i, j));
                        if (IsLand(grid, i - 1, j) && !traverseds.Contains((i - 1, j)))
                        {
                            stack.Push((i - 1, j));
                        }
                        if (IsLand(grid, i, j - 1) && !traverseds.Contains((i, j - 1)))
                        {
                            stack.Push((i, j - 1));
                        }
                        if (IsLand(grid, i + 1, j) && !traverseds.Contains((i + 1, j)))
                        {
                            stack.Push((i + 1, j));
                        }
                        if (IsLand(grid, i, j + 1) && !traverseds.Contains((i, j + 1)))
                        {
                            stack.Push((i, j + 1));
                        }
                    }
                }
            }
            return numIslands;
        }
        private bool IsLand(char[][] grid, int x, int y)
        {
            if (x < 0 || x >= grid.Length)
            {
                return false;
            }
            if (y < 0 || y >= grid[x].Length)
            {
                return false;
            }

            return grid[x][y] == '1';
        }
    }


    //public class Solution
    //{
    //    public int NumIslands(char[][] grid)
    //    {
    //        var lands = new HashSet<(int, int)>();
    //        for (int x = 0; x < grid.Length; x++)
    //        {
    //            for (int y = 0; y < grid[x].Length; y++)
    //            {
    //                if (IsLand(grid, x, y))
    //                {
    //                    lands.Add((x, y));
    //                }
    //            }
    //        }
    //        int numIslands = 0;
    //        for (int x = 0; x < grid.Length; x++)
    //        {
    //            for (int y = 0; y < grid[x].Length; y++)
    //            {
    //                if (!lands.Contains((x, y)))
    //                {
    //                    continue;
    //                }
    //                numIslands++;
    //                var stack = new Stack<(int, int)>();
    //                stack.Push((x, y));
    //                while (stack.Count > 0)
    //                {
    //                    var (i, j) = stack.Pop();
    //                    lands.Remove((i, j));
    //                    if (lands.Contains((i - 1, j)))
    //                    {
    //                        stack.Push((i - 1, j));
    //                    }
    //                    if (lands.Contains((i, j - 1)))
    //                    {
    //                        stack.Push((i, j - 1));
    //                    }
    //                    if (lands.Contains((i + 1, j)))
    //                    {
    //                        stack.Push((i + 1, j));
    //                    }
    //                    if (lands.Contains((i, j + 1)))
    //                    {
    //                        stack.Push((i, j + 1));
    //                    }
    //                }
    //            }
    //        }
    //        return numIslands;
    //    }
    //    private bool IsLand(char[][] grid, int x, int y)
    //    {
    //        if (x < 0 || x >= grid.Length)
    //        {
    //            return false;
    //        }
    //        if (y < 0 || y >= grid[x].Length)
    //        {
    //            return false;
    //        }

    //        return grid[x][y] == '1';
    //    }
    //}
}