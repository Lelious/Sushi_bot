using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Serilog;
using System;

namespace Sushi_bot
{
    public class WebSiteSushiVeslaWorker
    {
        Type type = typeof(WebSiteSushiVeslaWorker);

        private IWebDriver driver;
        private readonly By _makiButton = By.XPath("//div[text()='Маки']");
        private readonly By _makePurchase = By.XPath("//button[@class='btn btn__cart__order']");
        private readonly By _streetField = By.XPath("//div[@class='form-group p-0 col-8']/input[@placeholder='Улица*']");
        private readonly By _streetModalWindow = By.XPath("//li[@class='list-group-item']");
        private readonly By _houseField = By.XPath("//div[@class='form-group p-0 col-2']/input[@placeholder='Дом*']");
        private readonly By _quarterField = By.XPath("//div[@class='form-group p-0 col-3']/input[@placeholder='Квартира*']");
        private readonly By _customerName = By.XPath("//input[@name='customer']");
        private readonly By _telephoneNumber = By.XPath("//input[@type='tel']");
        private readonly By _email = By.XPath("//input[@placeholder='Укажите Ваш Email*']");
        private readonly By _paymentMethodCash = By.XPath("//input[@name='radio']");
        private readonly By _sumOfPaymentMethodCash = By.XPath("//input[@placeholder='С какой суммы подготовить сдачу?']");
        private readonly By _paymentMethodCard = By.XPath("//input[@id='radio2']");
        private readonly By _paymentMethodCardOnline = By.XPath("//input[@id='radio3']");
        private readonly By _comment = By.XPath("//input[@placeholder='Дополнительный комментарий к заказу']");
        private readonly By _submit = By.XPath("//button[@class='btn cart__full__order__btn vue-loading-button']");

        public WebSiteSushiVeslaWorker(string webSite)
        {
            Setup(webSite);

            Log.Debug("Driver settings are sucsessfuly installed.");
        }
        public void Setup(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);            

            var makiButton = driver.FindElement(_makiButton);
            makiButton.Click();            
        }

        public void SushiClicker(int sitePositionNumber)
        {
            By _sushiButton = By.XPath(
                $"//div[@id='10']/div[position()={sitePositionNumber}]/div[@class='dish-card--content']" +
                $"/div[@class='dish-card--content--block4']/a[@class='view-dish-button btn semiplus']");

            var sushiButton = driver.FindElement(_sushiButton);

            Log.Debug($"{type.FullName}, Method name; SushiClicker, Sucsessfuly find XPath element {sushiButton}! number of Therad: {AppDomain.GetCurrentThreadId()}");

            Thread.Sleep(500);
            sushiButton.Click();
            Thread.Sleep(500);
            sushiButton.Click();
            Thread.Sleep(500);
        }

        public void WriteInformation(string street, string house, string quarter,
                                     string name, string telephoneNumber, string email,
                                     string paymentMethod, string sumOfPayment,
                                     string comment, bool realPurchase)
        {            
            var purchaseButton = driver.FindElement(_makePurchase);
            purchaseButton.Click();
            Thread.Sleep(1000);

            var changeStreet = driver.FindElement(_streetField);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeStreet}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeStreet.Click();
            changeStreet.SendKeys(street);
            var changeStreetModalWindow = driver.FindElement(_streetModalWindow);
            changeStreetModalWindow.Click();

            var changeHouse = driver.FindElement(_houseField);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeHouse}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeHouse.Click();
            changeHouse.SendKeys(house);

            var changeQuarter = driver.FindElement(_quarterField);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeQuarter}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeQuarter.Click();
            changeQuarter.SendKeys(quarter);

            var changeCustomer = driver.FindElement(_customerName);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeCustomer}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeCustomer.Click();
            changeCustomer.SendKeys(name);

            var changeTelephoneNumber = driver.FindElement(_telephoneNumber);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeTelephoneNumber}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeTelephoneNumber.Click();
            telephoneNumber.Remove(0, 4);
            changeTelephoneNumber.SendKeys(telephoneNumber);

            var changeEmail = driver.FindElement(_email);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeEmail}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeEmail.Click();
            changeEmail.SendKeys(email);

            var changeComment = driver.FindElement(_comment);
            Log.Debug($"{type.FullName}, Method name: WriteInformation, Sucsessfuly find XPath element {changeComment}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            changeComment.Click();

            if (string.IsNullOrEmpty(comment))
            {
                comment = "";
                Log.Warning($"{type.FullName}, Method name: WriteInformation, XPath element {changeComment} can not be null! Rewriting on whitespace! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            }

            changeComment.SendKeys(comment);

            if (paymentMethod.Equals("Наличные"))
            {
                var changePaymentMethod = driver.FindElement(_paymentMethodCash);
                Log.Debug($"{type.FullName}, Method name; WriteInformation, Sucsessfuly find XPath element {changePaymentMethod}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
                changePaymentMethod.Click();

                var sumOfPaymentMethod = driver.FindElement(_sumOfPaymentMethodCash);
                Log.Debug($"{type.FullName}, Method name; WriteInformation, Sucsessfuly find XPath element {sumOfPaymentMethod}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
                sumOfPaymentMethod.Click();
                sumOfPaymentMethod.SendKeys(sumOfPayment);
            }

            if (paymentMethod.Equals("Картой онлайн"))
            {
                var changePaymentMethod = driver.FindElement(_paymentMethodCardOnline);
                Log.Debug($"{type.FullName}, Method name; WriteInformation, Sucsessfuly find XPath element {changePaymentMethod}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
                changePaymentMethod.Click();
            }

            if (paymentMethod.Equals("Картой курьеру"))
            {
                var changePaymentMethod = driver.FindElement(_paymentMethodCard);
                Log.Debug($"{type.FullName}, Method name; WriteInformation, Sucsessfuly find XPath element {changePaymentMethod}! Number of Therad: {AppDomain.GetCurrentThreadId()}");
                changePaymentMethod.Click();
            }

            var submitButton = driver.FindElement(_submit);
            Log.Debug($"{type.FullName}, Method name; WriteInformation, Sucsessfuly find XPath element {submitButton}! Number of Therad: {AppDomain.GetCurrentThreadId()}");

            if (realPurchase)
            {
                submitButton.Click();
                Log.Debug($"{type.FullName}, Method name; WriteInformation, Marker 'real' enabled! Making purchase! Number of Therad: {AppDomain.GetCurrentThreadId()}");
            }
        }
    }
}
