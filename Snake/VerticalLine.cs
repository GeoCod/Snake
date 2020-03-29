using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        /// <summary>
        /// Отрисовка вертикальной линии
        /// </summary>
        /// <param name="yTop">Крайняя верхняя точка</param>
        /// <param name="yButtom">Крайняя нижняя точка</param>
        /// <param name="x">Координата X</param>
        /// <param name="sym">Символ</param>
        public VerticalLine(int yTop, int yButtom, int x, char sym)
        {
            plist = new List<Point>();
            for(int y = yTop; y <= yButtom; y++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }
        }
    }
}
