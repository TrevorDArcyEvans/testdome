namespace TestDome
{
	using System;
	using System.Collections.Generic;

	public sealed class WeightedAverage
	{
		public static double Mean(IList<int> numbers, IList<int> weights)
		{
			if (numbers == null || weights == null)
			{
				throw new ArgumentException("null parameter");
			}

			if (numbers.Count != weights.Count)
			{
				throw new ArgumentException("length mismatch");
			}

			long total = 0;
			long totalWeights = 0;
			for (var i = 0; i < numbers.Count; i++)
			{
				total += numbers[i] * weights[i];
				totalWeights += weights[i];
			}

			return total / (double)totalWeights;
		}

#if false
		public static void Main(string[] args)
		{
			var values = new[] { 3, 6 };
			var weights = new[] { 4, 2 };

			Console.WriteLine(WeightedAverage.Mean(values, weights));
		}
#endif
	}
}
