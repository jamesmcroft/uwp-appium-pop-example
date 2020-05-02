namespace Uwp.Appium.PopExample.Alarms.Pages
{
    using OpenQA.Selenium;

    using Uwp.Appium.PopExample.Alarms.Extensions;

    public class EditAlarmPage : BasePage
    {
        protected override By Trait => ByExtensions.AutomationId("EditAlarmHeader");
    }
}