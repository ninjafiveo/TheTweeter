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

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
