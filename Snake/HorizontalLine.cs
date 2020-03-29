using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        /// <summary>
        /// Отрисовка горизонтальной линии
        /// </summary>
        /// <param name="xLeft">Крайняя левая точка</param>
        /// <param name="xReight">Крайняя правая точка</param>
        /// <param name="y">Координата Y</param>
        /// <param name="sym">Символ</param>
        public HorizontalLine(int xLeft, int xReight, int y, char sym)
        {
            plist = new List<Point>();
            for(int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                plist.Add(p);
            }

        }
    }
}
