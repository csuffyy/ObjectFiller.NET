namespace ObjectFiller.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Tynamix.ObjectFiller;

    [TestClass]
    public class CityNamesPluginTest
    {
        [TestMethod]
        public void RandomNameIsReturned()
        {
            var sut = new CityName();
            var value = sut.GetValue();

            Assert.IsFalse(string.IsNullOrEmpty(value));
        }
    }
}