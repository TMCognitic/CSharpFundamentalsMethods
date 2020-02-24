using System;

namespace CSharpFundamentalsMethods
{
    struct EQ2D
    {
        public double A;
        public double B;
        public double C;

        public bool Resoudre(out double? X1, out double? X2)
        {
            X1 = X2 = null;

            if (A == 0D)
                return false;

            double delta = (B * B) - (4 * A * C);

            if (delta < 0)
                return false;

            X1 = (-B - Math.Sqrt(delta)) / (2 * A);
            X2 = (-B + Math.Sqrt(delta)) / (2 * A);
            return true;
        }
    }
}