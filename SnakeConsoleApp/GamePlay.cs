using SnakeConsoleApp.Enums;
using SnakeConsoleApp.Factory;
using SnakeConsoleApp.Helpers;
using SnakeConsoleApp.Installers;
using SnakeConsoleApp.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeConsoleApp
{
	public class GamePlay
	{
		UserService _userService = new UserService();
		public void StartGame(User user)
		{

			if (user == null)
				user = new User();

			int score = 0;

			LineInstaller line = new LineInstaller();
			line.DrawShapes();

			Point food = FoodFactory.GetRandomFood(119, 20, '+');
			Console.ForegroundColor = ColorHelper.GetRandomColor(new Random().Next(1, 5));
			food.DrawPoint();
			Console.ResetColor();

			Snake snake = new Snake();
			snake.CreateSnake(5, new Point(5, 5, 'z'), DirectionEnum.Right);
			snake.DrawLine();

			ScoreHelper.GetScore(score);

			while (true)
			{
				if (line.Collision(snake) || snake.CollisionWithOwnTail())
				{
					break;
				}

				if (snake.Eat(food))
				{
					score++;
					ScoreHelper.GetScore(score);

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

			user.Score = score;
			_userService.SaveScore(user);
		}
	}
}
