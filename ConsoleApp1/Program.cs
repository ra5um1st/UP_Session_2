using System;
using WSUniversalLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] invalidProductTypes = { 1, 2, 3, 4, -1, 0, 999, -1000 };
            float[] validProductTypes = { 1.1f, 2.5f, 8.43f };

            float[] invalidMaterialTypes = { 0.3f, 123, -123, 0, 100, 0.12f };
            float[] validMaterialTypes = { 0.003f, 0.012f };

            int[] validCounts = { 123, 1, 999 };
            int[] invalidCounts = { -123, 0 };

            int[] invalidWidth = { -123, 0 };
            int[] validWidth = { 123, 1, 20 };

            int[] invalidLenght = { -12, 0 };
            int[] validLenght = { 123, 45 };

            int res;
            foreach (var materialType in validMaterialTypes)
            {
                res = Calculation.GetQuantityForProduct(validProductTypes[0], materialType, validCounts[0], validWidth[0], validLenght[0]);
            }
        }
    }
}
