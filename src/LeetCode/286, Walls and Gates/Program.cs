// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var graph = new int[][]
{
	[int.MaxValue, -1,			 0,            int.MaxValue],
	[int.MaxValue, int.MaxValue, int.MaxValue, -1		   ],
	[int.MaxValue, -1,           int.MaxValue, -1		   ],
	[0			 , -1,           int.MaxValue, int.MaxValue]
};

var sol = new Solution();
sol.WallsAndGates(graph);

for (int i = 0; i < graph.Length; i++)
{
	Console.WriteLine(string.Join(",", graph[i]));
}

public class Solution
{
	int[][] dir = [
		[1,0],
		[0,1],
		[-1,0],
		[0,-1]
	];

	public void WallsAndGates(int[][] rooms)
	{
		var queue = new Queue<(int x, int y)>();
		var visited = new HashSet<(int x, int y)>();
		var rows = rooms.Length;
		var columns = rooms[0].Length;

		for (int r = 0; r < rows; r++)
		{
			for (int c = 0; c < columns; c++)
			{
				if (rooms[r][c] == 0)
				{
					queue.Enqueue((r, c));
					visited.Add((r, c));
				}
			}
		}

		int distance = 0;

		while (queue.Count > 0)
		{
			var count = queue.Count;
			for (int i = 0; i < count; i++)
			{
				var point = queue.Dequeue();
				rooms[point.x][point.y] = distance;
				for (int d = 0; d < dir.Length; d++)
				{
					var newX = point.x + dir[d][0];
					var newY = point.y + dir[d][1];
					AddRoom((newX, newY));
				}
			}

			distance++;
		}

		void AddRoom((int x, int y) value)
		{

			if (value.x < 0 || value.y < 0 ||
				value.x >= rows || value.y >= columns
				|| rooms[value.x][value.y] == -1
				|| visited.Contains(value)) return;
			queue.Enqueue(value);
			visited.Add(value);
		}
	}

	
}

