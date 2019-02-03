using NUnit.Framework;
using WebAPI.Controllers;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ValuesController controller = new ValuesController();
            // controller.
            Assert.Pass();
        }
    }
}