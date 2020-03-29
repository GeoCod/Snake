using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /// <summary>
    /// Базовый класс фигуры
    /// </summary>
    class Figure
    {
        protected List<Point> plist;
        
        /// <summary>
        /// Отрисовка объектов класса
        /// </summary>
        public virtual void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach(var p in plist)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        internal bool IsHit( Point point)
        {
            foreach(var p in plist)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
