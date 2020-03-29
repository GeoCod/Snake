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
            Console.CursorVisible = false;  // убрать отображение курсора
            //Console.SetBufferSize(81, 26);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            // Отрисовка еды
            FoodCreator foodCreator = new FoodCreator(80, 26, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if( walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
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

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}