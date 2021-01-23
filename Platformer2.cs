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
			_tiles[_currPos] = -1;
			var numMoves = 0;
			while (true)
			{
				_currPos--;
				if (_tiles[_currPos] != -1)
				{
					numMoves++;
				}

				if (numMoves == 2)
				{
					return;
				}
			}
		}

		public void JumpRight()
		{
			_tiles[_currPos] = -1;
			var numMoves = 0;
			while (true)
			{
				_currPos++;
				if (_tiles[_currPos] != -1)
				{
					numMoves++;
				}

				if (numMoves == 2)
				{
					return;
				}
			}
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