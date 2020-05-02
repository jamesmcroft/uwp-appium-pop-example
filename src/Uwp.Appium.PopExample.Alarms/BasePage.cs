namespace Uwp.Appium.PopExample.Alarms
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Windows;
    using OpenQA.Selenium.Support.UI;

    public abstract class BasePage
    {
        protected BasePage()
        {
            this.VerifyPageShown(TimeSpan.FromSeconds(2));
        }

        protected WindowsDriver<WindowsElement> App => AppManager.App;

        protected abstract By Trait { get; }

        public void VerifyPageShown(TimeSpan? timeout)
        {
            string message = $"Unable to verify on page '{this.GetType().Name}'";

            if (timeout == null)
            {
                Assert.IsNotNull(this.App.FindElement(this.Trait), message);
            }
            else
            {
                var wait = new WebDriverWait(this.App, timeout.Value);
                wait.Until(driver => driver.FindElement(this.Trait) != null);
            }
        }
    }
}