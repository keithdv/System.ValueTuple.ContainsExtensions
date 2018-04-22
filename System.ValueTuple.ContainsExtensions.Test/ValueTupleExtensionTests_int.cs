

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.ValueTuple.ContainsExtensions.Test
{
    [TestClass]
    public class ValueTupleExtensionTest
    {

        [TestMethod]
        public void Test_2_int_true()
        {

            var i = 2;
			var tuple = (1, 2);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_2_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2).Contains(i));

        }

        [TestMethod]
        public void Test_3_int_true()
        {

            var i = 3;
			var tuple = (1, 2, 3);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_3_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3).Contains(i));

        }

        [TestMethod]
        public void Test_4_int_true()
        {

            var i = 4;
			var tuple = (1, 2, 3, 4);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_4_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4).Contains(i));

        }

        [TestMethod]
        public void Test_5_int_true()
        {

            var i = 5;
			var tuple = (1, 2, 3, 4, 5);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_5_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5).Contains(i));

        }

        [TestMethod]
        public void Test_6_int_true()
        {

            var i = 6;
			var tuple = (1, 2, 3, 4, 5, 6);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_6_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6).Contains(i));

        }

        [TestMethod]
        public void Test_7_int_true()
        {

            var i = 7;
			var tuple = (1, 2, 3, 4, 5, 6, 7);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_7_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7).Contains(i));

        }

        [TestMethod]
        public void Test_8_int_true()
        {

            var i = 8;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_8_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8).Contains(i));

        }

        [TestMethod]
        public void Test_9_int_true()
        {

            var i = 9;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_9_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9).Contains(i));

        }

        [TestMethod]
        public void Test_10_int_true()
        {

            var i = 10;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_10_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10).Contains(i));

        }

        [TestMethod]
        public void Test_11_int_true()
        {

            var i = 11;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_11_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11).Contains(i));

        }

        [TestMethod]
        public void Test_12_int_true()
        {

            var i = 12;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_12_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12).Contains(i));

        }

        [TestMethod]
        public void Test_13_int_true()
        {

            var i = 13;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_13_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13).Contains(i));

        }

        [TestMethod]
        public void Test_14_int_true()
        {

            var i = 14;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_14_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14).Contains(i));

        }

        [TestMethod]
        public void Test_15_int_true()
        {

            var i = 15;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_15_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15).Contains(i));

        }

        [TestMethod]
        public void Test_16_int_true()
        {

            var i = 16;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_16_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16).Contains(i));

        }

        [TestMethod]
        public void Test_17_int_true()
        {

            var i = 17;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_17_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17).Contains(i));

        }

        [TestMethod]
        public void Test_18_int_true()
        {

            var i = 18;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_18_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18).Contains(i));

        }

        [TestMethod]
        public void Test_19_int_true()
        {

            var i = 19;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_19_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19).Contains(i));

        }

        [TestMethod]
        public void Test_20_int_true()
        {

            var i = 20;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_20_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20).Contains(i));

        }

        [TestMethod]
        public void Test_21_int_true()
        {

            var i = 21;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_21_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21).Contains(i));

        }

        [TestMethod]
        public void Test_22_int_true()
        {

            var i = 22;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_22_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22).Contains(i));

        }

        [TestMethod]
        public void Test_23_int_true()
        {

            var i = 23;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_23_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23).Contains(i));

        }

        [TestMethod]
        public void Test_24_int_true()
        {

            var i = 24;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_24_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24).Contains(i));

        }

        [TestMethod]
        public void Test_25_int_true()
        {

            var i = 25;
			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
            Assert.IsTrue(tuple.Contains(i));

        }

        [TestMethod]
        public void Test_25_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25).Contains(i));

        }


    }
}
