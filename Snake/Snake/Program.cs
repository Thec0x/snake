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
            Point p = new Point(20, 7, '$');

            //p.Draw();

            int x = 1;
            Funx(x);
            Console.WriteLine("x = {0} ", x);

            
            Console.ReadKey();
        }

        static void Funx(int x)
        {
            x += 1;
        }

    }
}
