namespace ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] board = new char[][]
            {
                new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
                new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
                new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
                new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
                new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
                new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
                new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
                new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
                new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
            };

            Solution solution = new Solution();

            bool isValid = solution.IsValidSudoku(board);

            System.Console.WriteLine(isValid);
        }
    }

    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            return IsValidRows(board) && IsValidColumns(board) && IsValidSquares(board);
        }

        public bool IsValidRows(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                var presented = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }

                    if (!presented.Add(board[i][j]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsValidColumns(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                var presented = new HashSet<char>();
                for (int j = 0; j < 9; j++)
                {
                    if (board[j][i] == '.')
                    {
                        continue;
                    }
                    if (!presented.Add(board[j][i]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsValidSquares(char[][] board)
        {
            for (int xOffset = 0; xOffset < 3; xOffset++)
            {
                for (int yOffset = 0; yOffset < 3; yOffset++)
                {
                    var presented = new HashSet<char>();
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (board[i + xOffset * 3][j + yOffset * 3] == '.')
                            {
                                continue;
                            }

                            if (!presented.Add(board[i + xOffset * 3][j + yOffset * 3]))
                            {
                                return false;
                            }
                        }
                    }
                }
            }

            return true;
        }
    }
}
