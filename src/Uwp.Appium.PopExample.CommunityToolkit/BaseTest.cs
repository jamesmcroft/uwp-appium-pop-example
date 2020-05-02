namespace Uwp.Appium.PopExample.CommunityToolkit
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