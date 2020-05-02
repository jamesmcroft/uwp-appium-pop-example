namespace Uwp.Appium.PopExample.Alarms.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Uwp.Appium.PopExample.Alarms.Pages;

    [TestClass]
    public class AlarmTests : BaseTestClass
    {
        [TestMethod]
        public void AddAlarm()
        {
            new AlarmPage().ClickAddAlarmButton();
        }
    }
}