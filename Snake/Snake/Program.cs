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
            //Point p = new Point(20, 7, '$');

            //p.Draw();


            HorizontalLine hLine = new HorizontalLine(5, 10, 8, '+');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(0, 20, 0, '-');
            vLine.Draw();
            

            
            Console.ReadKey();
        }
    }
}
