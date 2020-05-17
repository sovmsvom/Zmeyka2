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

		public bool Collision(Shape shape)
		{
			foreach (var item in _points)
			{
				if (shape.ComparePoints(item))
					return true;
			}
			return false;
		}

		private bool ComparePoints(Point point)
		{
			foreach (var item in _points)
			{
				if (point.ComparePoints(item))
					return true;
			}
			return false;
		}
	}
}
