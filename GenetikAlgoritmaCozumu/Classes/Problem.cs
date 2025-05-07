using System;

namespace GenetikAlgoritmaCozumu
{
    public static class Problem
    {
        // Problem 4: f(x,y) = (1.5 - x + xy)² + (2.25 - x + xy²)² + (2.625 - x + xy³)²
        // Where: -4.5 ≤ x,y ≤ 4.5
        public static double Evaluate(double[] genes)
        {
            double x = genes[0];
            double y = genes[1];

            double term1 = Math.Pow(1.5 - x + x * y, 2);
            double term2 = Math.Pow(2.25 - x + x * Math.Pow(y, 2), 2);
            double term3 = Math.Pow(2.625 - x + x * Math.Pow(y, 3), 2);

            return term1 + term2 + term3;
        }
    }
}