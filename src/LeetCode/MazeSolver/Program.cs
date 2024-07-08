// See https://aka.ms/new-console-template for more information
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
var path = solver.Solve(maze2, '#', new Point(0,10), new Point(5, 1));

foreach (var item in path)
{
	Console.WriteLine($"X: {item.X}, Y: {item.Y}");
}

Console.ReadKey();

public class MazeSolver
{
	int[][] dir =
	[
		[-1,0],
		[1,0],
		[0,-1],
		[0,1]
	];

	public bool Walk(string[] maze, char wall, Point current, Point end, bool[][] seen, Stack<Point> path)
	{
		// off the maze
		if(current.X < 0 || current.X >= maze.Length ||
			current.Y < 0 || current.Y >= maze[0].Length)
		{
			return false;
		}

		// hit a wall
		if (maze[current.X][current.Y] == wall)
		{
			return false;
		}

		// found end point
		if(current.X == end.X && current.Y == end.Y)
		{
			path.Push(end);
			return true;
		}

		// seen before
		if (seen[current.X][current.Y])
		{
			return false;
		}


		// pre, recurse, post

		// pre
		seen[current.X][current.Y] = true;
		path.Push(current);

		// recurse
		for (int i = 0; i < dir.Length; i++)
		{
			var currDir = dir[i];
			var newCurrent = new Point
			{
				X = current.X + currDir[0],
				Y = current.Y + currDir[1]
			};

			if(Walk(maze, wall, newCurrent, end, seen, path))
			{
				return true;
			}
		}

		// post
		path.Pop();
		return false;
	}

	public Point[] Solve(string[] maze, char wall, Point start, Point end)
	{
		bool[][] seen = new bool[maze.Length][];
		for (int i = 0;i < maze.Length;i++)
		{
			seen[i] = new bool[maze[i].Length];
		}

		Stack<Point> path = new Stack<Point>();
		

		Walk(maze, wall, start , end, seen, path);

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