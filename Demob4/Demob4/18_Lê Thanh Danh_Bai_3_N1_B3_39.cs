using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Demob4
{
    public partial class Form1 : Form
    {
        public string url { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnURL_Click(object sender, EventArgs e)
        {
            //Nhập link vào url và điều hướng navigate để mở trang url đã nhập
            /* string url;
             IWebDriver Danh_18 = new ChromeDriver();
             url = txtURL.Text;
             Danh_18.Navigate().GoToUrl(url);*/
             

            //Đóng cmd
            //Câu 1d
            string url;
            ChromeDriverService TDanh_18  = ChromeDriverService.CreateDefaultService();
            TDanh_18.HideCommandPromptWindow = true;
            IWebDriver LTDanh_18 = new ChromeDriver(TDanh_18);
            url = txtURL.Text;
            LTDanh_18.Navigate().GoToUrl(url);
            //câu 1c:
            /*LTDanh_18.Close();*/
            //Câu 1e
          /*  LTDanh_18.Quit();*/

            //Câu 1f
            String ltdanh_18_link = LTDanh_18.Url;
            Console.WriteLine(ltdanh_18_link);
            //Câu 1g
            String ltdanh_18_title = LTDanh_18.Title;
            Console.WriteLine(ltdanh_18_title);
            txtTitle.Text = ltdanh_18_title;
            //Câu 1h
            String ltdanh_18_PS = LTDanh_18.PageSource;
            Console.WriteLine(ltdanh_18_PS);
            //Câu 1i
            Thread.Sleep(5000);
            LTDanh_18.Navigate().Back();
            Thread.Sleep(5000);
            LTDanh_18.Navigate().Forward();
            Thread.Sleep(2000);
            LTDanh_18.Navigate().Refresh();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
