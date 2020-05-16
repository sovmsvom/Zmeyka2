using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp.Factory
{
	public static class FoodFactory
	{
		private static Random _random = new Random();
		public static Point GetRandomFood(int spaceWidth, int spaceHeight, char symbol)
		{
			spaceWidth = _random.Next(2, spaceWidth - 2);
			spaceHeight = _random.Next(2, spaceHeight - 2);

			return new Point(spaceWidth, spaceHeight, symbol);
		}
	}
}
