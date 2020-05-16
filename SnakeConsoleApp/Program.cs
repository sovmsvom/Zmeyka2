using SnakeConsoleApp.Enums;
using SnakeConsoleApp.Factory;
using SnakeConsoleApp.Helpers;
using SnakeConsoleApp.Installers;
using SnakeConsoleApp.Lines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			LineInstaller line = new LineInstaller();
			line.DrawShapes();

			Point food = FoodFactory.GetRandomFood(119, 20, '+');
			Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
			food.DrawPoint();
			Console.ResetColor();

			Snake snake = new Snake();
			snake.CreateSnake(5, new Point(5, 5, 'z'), DirectionEnum.Right);
			snake.DrawLine();

			while(true)
			{
				if (snake.Eat(food))
				{
					food = FoodFactory.GetRandomFood(119, 20, '+');
					Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
					food.DrawPoint();
					Console.ResetColor();
				}

				Thread.Sleep(100);
				snake.Move();

				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.PressKey(key.Key);
				}
			}

			//ConsoleKeyInfo key = Console.ReadKey();
			//Console.WriteLine(key.Key);

		}
	}
}
