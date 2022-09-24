using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Rectangle
    {
        private double _width;
        private double _height;

        public Rectangle(double width, double height)
        {
            this._width = width;
            this._height = height;
        }

        private double AreaCalculator() => _width * _height;
        private double PerimeterCalculator() => 2 * (_width + _height);

        public double Area => AreaCalculator();
        public double Perimeter => PerimeterCalculator();
    }
}
