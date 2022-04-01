using System;

namespace lesson5
{
    class ComplexNumbers
    {
        int _a, _b, _i;
        int Cn { get; set; }
        public ComplexNumbers(int a, int b, int i)
        {
            _a = a;
            _b = b;
            _i = i;
            Cn = a + b * i;
        }
        public ComplexNumbers(int cn)
        {
            cn = Cn;
        }
        public override string ToString()
        {
            if (Cn == 0)
            {
                Cn = _a + _b * _i;
                string s = Convert.ToString(Cn);
                return (s);
            }
            else
            {
                string s = Convert.ToString(Cn);
                return (s);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is ComplexNumbers numbers &&
                   _a == numbers._a &&
                   _b == numbers._b &&
                   _i == numbers._i &&
                   Cn == numbers.Cn;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_a, _b, _i, Cn);
        }

        public static ComplexNumbers operator +(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._i != cn2._i)
            {

                throw new Exception();
            }
            else
            {
                int cn = (cn1._a + cn2._a) + (cn1._b + cn2._b) * cn1._i;
                return new ComplexNumbers(cn);
            }

        }
        public static ComplexNumbers operator -(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._i != cn2._i)
            {

                throw new Exception();
            }
            else
            {
                int cn = (cn1._a - cn2._a) + (cn1._b - cn2._b) * cn1._i;
                return new ComplexNumbers(cn);
            }

        }
        public static ComplexNumbers operator *(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._i != cn2._i)
            {

                throw new Exception();
            }
            else
            {
                int cn = (cn1._a*cn2._a-cn1._b-cn2._b)+(cn1._a*cn2._b+cn1._b*cn2._a)*cn1._i;
                return new ComplexNumbers(cn);
            }

        }
        public static ComplexNumbers operator /(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1._i != cn2._i)
            {

                throw new Exception();
            }
            else
            {
                int cn = (cn1._a + cn1._b * cn1._i) / (cn2._a + cn2._b * cn2._i);
                return new ComplexNumbers(cn);
            }

        }
        public static bool operator ==(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1.Cn == cn2.Cn || (cn1._a == cn2._a && cn1._b == cn2._b && cn1._i == cn2._i))
            {
                return true;
            }
            else
                return false;
        }
        public static bool operator !=(ComplexNumbers cn1, ComplexNumbers cn2)
        {
            if (cn1.Cn != cn2.Cn || cn1._a != cn2._a || cn1._b != cn2._b || cn1._i != cn2._i)
            {
                return true;
            }
            else
                return false;
        }
    }
}
