using NUnit.Framework;
using Problem1_PromotionEngine.Model;
using System.Collections.Generic;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestFixture]
        public class GetTotalTest
        {

            [Test]
            [TestCase(1, 1, 1, 0, 100)]
            [TestCase(5, 5, 1, 0, 370)]
            [TestCase(3, 5, 1, 0, 280)]
            [TestCase(1, 1, 1, 0, 100)]
            [TestCase(3, 6, 1, 1, 280)]
            [TestCase(3, 6, 1, 1, 295)]

            public void AddMethodTest(int CuantA, int CuantB, int CuantC, int CuantD, double expected)
            {


                var ItemsList = new List<ItemForCart>();
                if (CuantA != 0)
                    ItemsList.Add(new ItemForCart("A", 50, CuantA));
                if (CuantB != 0)
                    ItemsList.Add(new ItemForCart("B", 30, CuantB));
                if (CuantC != 0)
                    ItemsList.Add(new ItemForCart("C", 20, CuantC));
                if (CuantD != 0)
                    ItemsList.Add(new ItemForCart("D", 20, CuantD));

                var Cart = new Cart(ItemsList);

                Assert.AreEqual(expected, Cart.GetTotal());
            }
        }
    }
}