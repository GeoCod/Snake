using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        /// <summary>
        /// Направление движения змейки
        /// </summary>
        Direction direction;

        /// <summary>
        /// Создание змейки с параметрами
        /// </summary>
        /// <param name="tail">Начальное положение точки</param>
        /// <param name="lenght">Длина змейки</param>
        /// <param name="_direction">Направление движения</param>
        public Snake(Point tail, int lenght, Direction _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, _direction);
                plist.Add(p);
            }
        }

        /// <summary>
        /// Проверка на столкновение головы с телом змейки
        /// </summary>
        /// <returns></returns>
        internal bool IsHitTail()
        {
            var head = plist.Last();
            for(int i = 0; i < plist.Count - 2; i++)
            {
                if (head.IsHit(plist[i]))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Поточечная перерисовка головы и хвоста змейки
        /// </summary>
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();   // Замена последней точки (хвост змейки) на пробел
            head.Draw();    // отрисовка гооловы
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if(head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Получение следующей точки головы змейки
        /// </summary>
        /// <returns>Новая точка головы змейки</returns>
        public Point GetNextPoint()
        {
            Point head = plist.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        /// <summary>
        /// Смена направления движения
        /// </summary>
        /// <param name="key">Направление из списка</param>
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
        }
    }
}
