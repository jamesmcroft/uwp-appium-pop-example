namespace Uwp.Appium.PopExample
{
    using OpenQA.Selenium.Appium.Windows;

    public abstract class BasePage
    {
        protected WindowsDriver<WindowsElement> App => AppManager.App;
    }
}
