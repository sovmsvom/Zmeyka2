using SnakeConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeConsoleApp
{
	public class Point
	{
		int _left;
		int _top;
		char _symbol;

		public char Symbol
		{
			get { return _symbol; }
			set { _symbol = value; }
		}


		public Point(Point snakeTail)
		{
			_left = snakeTail._left;
			_top = snakeTail._top;
			_symbol = snakeTail._symbol;
		}

		public Point(int left, int top, char symbol)
		{
			_left = left;
			_top = top;
			_symbol = symbol;
		}

		public void SetDirection(int i, DirectionEnum direction)
		{
			switch (direction)
			{
				case DirectionEnum.Right:
					_left = _left + i;
					break;
				case DirectionEnum.Left:
					_left = _left - i;
					break;
				case DirectionEnum.Up:
					_top = _top - i;
					break;
				case DirectionEnum.Down:
					_top = _top + i;
					break;
			}
		}

		public void ClearPoint()
		{
			_symbol = ' ';
			DrawPoint();
		}

		public void DrawPoint()
		{
			Console.SetCursorPosition(_left, _top);
			Console.Write(_symbol);
		}

		public bool ComparePoints(Point food)
		{
			return food._left == _left && food._top == _top;
		}
	}
}
