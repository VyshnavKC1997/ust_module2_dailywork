using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_flipcart
{
    internal class CoreCodes
    {
        IDictionary<string, string> config;
        public IWebDriver driver;
        public bool CheckLinkStatus(string url)
        {
            try
            {
                var request = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(url);
                request.Method = "HEAD";
                using(var response = request.GetResponse()) {
                    return true;
                }

            }
            catch
            {
                return false;
            }
        }

        public void ReadConfigurationProperties()
        {
            string currDir = Directory.GetParent(@"../../../").FullName;
            config= new Dictionary<string, string>();
            string fileName = currDir + "/ConfigSettings/Configuration.txt";
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                if (!string.IsNullOrEmpty(line) && line.Contains("="))
                {
                    string[] parts = line.Split('=');
                    string key = parts[0].Trim();
                    string value = parts[1].Trim();
                    config[key] = value;
                }
            }
        }
        [OneTimeSetUp]
        public void InitializeBrowser()
        {
            ReadConfigurationProperties();
            if (config["browser"].ToLower() == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (config["browser"].ToLower() == "edge")
            {
                driver = new EdgeDriver();
            }
            driver.Url = config["baseUrl"];
            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void cleanup()
        {
            driver.Quit();
        }

    }
}
