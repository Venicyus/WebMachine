using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using WebMachine.Models;

namespace WebMachine.Services {
    class GmapsService {
        private static readonly string _url = "https://www.google.com.br/maps/search/";

        public static void GetAddress(List<Client> clients) {
            ClientService _servClient = new ClientService();
            
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");

            IWebDriver driver = new ChromeDriver(chromeOptions);

            try {
                foreach (var client in clients) {
                    string lat = client.Latitude.ToString().Replace(",", ".");
                    string lng = client.Longitude.ToString().Replace(",", ".");

                    driver.Navigate().GoToUrl($"{_url}{lat},+{lng}/@{lat},{lng},5z");

                    Thread.Sleep(1000);

                    var elemts = driver.FindElement(By.Id("pane")).FindElements(By.XPath("//span[@class='widget-pane-link']"));

                    Thread.Sleep(1000);

                    if (elemts != null && elemts.Count > 0 && elemts[0].Text.Length > 0) {
                        client.Address = elemts[0].Text;
                        client.IsUpdate = false;
                        _servClient.Update(client.Id, client);
                    }
                }
            } catch (Exception ex) {
                throw new Exception($"Erro ao buscar Endereço - {ex}");
            } finally {
                driver.Quit();
            }
        }
    }
}
