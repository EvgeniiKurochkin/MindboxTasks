using System.Net.Http.Headers;

namespace CalculatingSquare
{
    public class Triangle : IFigure
    {
        public double SideA { get; }

        public double SideB { get; }

        public double SideC { get; }

        private readonly Lazy<bool> _RightTriangle;
        public bool RightTriangle => _RightTriangle.Value;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentOutOfRangeException("Сторона не может быть отрицательной");
            }
            if (sideA == 0 && sideB == 0 && sideC == 0)
            {
                throw new ArgumentOutOfRangeException("Все стороны не могут быть равны нулю");
            }
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            _RightTriangle = new Lazy<bool>(GetRightTriangle);
        }
      
        public bool GetRightTriangle()
        {
            var TriangleSide = new[] { SideA, SideB, SideC };
            var SaidMax = TriangleSide.Max();
            return Math.Pow(SaidMax, 2) * 2 == Math.Pow(SideA, 2) + Math.Pow(SideB, 2) + Math.Pow(SideC, 2); ;
        }

        public double GetSquare()
        {
            var halfPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));

        }
    }
}