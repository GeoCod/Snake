using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 26);
            Console.SetWindowSize(80, 26);

            // Отрисовка рамки
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine buttomLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            topLine.Draw();
            buttomLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Console.CursorVisible = false;  // убрать отображение курсора

            // Отрисовка еды
            FoodCreator foodCreator = new FoodCreator(80, 26, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                    snake.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // true - что бы не исчезали символы рамки слева 
                    snake.HandleKey(key.Key);
                }
            }
        }
    }
}