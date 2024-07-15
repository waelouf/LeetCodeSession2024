// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

var graph = new char[][]
{
	['1', '1', '1', '1', '0'],
	['1', '1', '0', '1', '0'],
	['1', '1', '0', '0', '0'],
	['0', '0', '0', '0', '0']
};

Console.WriteLine(new Solution().NumIslands(graph));

public class Solution
{
	int[][] directions = [
		[-1, 0],
		[1, 0],
		[0, 1],
		[0, -1]
		];

	public int NumIslands(char[][] grid)
	{
		if(grid.Count() == 0) return 0;	
		var rows = grid.Count();
		var cols = grid[0].Count();
		bool[][] visited = new bool[rows][];
		for (int i = 0; i < visited.Length; i++)
		{
			visited[i] = new bool[cols];
		}

		int islands = 0;

		for (int r = 0; r < rows; r++)
		{
			for (int c = 0; c < cols; c++)
			{
				if (grid[r][c] == '1' && !visited[r][c])
				{
					islands++;
					dfs(r, c);					
				}
			}
		}

		void dfs(int r, int c)
		{
			if (r >= rows || r < 0) return;
			if (c >= cols || c < 0) return;
			if (grid[r][c] == '0') return;
			if (visited[r][c]) return;

			visited[r][c] = true;

			for (int i = 0; i < directions.Length; i++)
			{
				int newRow = r + directions[i][0];
				int newCol = c + directions[i][1];
				dfs(newRow, newCol);
			}
		}
		return islands;
	}

	
}

//void bfs(int r, int c)
//{
//	var queue = new Queue<(int, int)>();
//	visited[r][c] = true;
//	queue.Enqueue((r, c));

//	while (queue.Count > 0)
//	{
//		(int row, int col) = queue.Dequeue();

//		for (int i = 0; i < directions.Length; i++)
//		{
//			var newRow = row + directions[i][0];
//			var newCol = col + directions[i][1];
//			if (newRow < rows && newRow >= 0 &&
//				newCol < cols && newCol >= 0 &&
//				grid[newRow][newCol] == '1' &&
//				!visited[newRow][newCol])
//			{
//				queue.Enqueue((newRow, newCol));
//				visited[newRow][newCol] = true;
//			}
//		}
//	}
//}