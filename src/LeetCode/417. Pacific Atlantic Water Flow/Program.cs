// See https://aka.ms/new-console-template for more information

int[][] heights = [
	[1, 2, 2, 3, 5], 
	[3, 2, 3, 4, 4], 
	[2, 4, 5, 3, 1], 
	[6, 7, 1, 4, 5], 
	[5, 1, 1, 2, 4]];

var sol = new Solution();
var result = sol.PacificAtlantic(heights);

for (int i = 0; i < result.Count; i++)
{
	Console.WriteLine(string.Join(",", result[i]));
}

public class Solution
{
	public IList<IList<int>> PacificAtlantic(int[][] heights)
	{
		var result = new List<IList<int>>();

		int rows = heights.Length;
		int cols = heights[0].Length;

		var pacificFlow = new HashSet<(int x, int y)>();
		var atlanticFlow = new HashSet<(int x, int y)>();


		for (int i = 0; i < cols; i++)
		{
			bfs(0, i, pacificFlow, heights[0][i]);
			bfs(rows-1, i, atlanticFlow, heights[rows - 1][i]);
		}

		for (int i = 0; i < rows; i++)
		{
			bfs(i, 0, pacificFlow, heights[i][0]);
			bfs(i, cols-1, atlanticFlow, heights[i][cols - 1]);
		}

		void bfs(int x, int y, HashSet<(int x, int y)> points, int previousHeight)
		{
			if (x < 0 || y < 0 ||
				x >= rows || y >= cols ||
				points.Contains((x, y)) ||
				heights[x][y] < previousHeight
				) return;

			points.Add((x, y));
			bfs(x + 1, y, points, heights[x][y]);
			bfs(x - 1, y, points, heights[x][y]);
			bfs(x, y + 1, points, heights[x][y]);
			bfs(x, y - 1, points, heights[x][y]);
		}

		foreach ((int x, int y) point in atlanticFlow)
		{
			if(pacificFlow.Contains(point))
			{
				result.Add(new List<int> { point.x, point.y });
			}
		}

		return result;
	}
}
