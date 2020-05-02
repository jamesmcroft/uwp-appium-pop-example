namespace Uwp.Appium.PopExample.Alarms.Elements
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;

    using Uwp.Appium.PopExample.Alarms.Extensions;

    public static class TimePicker
    {
        public static By Hour => ByExtensions.AutomationId("HourLoopingSelector");

        public static By Minute => ByExtensions.AutomationId("MinuteLoopingSelector");

        public static void SetTimePickerValue(this AppiumWebElement element, TimeSpan time)
        {
            element.FindElement(Hour).FindElementByName(time.ToString("%h")).Click();
            element.FindElement(Minute).FindElementByName(time.ToString("mm")).Click();
        }
    }
}