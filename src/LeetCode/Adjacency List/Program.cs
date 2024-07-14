// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

/*
 export const list1: WeightedAdjacencyList = [];

//      (1) --- (4) ---- (5)
//    /  |       |       /|
// (0)   | ------|------- |
//    \  |/      |        |
//      (2) --- (3) ---- (6)
list1[0] = [
    { to: 1, weight: 3 },
    { to: 2, weight: 1 },
];
list1[1] = [
    { to: 0, weight: 3 },
    { to: 2, weight: 4 },
    { to: 4, weight: 1 },
];
list1[2] = [
    { to: 1, weight: 4 },
    { to: 3, weight: 7 },
    { to: 0, weight: 1 },
];
list1[3] = [
    { to: 2, weight: 7 },
    { to: 4, weight: 5 },
    { to: 6, weight: 1 },
];
list1[4] = [
    { to: 1, weight: 1 },
    { to: 3, weight: 5 },
    { to: 5, weight: 2 },
];
list1[5] = [
    { to: 6, weight: 1 },
    { to: 4, weight: 2 },
    { to: 2, weight: 18 },
];
list1[6] = [
    { to: 3, weight: 1 },
    { to: 5, weight: 1 },
];

export const list2: WeightedAdjacencyList = [];

//     >(1)<--->(4) ---->(5)
//    /          |       /|
// (0)     ------|------- |
//    \   v      v        v
//     >(2) --> (3) <----(6)
list2[0] = [
    { to: 1, weight: 3 },
    { to: 2, weight: 1 },
];
list2[1] = [
    { to: 4, weight: 1 },
];
list2[2] = [
    { to: 3, weight: 7 },
];
list2[3] = [ ];
list2[4] = [
    { to: 1, weight: 1 },
    { to: 3, weight: 5 },
    { to: 5, weight: 2 },
];
list2[5] = [
    { to: 2, weight: 18 },
    { to: 6, weight: 1 },
];
list2[6] = [
    { to: 3, weight: 1 },
];
 */

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
new GraphNode{ To= 1, Weight= 4 },
	new GraphNode{ To= 3, Weight= 7 },
	new GraphNode{ To= 0, Weight= 1 },
]);
//3
list1.Add([new GraphNode { To = 2, Weight = 7 },
	new GraphNode { To = 4, Weight = 5 },
	new GraphNode { To = 6, Weight = 1 }]);
// 4
list1.Add([
	new GraphNode{ To= 1, Weight= 1 },
    new GraphNode{ To= 3, Weight= 5 },
	new GraphNode{ To= 5, Weight= 2 },
	]);
//5
list1.Add([
	new GraphNode{ To= 6, Weight= 1 },
    new GraphNode{ To= 4, Weight= 2 },
	new GraphNode{ To= 2, Weight= 18 },
	]);
// 6
list1.Add([
	new GraphNode { To= 3, Weight= 1 },
	new GraphNode { To= 5, Weight= 1 },
	]);



var list2 = new List<GraphNode[]>();
// 0
list2.Add([
	new GraphNode{ To= 1, Weight= 3 },
	new GraphNode{ To= 2, Weight= 1 },
	]);
// 1 
list2.Add([
	new GraphNode { To= 4, Weight= 1 },
]);
// 2
list2.Add([
new GraphNode { To= 3, Weight= 7 },]);
// 3
list2.Add([]);
// 4
list2.Add([
	new GraphNode{ To= 1, Weight= 1 },
    new GraphNode{ To= 3, Weight= 5 },
	new GraphNode{ To= 5, Weight= 2 },
	]);
// 5
list2.Add([
	new GraphNode{ To= 2, Weight= 18 },
	new GraphNode{ To= 6, Weight= 1 },
	]);
// 6
list2.Add([
	new GraphNode { To= 3, Weight= 1 },
	]);

var solution = new Solution();
Console.WriteLine(string.Join(",", solution.GraphDFS(list2, 0, 6)));

public class Solution
{
	private bool Walk(List<GraphNode[]> graph, int current, int needle, bool[] seen, Stack<int> path)
	{
		if (seen[current]) {
			return false;
		}

		seen[current] = true;


		path.Push(current);

		if (current == needle)
		{
			return true;
		}

		var lst = graph[current];

		for(int i = 0;i<lst.Length; i++)
		{
			var edge = lst[i];
			if(Walk(graph, edge.To, needle, seen, path))
			{
				return true;
			}
		}

		path.Pop();

		return false;
	}

	public int[] GraphDFS(List<GraphNode[]> graph, int source, int needle)
	{
		var path = new Stack<int>();
		var seen = new bool[graph.Count];
		Walk(graph, source, needle, seen, path);

		return path.Reverse().ToArray();
	}
}

public class GraphNode
{
    public int To { get; set; }

    public int Weight { get; set; }
}