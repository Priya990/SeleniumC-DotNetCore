using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestNetCore
{
    public class CustomControls : DriverHelper
    {
        public static void ComboBox(String controlName, String Value)
        {
            IWebElement comboboxControl = Driver.FindElement(By.XPath($"//input[@id='{controlName}-awed']"));
            comboboxControl.Clear();
            comboboxControl.SendKeys(Value);

            Driver.FindElement(By.XPath($"//div[@id='{controlName}-dropmenu']//li[text()='{Value}']")).Click();

        }
    }
}
