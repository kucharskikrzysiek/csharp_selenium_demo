using NUnit.Framework;

namespace csharp_selenium_demo
{
    public class TestBase
    {
        public application app;

        [SetUp]
        public void Start()
        {
            app = new application();
        }

        [TearDown]
        public void Stop()
        {
            app.Quit();
            app = null;
        }
    }
}
