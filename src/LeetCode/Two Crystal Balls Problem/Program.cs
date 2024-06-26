
bool[] arr = [false, false, false, false, false, false, false, false, false, true];

var solution = new TwoCrystalBalls();

Console.Write(solution.Break(arr));
public class TwoCrystalBalls
{
	public int Break(bool[] breaks)
	{
		var increment = (int)Math.Floor(Math.Sqrt(breaks.Length));
		var searchStartIndex = 0;
		var currentInex = 0;
		int breakIndex = -1;

		while (currentInex < breaks.Length)
		{
			if (!breaks[currentInex])
			{
				searchStartIndex = currentInex;
				currentInex += increment;
			}
			else
			{
				for (int i = searchStartIndex; i <= currentInex; i++)
				{
					if (breaks[i])
					{
						return i;
					}
				}
			}
		}

		return breakIndex;
	}
}