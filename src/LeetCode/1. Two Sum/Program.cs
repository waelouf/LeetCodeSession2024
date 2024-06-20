var sol = new Solution();

sol.TwoSum([2, 7, 11, 15], 9).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

sol.TwoSum([3, 2, 4], 6).
	ToList().ForEach(e => Console.WriteLine(e)); // 1,2

sol.TwoSum([3, 3], 6).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

sol.TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

Console.ReadKey();
