## Windows (UWP) Appium Page Object Pattern Example

Taking advantage of the [WinAppDriver](https://github.com/microsoft/WinAppDriver) service to provide Appium UI tests for Windows apps, this project serves as a simple example of building tests following the Page Object Pattern.

The sample uses the default Windows Alarms & Clock application to provide example tests for adding and editing alarms.

### Wnat is the Page Object Pattern?

The goal of the page object pattern is to use page objects to abstract page information away from your tests. Ideally, they will store all your selectors to find UI elements that a page is aware of and actions that are capable of the page. 

As a result, the page object provides reusable, chainable components which can be used to create well-structured, easily readable tests.

Explore the [EditAlarmPage](/src/Uwp.Appium.PopExample.Alarms/Pages/EditAlarmPage.cs) example for more info. 

### Get started
1. Download Windows Application Driver installer from <https://github.com/Microsoft/WinAppDriver/releases>
2. Run the installer on a Windows 10 machine where your application under test is installed and will be tested
3. Enable Developer Mode (ms-settings:developers) in Windows settings
4. Run `WinAppDriver.exe` from the installation directory (E.g. `C:\Program Files (x86)\Windows Application Driver`)
5. Clone this repo to your machine
6. Load and run tests from the project solution in [src](/src/) using `dotnet test` or a test runner of your choice
