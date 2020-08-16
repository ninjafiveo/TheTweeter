using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;


namespace TheTweeter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ChromeDriver drv; 
        Thread th;
        bool enter = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            drv = new ChromeDriver(service);
            drv.Navigate().GoToUrl("https://twitter.com/login");
    
        }

        private void Login(string username, string password)
        {
            start:
            if (drv.Url == "https://twitter.com/login")
            {
                drv.FindElementByName("session[username_or_email]").SendKeys(username);
                Thread.Sleep(10);
                drv.FindElementByName("session[password]").SendKeys(password);
                Thread.Sleep(50);
                drv.FindElement(By.XPath("//div[@class='css-18t94o4 css-1dbjc4n r-urgr8i r-42olwf r-sdzlij r-1phboty r-rs99b7 r-1w2pmg r-vlx1xi r-zg41ew r-1jayybb r-17bavie r-1ny4l3l r-15bsvpr r-o7ynqc r-6416eg r-lrvibr']")).Click();



                Thread.Sleep(5000);

            }
            else
            {
                drv.Navigate().GoToUrl("https://twitter.com/login");
                Thread.Sleep(4000);
                goto start;
            }
        }


        private void Tweet_RichTextBox_Enter(object sender, EventArgs e)
        {
            if (!enter)//false
            {
                Tweet_RichTextBox.Clear();
                Tweet_RichTextBox.Font = new Font("Times New Roman", 11, FontStyle.Regular);
                Tweet_RichTextBox.ForeColor = Color.Black;
                enter = true;

            }

        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            drv.Quit(); //Closes Browser Window when Form is closed. 
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Tweet_BTN_Click(object sender, EventArgs e)
        {
            Login(Username_TextBox.Text, Password_TextBox.Text);
        }
    }
}
