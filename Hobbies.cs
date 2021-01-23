namespace TestDome
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public sealed class Hobbies
	{
		private readonly Dictionary<string, string[]> _hobbies = new Dictionary<string, string[]>();

		public void Add(string hobbyist, params string[] hobbies)
		{
			_hobbies.Add(hobbyist, hobbies);
		}

		public List<string> FindAllHobbyists(string hobby)
		{
			return (from kvp in _hobbies where kvp.Value.Contains(hobby) select kvp.Key).ToList();
		}

#if false
		public static void Main(string[] args)
		{
			var hobbies = new Hobbies();
			hobbies.Add("Steve", "Fashion", "Piano", "Reading");
			hobbies.Add("Patty", "Drama", "Magic", "Pets");
			hobbies.Add("Chad", "Puzzles", "Pets", "Yoga");

			hobbies.FindAllHobbyists("Yoga").ForEach(Console.WriteLine);
		}
#endif
	}
}
