namespace Uwp.Appium.PopExample.Alarms.Pages
{
    using OpenQA.Selenium;

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

        protected override By Trait => ByExtensions.AutomationId("AlarmListView");

        public EditAlarmPage ClickAddAlarmButton()
        {
            this.App.FindElement(this.addAlarmButton).Click();
            return new EditAlarmPage();
        }
    }
}