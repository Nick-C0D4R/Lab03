using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    internal class Program
    {
        static void ThrowExeption()
        {
            throw new ArgumentException("Параметр не відповідає умовам");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            double width, height;
            Console.WriteLine("Введіть ширину");
            if(!double.TryParse(Console.ReadLine(), out width) || width < 0)
            {
                ThrowExeption();
            }
            Console.WriteLine("Введіть висоту");
            if(!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                ThrowExeption();
            }

            Rectangle rectangle = new Rectangle(width, height);

            Console.WriteLine($"Площа: {rectangle.Area}");
            Console.WriteLine($"Периметр: {rectangle.Perimeter}");
        }
    }
}
