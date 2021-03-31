using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

using SeleniumExtras;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace DeliveryHeroAutomation.Framework.Services
{
    public static class ElementService
    {

        private static DefaultWait<AppiumDriver<IWebElement>> CreateDefaultWait()
        {
            var fluentWait =
                new DefaultWait<AppiumDriver<IWebElement>>(DriverManager.Instance.AppiumDriver)
                {
                    Message = "Not showing",
                    Timeout = TimeSpan.FromSeconds(25),
                    PollingInterval = TimeSpan.FromMilliseconds(250)
                };

            fluentWait.IgnoreExceptionTypes(typeof(OpenQA.Selenium.NoSuchElementException),typeof(TargetInvocationException));

            return fluentWait;
        }

        public static void FluentClick(this IWebElement element)
        {
            var fluentWait = CreateDefaultWait();
            var rs = fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

            rs.Click();
        }

        public static IWebElement FluentFindElement(this By by)
        {
            var fluentWait = CreateDefaultWait();
            var rs = fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(by));

            return rs;
        }

        public static bool IsCompleted(this IWebElement element)
        {
            var fluentWait = CreateDefaultWait();

            var rs = fluentWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));

            return true;
        }


        public static void Tap(this IWebElement element)
        {
            var action = new TouchAction(DriverManager.Instance.AppiumDriver);

            action.Tap(element).Perform();
        }

        public static void ScrollHorizontal(this IWebElement element, IWebElement descElement)
        {
            var action = new TouchAction(DriverManager.Instance.AppiumDriver);

            var endX = (element.Location.X);
            var endY = (element.Location.Y + (element.Size.Height * 0.5));

            var startX = (descElement.Size.Width + descElement.Location.X)+ descElement.Size.Width;
            var startY = endY;
            action.Press(startX, startY).Wait(1000).MoveTo(endX, endY).Release().Perform();
        }

        public static void ScrollVertical(this IWebElement element)
        {
            var action = new TouchAction(DriverManager.Instance.AppiumDriver);

            var startX = (element.Location.X + (element.Size.Width * 0.5));
            var startY = (element.Location.Y + (element.Size.Height * 0.5));

            var endX = startX; 
            var endY = (element.Size.Height);
            action.Press(startX, startY).Wait(100).MoveTo(endX, endY).Release().Perform();
        }

        public static void FluentScrollForClick(this IWebElement element,IWebElement scrollElement ,By find)
        {
            var now = DateTime.Now;

            while (DateTime.Now - now < TimeSpan.FromSeconds(30) )
            {
                try
                {
                    var findElement = find.FluentFindElement();
                    if (findElement != null)
                    {
                        findElement.Click();
                        return;
                    }
                }
                catch (NoSuchElementException)
                {
                    element.ScrollHorizontal(scrollElement);
                }
            }

        }

    }
}