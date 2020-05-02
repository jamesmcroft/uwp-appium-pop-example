namespace Uwp.Appium.PopExample
{
    using System;
    using System.Runtime.CompilerServices;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;
    using OpenQA.Selenium.Remote;

    internal static class AppManager
    {
        private const string WindowsApplicationDriverUrl = "http://127.0.0.1:4723";

        private const string AppId = "Microsoft.UWPCommunityToolkitSampleApp_8wekyb3d8bbwe!App";

        private static WindowsDriver<WindowsElement> app;

        public static WindowsDriver<WindowsElement> App
        {
            get
            {
                if (app == null)
                {
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                }

                return app;
            }
        }

        public static RemoteTouchScreen TouchScreen { get; set; }

        public static void StartApp()
        {
            if (app != null && TouchScreen != null)
            {
                return;
            }

            StopApp();

            var opts = new AppiumOptions();
            opts.AddAdditionalCapability("app", AppId);

            app = new WindowsDriver<WindowsElement>(new Uri(WindowsApplicationDriverUrl), opts);
            Assert.IsNotNull(app);
            Assert.IsNotNull(app.SessionId);

            // Set implicit timeout to 1.5 seconds to make element search to retry every 500 ms for at most three times
            app.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1.5);

            TouchScreen = new RemoteTouchScreen(app);
            Assert.IsNotNull(TouchScreen);
        }

        public static void StopApp()
        {
            TouchScreen = null;

            if (app == null)
            {
                return;
            }

            app.Quit();
            app = null;
        }
    }
}