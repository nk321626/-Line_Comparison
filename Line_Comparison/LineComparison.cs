using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comparison
{
    public class LineComparison
    {

        int X1;
        int Y1;
        int X2;
        int Y2;
        double Length_XY;
        public void LineLength()
        {
            Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            Console.Write("Enter Value X1: ");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y1: ");
            Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter X,Y Co_Ordinates of the Poin 2: ");
            Console.Write("Enter Value X2: ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y2: ");
            Y2 = Convert.ToInt32(Console.ReadLine());
            Length_XY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            Console.WriteLine("Length of Value is : " + Length_XY);
            Console.WriteLine("==================================================================================");

        }
        
    }
}