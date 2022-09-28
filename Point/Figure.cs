using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    public class Figure
    {
        private Point _a;
        private Point _b;
        private Point _c;

        public Figure(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public double LengthSide(Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2)); ;
        }
        
        public double PerimeterCalculator()
        {
            return LengthSide(_a, _b) + LengthSide(_a, _c) + LengthSide(_b, _c);
        }
    }
}
