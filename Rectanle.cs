using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Rectangle : Point
    {
        int _length, _width;
        public Rectangle(int length, int width)
        {
            _length = length;
            _width = width;
        }
        public  int CalculateArea()
        {
            int s = _length * _width;
            return s;
        }
    }
}
