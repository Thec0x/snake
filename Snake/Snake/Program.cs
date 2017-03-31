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

            List<int> numList = new List<int>();
            numList.Add( 10 );
            numList.Add( 1 );
            numList.Add( 2 );

            List<Point> pList = new List<Point>();
            pList.Add(p);




            int x = numList[0];

            Console.WriteLine(x);

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }


            

            
            Console.ReadKey();
        }
    }
}
