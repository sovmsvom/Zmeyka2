using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp.Lines
{
	public class HorizontalLine : Shape
	{
		public HorizontalLine(int left, int top, char symbol, int count)
		{
			_points = new List<Point>();

			for (int i = left; i < count; i++)
			{
				Point point = new Point(i, top, symbol);
				_points.Add(point);
			}
		}
	}
}
