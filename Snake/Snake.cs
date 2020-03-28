using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            plist = new List<Point>();
            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);  //добавить конструктор
                p.Move(i, direction);       //добавить метод
                plist.Add(p);
            }
        }
    }
}
