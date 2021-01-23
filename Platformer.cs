namespace TestDome
{
	using System.Collections.Generic;
	using System.Linq;
	using System;

	public sealed class Platformer
	{
		private readonly List<int> _tiles;
		private int _currPos;

		public Platformer(int numberOfTiles, int position)
		{
			_tiles = new List<int>(numberOfTiles);
			_currPos = position;
			_tiles.AddRange(Enumerable.Range(0, numberOfTiles));
		}

		public void JumpLeft()
		{
			_tiles.RemoveAt(_currPos);
			_currPos -= 2;
		}

		public void JumpRight()
		{
			_tiles.RemoveAt(_currPos);
			_currPos += 1;
		}

		public int Position()
		{
			return _tiles[_currPos];
		}

		public static void Main(string[] args)
		{
			Platformer platformer = new Platformer(6, 3);
			Console.WriteLine(platformer.Position()); // should print 3

			platformer.JumpLeft();
			Console.WriteLine(platformer.Position()); // should print 1

			platformer.JumpRight();
			Console.WriteLine(platformer.Position()); // should print 4
		}
	}
}