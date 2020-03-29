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

            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            //Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT);
            //Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');
            //Draw(h1);

            List<Figure> figures = new List<Figure>();
            figures.Add(v1);
            figures.Add(h1);
            figures.Add(fSnake);

            foreach (var f in figures)
            {
                f.Draw();
            }

            /*
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
            }*/
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}