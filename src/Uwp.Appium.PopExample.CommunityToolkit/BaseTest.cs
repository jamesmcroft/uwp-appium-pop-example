namespace Uwp.Appium.PopExample
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    public abstract class BaseTest
    {
        [TestInitialize]
        public virtual void Initialize()
        {
            AppManager.StartApp();
        }

        [TestCleanup]
        public virtual void Cleanup()
        {
            // AppManager.StopApp();
        }
    }
}