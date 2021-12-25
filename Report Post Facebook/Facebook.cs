using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

namespace Report_Post_Facebook
{
    class Facebook
    {
        public static DataGridView Dgvfacebook;
        private static void LoadStatusGrid(string status, string colname, int rowIndex, int typeColor, DataGridView gv)
        {
            gv.Invoke(new Action(() =>
            {
                gv.Rows[rowIndex].Cells[colname].Value = status;
            }));
        }
        private static void luotluotxuong(ChromeDriver chrome)
        {
            IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,500)");
        }
        public static string CheckIP()
        {
            HttpRequest https = new HttpRequest();
            string allip = https.Get("https://api64.ipify.org?format=json").ToString();
            string proxy = Regex.Match(allip, "ip\":\"(.*?)\"").Groups[1].ToString();
            return proxy;
        }

        public static string GetRandomImageFilePath(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath, "*.jpg", SearchOption.AllDirectories);
            Random random = new Random();
            return files[random.Next(0, files.Length - 1)];
        }
        public static string CheckURL(int row, ChromeDriver webDriver)
        {
            string url = webDriver.Url;
            string thongtin = "";
            if (url.Contains("checkpoint"))
            {
                thongtin = "Checkpoint";
            }
            return thongtin;
        }
        public static string GetCookie(ChromeDriver webDriver)
        {
            string text8 = "";
            Cookie[] array4 = webDriver.Manage().Cookies.AllCookies.ToArray();
            foreach (Cookie cookie in array4)
            {
                text8 = string.Concat(new string[] { text8, cookie.Name, "=", cookie.Value, ";" });
            }
            return text8;
        }
        public static string LoginFacebook_mfb(int row, string uid, string pass, string code2fa, ChromeDriver webDriver)
        {
            var checklive = "";
            try
            {
                webDriver.Navigate().GoToUrl("https://mbasic.facebook.com/home.php");
                Thread.Sleep(1200);
                var urls = webDriver.Url;
                if (urls == "https://mbasic.facebook.com/home.php")
                {
                    checklive = "Live";
                    return checklive;
                }
            }
            catch (Exception ex)
            {
            }
            try
            {
                webDriver.Navigate().GoToUrl("https://m.facebook.com/login/?next&ref=dbl&fl&refid=8"); // truy cập vào website
                Thread.Sleep(1200);
                webDriver.FindElement(By.Id("m_login_email")).SendKeys(uid); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.Id("m_login_password")).SendKeys(pass); //nhập password 
                Thread.Sleep(1200);
                LoadStatusGrid("Đăng nhập...", "Status", row, 2, Dgvfacebook);
                webDriver.FindElement(By.Name("login")).Click();  //bấm click
                Thread.Sleep(1200);
                Thread.Sleep(TimeSpan.FromSeconds(3));
                if (code2fa != "")
                {
                    try
                    {
                        code2fa = code2fa.Replace(" ", "");
                        HttpRequest http = new HttpRequest();
                        string order = http.Get("http://2fa.live/tok/" + code2fa).ToString();
                        string code = Regex.Match(order, @"\d{6}?").ToString();
                        try
                        {
                            webDriver.FindElement(By.Id("approvals_code")).SendKeys(code);
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                            webDriver.FindElement(By.Id("checkpointSubmitButton-actual-button")).Click();
                            Thread.Sleep(TimeSpan.FromSeconds(0.5));
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            catch (Exception ex)
            {
            }
            try
            {
                webDriver.Navigate().GoToUrl("https://mbasic.facebook.com/gettingstarted/"); // ĐI THỚI ĐỊA CHỈ ĐIỀN VÀO
                Thread.Sleep(1200);
                for (var i = 0; i <= 10; i++)
                {
                    webDriver.FindElement(By.XPath("/html/body/div/div/div/div/div[1]/table/tbody/tr/td[2]/table/tbody/tr/td/h3/a")).Click();
                    Thread.Sleep(300);
                }
            }
            catch (Exception ex)
            {
            }
            try
            {
                webDriver.Navigate().GoToUrl("https://m.facebook.com/home.php"); // ĐI THỚI ĐỊA CHỈ ĐIỀN VÀO
                Thread.Sleep(1200);
                var url = webDriver.Url;
                if (url != "https://m.facebook.com/home.php")
                {
                    LoadStatusGrid("Chưa đăng nhập !!", "status", row, 2, Dgvfacebook);
                    Dgvfacebook.Rows[row].DefaultCellStyle.BackColor = Color.Pink;
                    checklive = "Die";
                    webDriver.Quit();
                }
                if (url == "https://m.facebook.com/home.php")
                {
                    LoadStatusGrid("Đã đăng nhập !!", "status", row, 2, Dgvfacebook);
                    Dgvfacebook.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
                    checklive = "Live";
                }
                try
                {
                    if (url.Contains("/checkpoint/"))
                    {
                        LoadStatusGrid("Checkpoint !", "status", row, 2, Dgvfacebook);
                        Dgvfacebook.Rows[row].DefaultCellStyle.BackColor = Color.Pink;
                        checklive = "Checkpoint";
                        webDriver.Quit();
                    }
                }
                catch (Exception ex1)
                {
                }

            }
            catch (Exception ex2)
            {
            }
            return checklive;
        }

        public static void ReportFB(int row, string uid, ChromeDriver webDriver)
        {
            try
            {
                LoadStatusGrid("Đang vào id report !!", "Status", row, 2, Dgvfacebook);
                webDriver.Navigate().GoToUrl("https://mbasic.facebook.com/" + uid); // truy cập vào website
                Thread.Sleep(1200);
                webDriver.FindElement(By.XPath("/html/body/div/div/div[2]/div/div[1]/div[1]/div/footer/div[2]/a[2]")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.XPath("/html/body/div/div/div/div/table/tbody/tr/td/form/section/fieldset/label[4]/div/table/tbody/tr/td[1]/input")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.Name("submit")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.XPath("/html/body/div/div/div/div/table/tbody/tr/td/form/section/fieldset/label[7]/div/table/tbody/tr/td[1]/input")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.Name("action")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.XPath("/html/body/div/div/div/div/table/tbody/tr/td/form/section/fieldset/label[5]/div/table/tbody/tr/td[1]/input")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.Name("action")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.XPath("/html/body/div/div/div/div/table/tbody/tr/td/form/fieldset/label/div/table/tbody/tr/td[2]/input")).Click(); // nhâp username
                Thread.Sleep(1200);
                webDriver.FindElement(By.Name("action")).Click(); // nhâp username
                Thread.Sleep(1200);
                LoadStatusGrid("Report xong !!!", "Status", row, 2, Dgvfacebook);
            }
            catch
            {
                LoadStatusGrid("Report lỗi !!!", "Status", row, 2, Dgvfacebook);
                try
                {
                    webDriver.FindElement(By.Name("action")).Click(); // nhâp username
                    Thread.Sleep(1200);
                }
                catch { }
            }
        }

        public static string RunCMD(string cmd)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + cmd;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.Start();
            string text = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            string result;
            if (string.IsNullOrEmpty(text))
            {
                result = "";
            }
            else
            {
                result = text;
            }
            return result;
        }

    }
}
