using NUnit.Framework;

namespace UnitTestProject
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void TestMethod() {}

        [TestCase(5, 12)]
        public void ParametrizedMethod(int i, int j){ }
    }
}
