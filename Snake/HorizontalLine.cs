using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> plist;

        public HorizontalLine()
        {
            plist = new List<Point>();
            Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
        }

        public void Draw()
        {
            foreach(Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
