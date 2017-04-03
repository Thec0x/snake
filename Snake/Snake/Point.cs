using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symbol;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }

        public Point(int _x, int _y, char _symbol)
        {
            x = _x;
            y = _y;
            symbol = _symbol;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
                x += offset;
            if (direction == Direction.LEFT)
                x -= offset;
            if (direction == Direction.UP)
                y += offset;
            if (direction == Direction.DOWN)
                y -= offset;
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }


    }
}
