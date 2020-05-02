namespace Uwp.Appium.PopExample.Alarms.Pages
{
    using System;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium.Windows;

    using Uwp.Appium.PopExample.Alarms.Elements;
    using Uwp.Appium.PopExample.Alarms.Extensions;

    public class EditAlarmPage : BasePage
    {
        private readonly By alarmTimePicker;

        private readonly By alarmNameTextBox;

        private readonly By alarmRepeatButton;

        private readonly By alarmSoundButton;

        private readonly By alarmSnoozeComboBox;

        private readonly By alarmSaveButton;

        private readonly By alarmCancelButton;

        private readonly By alarmDeleteButton;

        private readonly By alarmDeleteDialog;

        public EditAlarmPage()
        {
            this.alarmTimePicker = ByExtensions.AutomationId("AlarmTimePicker");
            this.alarmNameTextBox = ByExtensions.AutomationId("AlarmNameTextBox");
            this.alarmRepeatButton = ByExtensions.AutomationId("AlarmRepeatsToggleButton");
            this.alarmSoundButton = ByExtensions.AutomationId("AlarmSoundButton");
            this.alarmSnoozeComboBox = ByExtensions.AutomationId("AlarmSnoozeCombobox");
            this.alarmSaveButton = ByExtensions.AutomationId("AlarmSaveButton");
            this.alarmCancelButton = ByExtensions.AutomationId("CancelButton");
            this.alarmDeleteButton = ByExtensions.AutomationId("AlarmDeleteButton");
            this.alarmDeleteDialog = ByExtensions.AutomationId("DeleteConfirmationDialog");
        }

        protected override By Trait => ByExtensions.AutomationId("EditAlarmHeader");

        public EditAlarmPage SetAlarmTime(TimeSpan time)
        {
            WindowsElement timePicker = this.App.FindElement(this.alarmTimePicker);
            timePicker.SetTimePickerValue(time);
            return this;
        }

        public EditAlarmPage SetAlarmName(string name)
        {
            WindowsElement textBox = this.App.FindElement(this.alarmNameTextBox);
            textBox.Click();
            textBox.SendKeys(name);
            return this;
        }

        public void SaveAlarm()
        {
            this.App.FindElement(this.alarmSaveButton).Click();
        }

        public void DeleteAlarm()
        {
            this.App.FindElement(this.alarmDeleteButton).Click();
            this.App.FindElement(this.alarmDeleteDialog).FindElementByName("Delete").Click();
        }

        public void CancelEditAlarm()
        {
            this.App.FindElement(this.alarmCancelButton).Click();
        }
    }
}