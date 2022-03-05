using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WSUniversalLib.UnitTests
{
    [TestClass]
    public class CalculationTests
    {
        int[] invalidProductTypes = { 4, -1, 0, 999, -1000 };
        int[] validProductTypes = { 1, 2, 3 };

        int[] invalidMaterialTypes = { 3, 123, -123, 0, 100 };
        int[] validMaterialTypes = { 1, 2 };

        int[] validCounts = { 123, 1, 999};
        int[] invalidCounts = { -123, 0 };

        float[] invalidWidth = { -123, 0 };
        float[] validWidth = { 123, 1, 20, 1.5f };

        float[] invalidLenght = { -12, 0 };
        float[] validLenght = { 123, 45, 5.1f };

        //Easy tests
        [TestMethod]
        public void GetQuantityForProduct_ExistentProductType()
        {
            foreach (var productType in validProductTypes)
            {
                Assert.AreEqual(true, Calculation.GetQuantityForProduct(productType, validMaterialTypes[0], validCounts[0], validWidth[0], validLenght[0]) != -1);
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentProductType()
        {
            foreach (var productType in invalidProductTypes)
            {
                Assert.AreEqual(-1, Calculation.GetQuantityForProduct(productType, validMaterialTypes[0], validCounts[0], validWidth[0], validLenght[0]));
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_ExistentMaterialType()
        {
            foreach (var materialType in validMaterialTypes)
            {
                Assert.AreEqual(true, Calculation.GetQuantityForProduct(validProductTypes[0], materialType, validCounts[0], validWidth[0], validLenght[0]) != -1);
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentMaterialType()
        {
            foreach (var materialType in invalidMaterialTypes)
            {
                Assert.AreEqual(-1, Calculation.GetQuantityForProduct(validProductTypes[0], materialType, validCounts[0], validWidth[0], validLenght[0]));
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_ExistentCounts()
        {
            foreach (var count in validCounts)
            {
                Assert.AreEqual(true, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], count, validWidth[0], validLenght[0]) != -1);
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentCounts()
        {
            foreach (var count in invalidCounts)
            {
                Assert.AreEqual(-1, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], count, validWidth[0], validLenght[0]));
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_ExistentWidth()
        {
            foreach (var width in validWidth)
            {
                Assert.AreEqual(true, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], validCounts[0], width, validLenght[0]) != -1);
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentWidth()
        {
            foreach (var width in invalidWidth)
            {
                Assert.AreEqual(-1, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], validCounts[0], width, validLenght[0]));
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_ExistentLenght()
        {
            foreach (var length in validLenght)
            {
                Assert.AreEqual(true, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], validCounts[0], validWidth[0], length) != -1);
            }
        }

        [TestMethod]
        public void GetQuantityForProduct_NonExistentLenght()
        {
            foreach (var length in invalidLenght)
            {
                Assert.AreEqual(-1, Calculation.GetQuantityForProduct(validProductTypes[0], validMaterialTypes[0], validCounts[0], validWidth[0], length));
            }
        }

        //Hard tests
        [TestMethod]
        public void GetQuantityForProduct_HighCount()
        {
            Assert.AreEqual(114147, Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_HighWidth()
        {
            Assert.AreEqual(114147, Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_HighLength()
        {
            Assert.AreEqual(114147, Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }

        [TestMethod]
        public void GetQuantityForProduct_LowLenght()
        {
            Assert.AreEqual(2488995, Calculation.GetQuantityForProduct(3, 2, 843, 4.47f, 78.26f));
        }

        [TestMethod]
        public void GetQuantityForProduct_LowWidth()
        {
            Assert.AreEqual(114147, Calculation.GetQuantityForProduct(3, 1, 15, 20, 45));
        }
    }
}
