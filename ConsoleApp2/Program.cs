using System;
using WSUniversalLib;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] invalidProductTypes = { 4, -1, 0, 999, -1000 };
            int[] validProductTypes = { 1, 2, 3 };

            int[] invalidMaterialTypes = { 3, 123, -123, 0, 100 };
            int[] validMaterialTypes = { 1, 2 };

            int[] validCounts = { 123, 1, 999 };
            int[] invalidCounts = { -123, 0 };

            float[] invalidWidth = { -123, 0 };
            float[] validWidth = { 123, 1, 20, 1.5f };

            float[] invalidLenght = { -12, 0 };
            float[] validLenght = { 123, 45, 5.1f };

            foreach (var productType in invalidProductTypes)
            {
                var r = Calculation.GetQuantityForProduct(productType, validMaterialTypes[0], validCounts[0], validWidth[0], validLenght[0]);
            }
        }
    }
}
