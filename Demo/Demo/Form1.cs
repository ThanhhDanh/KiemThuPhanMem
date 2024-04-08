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

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cách 1
            //Điều hướng trình duyệt
            //Le Thanh Danh_18
            IWebDriver Danh_18 = new ChromeDriver();
            Danh_18.Navigate().GoToUrl("https://shopee.vn/");

            //Cách 2
         /*   IWebDriver dr = new ChromeDriver();
            dr.Url = "https://shopee.vn/";
            dr.Navigate();*/
        }
    }
}
