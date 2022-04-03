namespace lesson6
{
    class Circle : Point
    {
        double _radius;
        const double PI = 3.14;
        public Circle(int radius)
        {
            _radius = radius;
        }
        public double CalculateArea()
        {
            double s = PI * _radius * _radius;
            return s;
        }
    }
}
