

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace System.ValueTuple.ContainsExtensions.Test
{
    [TestClass]
    public class ValueTupleExtensionTest_Enum
    {

        [TestMethod]
        public void Test_2_enum_true()
        {
            var i = System.IO.FileAttributes.Device;
            Assert.IsTrue((System.IO.FileAttributes.Offline, System.IO.FileAttributes.Device).Contains(i));

        }

        [TestMethod]
        public void Test_2_enum_false()
        {

            var i = System.IO.FileAttributes.NoScrubData;
            Assert.IsFalse((System.IO.FileAttributes.Device, System.IO.FileAttributes.Offline).Contains(i));

        }

        [TestMethod]
        public void Test_3_enum_true()
        {

            var i = System.IO.FileAttributes.Device;
            Assert.IsTrue((System.IO.FileAttributes.Normal, System.IO.FileAttributes.Offline, System.IO.FileAttributes.Device).Contains(i));

        }

        [TestMethod]
        public void Test_3_enum_false()
        {

            var i = System.IO.FileAttributes.NoScrubData;
            Assert.IsFalse((System.IO.FileAttributes.Normal, System.IO.FileAttributes.Device, System.IO.FileAttributes.Offline).Contains(i));

        }
        

    }
}
