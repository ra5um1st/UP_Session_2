using System;

namespace WSUniversalLib
{
    public static class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            if( productType < 1 || productType > 3 ||
                materialType < 1 || materialType > 2 ||
                count <= 0 ||
                width <= 0 ||
                length <= 0)
            {
                return -1;
            }

            float productTypeCoefficient = 0;
            float materialTypeCoefficient = 0;

            switch (productType)
            {
                case 1: 
                    productTypeCoefficient = 1.1f; 
                    break;
                case 2:
                    productTypeCoefficient = 2.5f;
                    break;
                case 3:
                    productTypeCoefficient = 8.43f;
                    break;
            }
            switch (materialType)
            {
                case 1:
                    materialTypeCoefficient = 0.003f;
                    break;
                case 2:
                    materialTypeCoefficient = 0.0012f;
                    break;
            }

            float result = productTypeCoefficient * count * width * length;
            result += (float)Math.Ceiling(result * materialTypeCoefficient);
            return (int)result;
        }
    }
}
