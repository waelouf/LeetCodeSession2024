// See https://aka.ms/new-console-template for more information

int[] candidates = [10, 1, 2, 7, 6, 1, 5];
var target = 8;

var solution = new Solution();
var results = solution.CombinationSum2(candidates, target);

for (int i = 0; i < results.Count; i++)
{
	Console.WriteLine(string.Join(", ", results[i]));
}


public class Solution
{
	public IList<IList<int>> CombinationSum2(int[] candidates, int target)
	{
		var candidatesLst = candidates.ToList();
		candidatesLst.Sort();

		var result = new List<IList<int>>();

		Backtrack(0, new Stack<int>(), target);

		void Backtrack(int pos, Stack<int> current, int currTarget)
		{
			if(currTarget == 0)
			{
				var lst = new int[current.Count];
				current.CopyTo(lst, 0);
				result.Add(lst);
				return;
			}

			if (currTarget < 0) return;
			if(pos >=  candidatesLst.Count) return;

			int previous = -1;
			for (int i = pos; i < candidatesLst.Count; i++)
			{
				if (candidatesLst[i] == previous) continue;

				current.Push(candidatesLst[i]);
				Backtrack(i + 1, current, currTarget - candidatesLst[i]);
				current.Pop();

				previous = candidatesLst[i];
			}
		}


		return result;
	}
}