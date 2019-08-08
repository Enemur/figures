using System;

namespace Figures
{
    public class Triangle : IFigure
    {
        private double _a;
        private double _b;
        private double _c;
        
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        
        public double CalculateSquare()
        {
            var perimeter = (_a + _b + _c) / 2;
            return Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
        }

        public bool IsRight()
        {
            bool isRight;
            if (_a > _c && _a > _b)
                isRight = _a * _a == _b * _b + _c * _c;
            else if (_c > _a && _c > _b)
                isRight = _c * _c == _b * _b + _a * _a;
            else if (_b > _c && _b > _a)
                isRight = _b * _b == _a * _a + _c * _c;
            else
                isRight = false;

            return isRight;
        }
    }
}