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
    }
}
