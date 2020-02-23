using NUnit.Framework;

namespace csharp_selenium_demo
{
    [TestFixture]
    public class AllegroTest : TestBase
    {
        [Test]
        public void FirstDemoTest()
        {
            app.searchTosters();
        }
    }

}