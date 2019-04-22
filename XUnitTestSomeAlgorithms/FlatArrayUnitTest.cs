using System;
using Xunit;
using SomeAlgorithms;

namespace XUnitTestSomeAlgorithms
{
    public class FlatArrayUnitTest
    {
        /// <summary>
        /// input: [[1,2,[3]],4]
        /// expected: [1,2,3,4],
        /// </summary>
        [Fact]
        public void IntArrayTest()
        {
            object[] array = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 } };
            Assert.Equal(new object[] { 1, 2, 3, 4 }, array.GetFlatArray());
        }

        /// <summary>
        /// input:  [[1,2,[3]],4, [hi,bye,[5]] ]
        /// expected: [1,2,3,4,hi,bye,5]
        /// </summary>
        [Fact]
        public void IntStringArrayTest()
        {
            object[] array = new object[] { new object[] { 1, 2, new object[] { 3 } }, new object[] { 4 },
                              new object[] {"hi","bye",new object[] { 5 } } };
            Assert.Equal(new object[] { 1, 2, 3, 4, "hi", "bye", 5 }, array.GetFlatArray());
        }

        
    }
}
