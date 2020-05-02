namespace Uwp.Appium.PopExample.Alarms.Pages
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;

    using Uwp.Appium.PopExample.Alarms.Extensions;

    public class AlarmPage : BasePage
    {
        private readonly By addAlarmButton;

        private readonly By selectAlarmsButton;

        private readonly By alarmList;

        public AlarmPage()
        {
            this.addAlarmButton = ByExtensions.AutomationId("AddAlarmButton");
            this.selectAlarmsButton = ByExtensions.AutomationId("SelectAlarmsButton");
            this.alarmList = ByExtensions.AutomationId("AlarmListView");
        }

        protected override By Trait => ByExtensions.AutomationId("AddAlarmButton");

        public EditAlarmPage GoToAddAlarm()
        {
            this.App.FindElement(this.addAlarmButton).Click();
            return new EditAlarmPage();
        }

        public EditAlarmPage GoToEditAlarm(string expectedAlarmName)
        {
            this.GetListAlarmElement(expectedAlarmName).Click();
            return new EditAlarmPage();
        }

        public void VerifyAlarmExists(string alarmName, TimeSpan time)
        {
            string timeString = time.ToString(@"hh\:mm");
            Assert.IsNotNull(this.GetListAlarmElement($"{alarmName}, {timeString}"));
        }

        public void VerifyAlarmDoesNotExist(string alarmName, TimeSpan time)
        {
            string timeString = time.ToString(@"hh\:mm");
            Assert.IsNull(this.GetListAlarmElement($"{alarmName}, {timeString}"));
        }

        private AppiumWebElement GetListAlarmElement(string name)
        {
            ReadOnlyCollection<AppiumWebElement> listElements =
                this.App.FindElement(this.alarmList).FindElements(By.ClassName("ListViewItem"));

            return listElements.FirstOrDefault(
                element => element.GetAttribute("Name").Contains(name, StringComparison.CurrentCulture));
        }
    }
}