// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
//     >(1)<--->(4) ---->(5)
//    /          |       /|
// (0)     ------|------- |
//    \   v      v        v
//     >(2) --> (3) <----(6)

export const matrix2: WeightedAdjacencyMatrix = [
    [0, 3, 1,  0, 0, 0, 0], // 0
    [0, 0, 0,  0, 1, 0, 0], // 1
    [0, 0, 7,  0, 0, 0, 0], // 2
    [0, 0, 0,  0, 0, 0, 0], // 3
    [0, 1, 0,  5, 0, 2, 0], // 4
    [0, 0, 18, 0, 0, 0, 1], // 5
    [0, 0, 0,  1, 0, 0, 1], // 6
]
 * 
 */

int[][] graph = new int[][]
{
	[0, 3, 1,  0, 0, 0, 0], // 0
    [0, 0, 0,  0, 1, 0, 0], // 1
    [0, 0, 0,  7, 0, 0, 0], // 2
    [0, 0, 0,  0, 0, 0, 0], // 3
    [0, 1, 0,  5, 0, 2, 0], // 4
    [0, 0, 18, 0, 0, 0, 1], // 5
    [0, 0, 0,  1, 0, 0, 1], // 6
};

int source = 0;
int needle = 3;

var solution = new AdjacencyMatrix();

Console.WriteLine(string.Join(",", solution.GraphBFS(graph, source, needle)));

public class AdjacencyMatrix
{
	public int[] GraphBFS(int[][] graph, int source, int needle)
	{
		var seen = new bool[graph.Length];
		var previous = new int[graph.Length];
		for (int i = 0; i < previous.Length; i++)
		{
			previous[i] = -1;
		}
		seen[source] = true;
		var q = new Queue<int>();
		q.Enqueue(source);

		do
		{
			var current = q.Dequeue();
			if(current == needle)
			{
				break;
			}

			var adjacencies = graph[current];
			for(int i=0; i < adjacencies.Length; i++)
			{
				if (adjacencies[i] == 0)
				{
					continue;
				}

				if (seen[i])
				{
					continue;
				}

				seen[i] = true;
				previous[i] = current;
				q.Enqueue(i);
			}
			
		}
		while (q.Count > 0);

		// build the path

		var curr = needle;


		var path = new List<int>();

		while (previous[curr] != -1)
		{
			path.Add(curr);
			curr = previous[curr];
		}

		if(path.Count > 0)
		{
			path.Add(source);
			path.Reverse();			
		}

		return path.ToArray();
	}
}