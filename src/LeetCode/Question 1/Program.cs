// See https://aka.ms/new-console-template for more information

var result = new Result();
var commands = new List<List<string>>();

commands.Add(new List<string> { "Insert", "Hello" });
commands.Add(new List<string> { "Left", "3" });
commands.Add(new List<string> { "Delete", "1" });
commands.Add(new List<string> { "Right", "2" });
commands.Add(new List<string> { "Backspace", "1" });
commands.Add(new List<string> { "Print", "4" });

var lst = result.getPrintedStrings(commands);

Console.WriteLine(string.Join(Environment.NewLine, lst));

class Result
{

	/*
     * Complete the 'getPrintedStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts 2D_STRING_ARRAY commands as parameter.
     */

	public List<string> getPrintedStrings(List<List<string>> commands)
	{
		var lst = new List<string>();

		var lstChar = new List<char>();
		int currentIndex = 0;

		foreach (var comm in commands)
		{
			commandParser(comm);
		}

		void commandParser(List<string> commandParts)
		{
			var command = commandParts[0];
			var value = commandParts[1];

			switch (command)
			{
				case "Insert":
					for (int i = 0; i < value.Length; i++)
					{
						lstChar.Insert(currentIndex, value[i]);
						currentIndex++;
					}
					break;
				case "Left":
					int val = int.Parse(value);
					currentIndex -= val;
					// validate index range
					break;
				case "Right":
					int val2 = int.Parse(value);
					currentIndex += val2;
					// validate index range
					break;
				case "Backspace":
					int val3 = int.Parse(value);
					lstChar.RemoveRange(currentIndex - val3, val3);
					break;
				case "Delete":
					int val4 = int.Parse(value);
					lstChar.RemoveRange(currentIndex + 1, val4);
					break;
				case "Print":
					int val5 = int.Parse(value);
					var copyStartIndex = Math.Max(0, currentIndex - val5);
					var copyEndIndex = Math.Min(lstChar.Count - 1, currentIndex + val5);
					var length = copyEndIndex - copyStartIndex;
					var tmpList = new char[length];
					lstChar.CopyTo(copyStartIndex, tmpList, 0, length);
					lst.Add(new string(tmpList));
					break;
				default:
					break;
			}
			Console.WriteLine(string.Join("", lstChar));
		}

		return lst;
	}

}

