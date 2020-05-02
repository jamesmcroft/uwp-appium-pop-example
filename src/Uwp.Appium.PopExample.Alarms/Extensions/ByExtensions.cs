namespace Uwp.Appium.PopExample.Alarms.Extensions
{
    using System;

    using OpenQA.Selenium;

    public static class ByExtensions
    {
        public static By AutomationId(string automationId)
        {
            if (automationId == null)
            {
                throw new ArgumentNullException(
                    nameof(automationId),
                    "Cannot find elements with a null automation id attribute.");
            }

            return By.XPath($".//*[@AutomationId='{automationId}']");
        }
    }
}
