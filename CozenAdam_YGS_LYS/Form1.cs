using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CozenAdam_YGS_LYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[,] uye = { {"example@gmail.com","123456"},{"example2@gmail.com","123456"}};
        private void Form1_Load(object sender, EventArgs e)
        {
            cbKitap.SelectedIndex = 0;
            wb1.Navigate("https://www.cozenadam.com/uye/cikis");
            Thread.Sleep(900); // bunları yükseltirsen garanti olur. İnternet hızına göre.
            wb1.Navigate("https://www.cozenadam.com/uye/giris");
            Thread.Sleep(900);
            
            
        }

        private void btnCozum_Click(object sender, EventArgs e)
        {
            Giris();
            

        }
        void SoruyaGit()
        {
            wb1.Navigate("https://www.cozenadam.com/sorucozumu/6-4-" + txtSayfa.Text + "-" + txtSoru.Text);
        }
        void Cikis()
        {
                wb1.Navigate("https://www.cozenadam.com/uye/cikis");
                wb1.Navigate("https://www.cozenadam.com/uye/giris");
        }
        void OnlyCikis()
        {
            wb1.Navigate("https://www.cozenadam.com/uye/cikis");
        }
        void OnlyGiris()
        {
            wb1.Navigate("https://www.cozenadam.com/uye/giris");
        }
        void KalanAl()
        {
            HtmlElementCollection el = wb1.Document.GetElementsByTagName("i");
            foreach (var item in el)
            {
                listBox1.Items.Add(item.ToString());
            }
           
        }
        void Giris()
        {
            for (int i = 0; i < (uye.Length/2); i++)
            {
                
                wb1.Navigate("https://www.cozenadam.com/uye/cikis");
                MessageBox.Show("Giriş Yapılıyor.1..");
                wb1.Navigate("https://www.cozenadam.com/uye/giris");
                MessageBox.Show("Giriş Yapılıyor.2..");
               // MessageBox.Show(wb1.Url.AbsoluteUri);
                if (wb1.Url.AbsoluteUri == "https://www.cozenadam.com/uye/giris")
                {
                    wb1.Document.GetElementById("3gom").Focus();
                    wb1.Document.GetElementById("3gom").InnerText = uye[i, 0];
                    wb1.Document.GetElementById("0h4x").Focus();
                    wb1.Document.GetElementById("0h4x").InnerText = uye[i, 1];
                    wb1.Document.GetElementById("submit-sign-in").InvokeMember("click");
                }
                else { i--; }
                MessageBox.Show("Giriş Yapılıyor.3..");
                Thread.Sleep(800);
                SoruyaGit();
               // MessageBox.Show(wb1.Url.AbsoluteUri);
                Thread.Sleep(800);
                MessageBox.Show("Loading...");
                if (wb1.Url.AbsoluteUri == "https://www.cozenadam.com/abone" || wb1.Url.AbsoluteUri == "https://www.cozenadam.com/sorucozumu/6-4-" + txtSayfa.Text + "-" + txtSoru.Text) break; // messagebox filan çıkarınca düzeliyor.

                

            } 

            
        }
        void sa()
        {
            //gereksiz
            foreach (HtmlElement item in wb1.Document.GetElementsByTagName("i"))
            {
                if (item.OuterHtml.Contains("page_item"))
                {
                    foreach (HtmlElement childItem in item.Children)
                    {
                        if (childItem.TagName == "A")
                        {
                            //Click the link/Current element
                            childItem.InvokeMember("Click");
                            break;
                        }
                    }
                    break;
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KalanAl();
        }
    }
}
