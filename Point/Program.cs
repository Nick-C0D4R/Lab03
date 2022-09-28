using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point(1, 1, "A"), new Point(4, 1, "B"), new Point(4, 5, "C"));
            Console.WriteLine(figure.PerimeterCalculator());
        }
    }
}
