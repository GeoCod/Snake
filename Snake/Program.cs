using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw( );

            Point p3 = new Point(10, 17, '!');

            Point p4 = new Point(13, 0, '&');


            //создаем спсиок и добавляем три целых значения
            List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            //получение значения из списка
            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            //перебор значений списка
            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }

            // удаляем из списка
            numlist.RemoveAt(0);

            List<Point> plist = new List<Point>();
            plist.Add(p1);
            plist.Add(p2);
            plist.Add(p3);
            plist.Add(p4);


            List<char> charList = new List<char>();
            charList.Add('!');
            charList.Add('%');
            charList.Add('^');
            charList.Add('@');
            charList.Add('[');

            char symTest = charList[3];

            Console.WriteLine(symTest);

            Console.ReadLine();
        }
    }
}