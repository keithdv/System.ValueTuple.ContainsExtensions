

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.ValueTuple.ContainsExtensions.Test
{
    [TestClass]
    public class ValueTupleExtensionTest
    {

        [TestMethod]
        public void Test_2_int_true()
        {

			var tuple = (1, 2);
			for(int x = 1; x <= 2; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3);
			for(int x = 1; x <= 3; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4);
			for(int x = 1; x <= 4; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5);
			for(int x = 1; x <= 5; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6);
			for(int x = 1; x <= 6; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7);
			for(int x = 1; x <= 7; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8);
			for(int x = 1; x <= 8; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9);
			for(int x = 1; x <= 9; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
			for(int x = 1; x <= 10; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);
			for(int x = 1; x <= 11; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
			for(int x = 1; x <= 12; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
			for(int x = 1; x <= 13; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);
			for(int x = 1; x <= 14; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);
			for(int x = 1; x <= 15; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
			for(int x = 1; x <= 16; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
			for(int x = 1; x <= 17; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18);
			for(int x = 1; x <= 18; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19);
			for(int x = 1; x <= 19; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20);
			for(int x = 1; x <= 20; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21);
			for(int x = 1; x <= 21; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22);
			for(int x = 1; x <= 22; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23);
			for(int x = 1; x <= 23; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24);
			for(int x = 1; x <= 24; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
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

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25);
			for(int x = 1; x <= 25; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_25_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25).Contains(i));

        }

        [TestMethod]
        public void Test_26_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26);
			for(int x = 1; x <= 26; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_26_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26).Contains(i));

        }

        [TestMethod]
        public void Test_27_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27);
			for(int x = 1; x <= 27; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_27_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27).Contains(i));

        }

        [TestMethod]
        public void Test_28_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28);
			for(int x = 1; x <= 28; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_28_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28).Contains(i));

        }

        [TestMethod]
        public void Test_29_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29);
			for(int x = 1; x <= 29; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_29_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29).Contains(i));

        }

        [TestMethod]
        public void Test_30_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30);
			for(int x = 1; x <= 30; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_30_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30).Contains(i));

        }

        [TestMethod]
        public void Test_31_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31);
			for(int x = 1; x <= 31; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_31_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31).Contains(i));

        }

        [TestMethod]
        public void Test_32_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32);
			for(int x = 1; x <= 32; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_32_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32).Contains(i));

        }

        [TestMethod]
        public void Test_33_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33);
			for(int x = 1; x <= 33; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_33_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33).Contains(i));

        }

        [TestMethod]
        public void Test_34_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34);
			for(int x = 1; x <= 34; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_34_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34).Contains(i));

        }

        [TestMethod]
        public void Test_35_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35);
			for(int x = 1; x <= 35; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_35_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35).Contains(i));

        }

        [TestMethod]
        public void Test_36_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36);
			for(int x = 1; x <= 36; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_36_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36).Contains(i));

        }

        [TestMethod]
        public void Test_37_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37);
			for(int x = 1; x <= 37; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_37_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37).Contains(i));

        }

        [TestMethod]
        public void Test_38_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38);
			for(int x = 1; x <= 38; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_38_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38).Contains(i));

        }

        [TestMethod]
        public void Test_39_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39);
			for(int x = 1; x <= 39; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_39_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39).Contains(i));

        }

        [TestMethod]
        public void Test_40_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40);
			for(int x = 1; x <= 40; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_40_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40).Contains(i));

        }

        [TestMethod]
        public void Test_41_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41);
			for(int x = 1; x <= 41; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_41_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41).Contains(i));

        }

        [TestMethod]
        public void Test_42_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42);
			for(int x = 1; x <= 42; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_42_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42).Contains(i));

        }

        [TestMethod]
        public void Test_43_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43);
			for(int x = 1; x <= 43; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_43_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43).Contains(i));

        }

        [TestMethod]
        public void Test_44_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44);
			for(int x = 1; x <= 44; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_44_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44).Contains(i));

        }

        [TestMethod]
        public void Test_45_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45);
			for(int x = 1; x <= 45; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_45_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45).Contains(i));

        }

        [TestMethod]
        public void Test_46_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46);
			for(int x = 1; x <= 46; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_46_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46).Contains(i));

        }

        [TestMethod]
        public void Test_47_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47);
			for(int x = 1; x <= 47; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_47_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47).Contains(i));

        }

        [TestMethod]
        public void Test_48_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48);
			for(int x = 1; x <= 48; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_48_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48).Contains(i));

        }

        [TestMethod]
        public void Test_49_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49);
			for(int x = 1; x <= 49; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_49_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49).Contains(i));

        }

        [TestMethod]
        public void Test_50_int_true()
        {

			var tuple = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50);
			for(int x = 1; x <= 50; x++)
			{
	            Assert.IsTrue(tuple.Contains(x));
			}
        }

        [TestMethod]
        public void Test_50_int_false()
        {

            var i = 0;
            Assert.IsFalse((1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50).Contains(i));

        }


    }
}
