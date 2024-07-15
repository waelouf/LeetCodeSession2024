// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var list1 = new List<GraphNode[]>();

// 0
list1.Add(new GraphNode[] {
	new GraphNode{ To= 1, Weight= 3 },
	new GraphNode{ To= 2, Weight= 1 },
});
//1 
list1.Add(new GraphNode[] {
	new GraphNode{ To= 0, Weight= 3 },
	new GraphNode{ To= 2, Weight= 4 },
	new GraphNode{ To= 4, Weight= 1 },
});
//2
list1.Add([
new GraphNode { To = 1, Weight = 4 },
	new GraphNode { To = 3, Weight = 7 },
	new GraphNode { To = 0, Weight = 1 },
]);
//3
list1.Add([new GraphNode { To = 2, Weight = 7 },
	new GraphNode { To = 4, Weight = 5 },
	new GraphNode { To = 6, Weight = 1 }]);
// 4
list1.Add([
	new GraphNode { To = 1, Weight = 1 },
	new GraphNode { To = 3, Weight = 5 },
	new GraphNode { To = 5, Weight = 2 },
]);
//5
list1.Add([
	new GraphNode { To = 6, Weight = 1 },
	new GraphNode { To = 4, Weight = 2 },
	new GraphNode { To = 2, Weight = 18 },
]);
// 6
list1.Add([
	new GraphNode { To = 3, Weight = 1 },
	new GraphNode { To = 5, Weight = 1 },
]);

var solution = new Solution();

Console.WriteLine(string.Join(",", solution.Dijkstra(list1, 0, 6)));


public class Solution
{
	public int[] Dijkstra(List<GraphNode[]> graph, int source, int sink)
	{
		var seen = new bool[graph.Count];
		var distances = Enumerable.Repeat(int.MaxValue, graph.Count).ToArray();
		var previous = Enumerable.Repeat(-1, graph.Count).ToArray();

		distances[source] = 0;

		while(HasUnvisited(seen, distances))
		{
			var current = GetLowestUnvisited(seen, distances);
			seen[current] = true;

			var adjaceensies = graph[current];

			for (int i = 0; i < adjaceensies.Length; i++)
			{
				var edge = adjaceensies[i];
				if (seen[edge.To])
				{
					continue;
				}

				var dist = distances[current] + edge.Weight;
				if(dist < distances[edge.To])
				{
					distances[edge.To] = dist;
					previous[edge.To] = current;
				}
			}
		}

		var path = new Stack<int>();
		var curr = sink;

		while (previous[curr] != -1)
		{
			path.Push(curr);
			curr = previous[curr];
		}

		path.Push(source);
		return path.ToArray();

	}

	private bool HasUnvisited(bool[] seen, int[] distances)
	{
		bool hasUnvisited = false;

		for (int i = 0; i < seen.Length; i++)
		{
			if (!seen[i] && distances[i] < int.MaxValue)
			{
				hasUnvisited =  true;
				break;
			}
		}

		return hasUnvisited;
	}

	private int GetLowestUnvisited(bool[] seen, int[] distances)
	{
		int index = -1;
		int lowestDistance = int.MaxValue;

		for (int i = 0; i < seen.Length; i++)
		{
			if (seen[i])
				continue;

			if(lowestDistance > distances[i])
			{
				lowestDistance = distances[i];
				index = i;
			}
		}

		return index;
	}

	
}

public class GraphNode
{
	public int To { get; set; }

	public int Weight { get; set; }
}