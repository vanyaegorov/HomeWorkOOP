using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Figure
    {
        string _color;
        bool _visibility;
        int _x, _y;

        public Figure()
        {

        }

        public void HorizontalMovement(int x)
        {
            _x = _x + x;
        }
        public void VerticalMovement(int y)
        {
            _y = _y + y;
        }
        public void ColorChange(string color)
        {
            _color = color;
        }
        public void VisibilityChange(bool visibility)
        {
            _visibility = visibility;
        }
        public void GetState()
        {
            Console.WriteLine("Цвет:{0}",_color);
            Console.WriteLine("Видимость:{0}",_visibility);
            Console.WriteLine("Координата Х:{0}", _x);
            Console.WriteLine("Координата У:{0}", _y);
        }
    }
}
