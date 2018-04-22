

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.ValueTuple.ContainsExtensions.Test
{
    [TestClass]
    public class ValueTupleExtensionTest_Decimal
    {

        [TestMethod]
        public void Test_2_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d).Contains(i));

        }

        [TestMethod]
        public void Test_2_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d).Contains(i));

        }

        [TestMethod]
        public void Test_3_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d, 3d).Contains(i));

        }

        [TestMethod]
        public void Test_3_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d, 3d).Contains(i));

        }

        [TestMethod]
        public void Test_4_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d, 3d, 4d).Contains(i));

        }

        [TestMethod]
        public void Test_4_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d, 3d, 4d).Contains(i));

        }

        [TestMethod]
        public void Test_5_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d, 3d, 4d, 5d).Contains(i));

        }

        [TestMethod]
        public void Test_5_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d, 3d, 4d, 5d).Contains(i));

        }

        [TestMethod]
        public void Test_6_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d, 3d, 4d, 5d, 6d).Contains(i));

        }

        [TestMethod]
        public void Test_6_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d, 3d, 4d, 5d, 6d).Contains(i));

        }

        [TestMethod]
        public void Test_7_decimal_true()
        {

            var i = 1d;
            Assert.IsTrue((1d, 2d, 3d, 4d, 5d, 6d, 7d).Contains(i));

        }

        [TestMethod]
        public void Test_7_decimal_false()
        {

            var i = 0d;
            Assert.IsFalse((1d, 2d, 3d, 4d, 5d, 6d, 7d).Contains(i));

        }


    }
}
