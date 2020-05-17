using SnakeConsoleApp.UI;
using SnakeConsoleApp.UserServices;
using System;

namespace SnakeConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			UIService uiService = new UIService();
			uiService.GetMenu();

			while (true)
			{
				ConsoleKeyInfo key = Console.ReadKey();
				uiService.GetCommand(key.Key);
			}
		}
	}
}
