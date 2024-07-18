// See https://aka.ms/new-console-template for more information
using System.Reflection;


var graph = new char[][]
{
	['1', '1', '1', '1', '0'],
	['1', '1', '0', '1', '0'],
	['1', '1', '0', '0', '0'],
	['0', '0', '0', '0', '1']
};

Console.WriteLine(new Solution().NumIslands(graph));

public class Solution
{
	int[][] dir =
	[
		[0,1],
		[1,0],
		[0,-1],
		[-1,0]
	];

	public int NumIslands(char[][] grid)
	{
		int numberOfIslans = 0;
		bool[][] seen = new bool[grid.Length][];
		for (int i = 0; i < grid.Length; i++)
		{
			seen[i] = new bool[grid[i].Length];
		}

		var rows = grid.Length;
		var cols = grid[0].Length;
		for (int r = 0; r < rows; r++)
		{
			for (int c = 0; c < cols; c++)
			{
				if (grid[r][c] == '1' && !seen[r][c])
				{
					numberOfIslans++;
					bfs(r, c);
				}
			}
		}

		//bfs(0, 0);

		void bfs(int x, int y)
		{
			if (x < 0 || y < 0 || 
				x >= grid.Length || y >= grid[0].Length || 
				seen[x][y] || 
				grid[x][y] == '0') return;
			
			seen[x][y] = true;


			for(int i = 0; i < dir.Length; i++)
			{
				var newX = x + dir[i][0];
				var newY = y + dir[i][1];
				bfs(newX, newY);
			}

		}

		return numberOfIslans;
	}
}

