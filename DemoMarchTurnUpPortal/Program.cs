// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
IWebElement userNameElement = driver.FindElement(By.Id("UserName"));
userNameElement.SendKeys("hari");
IWebElement passwordElement = driver.FindElement(By.Id("Password"));
passwordElement.SendKeys("123123");
IWebElement loginButtonElement = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButtonElement.Click();
Thread.Sleep(2000);
IWebElement welcomeMessageElement = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
String message = welcomeMessageElement.Text;
Console.WriteLine(message);
if (welcomeMessageElement.Text == "Hello hari!")
{
    Console.WriteLine("Login Success!");
}else
{
    Console.WriteLine("Login Unsuccess!");
}
