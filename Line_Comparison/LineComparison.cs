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
        int A1;
        int A2;
        int B1;
        int B2;
        double Length_XY;
        double Length_AB;

        public void LineLength()
        {
            //Console.WriteLine("Enter X,Y Co_Ordinates of the Point 1: ");
            Console.WriteLine("Enter X,Y Co_Ordinates of the Line 1: ");
            Console.Write("Enter Value X1: ");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y1: ");
            Y1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter X,Y Co_Ordinates of the Poin 2: ");
            Console.Write("Enter Value X2: ");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value Y2: ");
            Y2 = Convert.ToInt32(Console.ReadLine());
            Length_XY = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));
            //Console.WriteLine("Length of Value is : " + Length_XY);
            Console.WriteLine("Line1 Value is :" + Length_XY);
            Console.WriteLine("==================================================================================");

            Console.WriteLine("Enter X,Y Co_Ordinates of the Line 2: ");
            Console.Write("Enter Value A1: ");
            A1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B1: ");
            B1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value A2: ");
            A2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Value B2: ");
            B2 = Convert.ToInt32(Console.ReadLine());
            Length_AB = Math.Sqrt(Math.Pow((A2 - A1), 2) + Math.Pow((B2 - B1), 2));
            //Console.WriteLine("Length of Value is : " + Length_AB);
            Console.WriteLine("Line2 Value is: " + Length_AB);
            Console.WriteLine("==================================================================================");
        }
        public void CompareTwoLines()
        {
            double result = Length_XY.CompareTo(Length_AB);
            if (result < 0)
            {
                //Console.WriteLine("Length of XY and Length of AB are Equals");
                Console.WriteLine("Line1: {0} IS LESS THEN Line2: {1} ", Length_XY, Length_AB);
            }
            else
            {
                //Console.WriteLine("Length of XY and Length of Ab are Not Equals");
                Console.WriteLine("Line1: {0} ARE EQUALS Line2: {1} ", Length_XY, Length_AB);
            }

        }
        
    }
}