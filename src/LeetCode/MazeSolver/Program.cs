// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
var maze = new string[]
	{
		"##### #",
		"#     #",
		"# #####"
	};

var maze2 = new string[]
	{
		"xxxxxxxxxx x",
		"x        x x",
		"x        x x",
		"x xxxxxxxx x",
		"x          x",
		"x xxxxxxxxxx",
	};

var solver = new MazeSolver();
//var path = solver.Solve(maze, '#', new Point(2, 1), new Point(0, 5));
var path = solver.Solve(maze2, 'x', new Point(0,10), new Point(5, 1));

foreach (var item in path)
{
	Console.WriteLine($"X: {item.X}, Y: {item.Y}");
}

Console.ReadKey();

public class MazeSolver()
{
	int[][] dir = new int[][]
	{
		[0,1],
		[0,-1],
		[1,0],
		[-1,0]
	};

	public bool Walk(string[] maze, char wall, Point current, Point end, Stack<Point> path, bool[][] visitied)
	{
		if(current.X < 0 || current.Y < 0 || current.X >= maze.Length || current.Y >= maze[0].Length)
		{
			return false;
		}

		if (visitied[current.X][current.Y])
		{
			return false;
		}

		if (maze[current.X][current.Y] == wall)
		{
			return false;
		}

		if(current.X == end.X && current.Y == current.Y)
		{
			path.Push(current);
			return true;
		}

		path.Push(current);
		visitied[current.X][current.Y] = true;

		for (int i = 0; i < dir.Length; i++)
		{
			var next = new Point
			{
				X = current.X + dir[i][0],
				Y = current.Y + dir[i][1]
			};

			if(Walk(maze,wall, next, end, path, visitied))
			{
				return true;
			}
		}
		
		path.Pop();
		return false;
	}

	public Point[] Solve(string[] maze, char wall, Point start, Point end)
	{
		var visited = new bool[maze.Length][];
		for (int i = 0; i < maze.Length; i++)
		{
			visited[i] = new bool[maze[0].Length];
		}

		var path = new Stack<Point>();
		Walk(maze, wall, start, end, path, visited);

		return path.ToArray();
	}
}

public class Point
{
    public Point()
    {
        
    }

    public Point(int x, int y)
    {
		X = x;
		Y = y;
    }
    public int X { get; set; }

    public int Y { get; set; }
}