using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            //Point p = new Point(20, 7, '$');

            //p.Draw();


            HorizontalLine h1Line = new HorizontalLine(0, 78, 0, '#');
            h1Line.Draw();

            VerticalLine v1Line = new VerticalLine(0, 24, 0, '#');
            v1Line.Draw();

            HorizontalLine h2Line = new HorizontalLine(0, 78, 24, '#');
            h2Line.Draw();

            VerticalLine v2Line = new VerticalLine(0, 24, 78, '#');
            v2Line.Draw();

            Point p = new Point(20, 7, '$');
            //p.Draw();
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);
            snake.Move();
            System.Threading.Thread.Sleep(300);



            Console.ReadKey();
        }
    }
}
