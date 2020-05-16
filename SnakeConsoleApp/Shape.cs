using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp
{
	public class Shape
	{
		protected List<Point> _points;

		public void DrawLine()
		{
			foreach (var point in _points)
			{
				point.DrawPoint();
			}
		}
	}
}
