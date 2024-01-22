using PoP_JEM;
namespace PoP_JEMTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidaTest()
        {
            int day = 1, month = 1, year = 2020;
            bool expected = true;
            bool actual = PopProject.Valida(day, month, year);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InvalidValida()
        {
            int day = 33, month = 13, year = 24;
            bool expected = false, actual = PopProject.Valida(day, month, year);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void February29()
        {
            int day = 29, month = 2, year = 2020;
            bool expected = true, actual = PopProject.Valida(day, month, year);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NotFebruary29()
        {
            int day = 29, month = 2, year = 2021;
            bool expected = false, actual = PopProject.Valida(day, month, year);
            Assert.AreEqual(expected, actual);
        }
    }
}