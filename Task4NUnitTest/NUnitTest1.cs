using System;
using NUnit.Framework;
using Task4;

namespace Task4NUnitTest
{
    [TestFixture]
    public class SearchTest
    {
        [Test]
        public void BinSearchTest()
        {
 
            int[] array = { -38,-24 ,-8, 0, 22, 66, 98,123,224 };
            int[] ar = { };
            Assert.AreEqual(Search.BinSearch(array,0), 3);
            Assert.AreEqual(Search.BinSearch(array, 123), 7);
            Assert.AreEqual(ar.BinSearch(19), -1);
        }
    }
}