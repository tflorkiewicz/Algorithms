using LinkyList.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList.Test
{
    [TestClass]
    public class LinkyListTests
    {
        [TestMethod]
        public void LinkyListNodeTests()
        {
            var tmp = new LinkyList<string>();
            tmp.Add("element1");
            tmp.Add("element2");
            
            Assert.AreEqual(2, tmp.Count);

            tmp.Remove("element1");

            Assert.AreEqual(1, tmp.Count);

            tmp.Add("element3");

            Assert.AreEqual(tmp.Count, 2);

            tmp.Remove("element3");

            

        }
    }
}
