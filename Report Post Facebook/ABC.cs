using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
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
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.IO;
using xNet;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Report_Post_Facebook
{
    public partial class REG : Form
    {
        public REG()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        private void LoadStatusGrid(string status, string colname, int rowIndex, int typeColor, DataGridView gv)
        {
            gv.Invoke(new Action(() =>
            {
                gv.Rows[rowIndex].Cells[colname].Value = status;
            }));
        }
        private string PointLocationBrowser(int CountIndex, int checkload)
        {
            string toado = "";
            int i = 0;
            if (checkload == 0)
            {
                toado = "15,10";
            }
            if (checkload == 1)
            {
                toado = "265,10";
            }
            if (checkload == 2)
            {
                toado = "517,10";
            }
            if (checkload == 3)
            {
                toado = "778,10";
            }
            if (checkload == 4)
            {
                toado = "1025,10";
            }
            if (checkload == 5)
            {
                toado = "1287,10";
            }
            if (checkload == 6)
            {
                toado = "15,265";
            }
            if (checkload == 7)
            {
                toado = "265,265";
            }
            if (checkload == 8)
            {
                toado = "517,265";
            }
            if (checkload == 9)
            {
                toado = "778,265";
            }
            if (checkload == 10)
            {
                toado = "1025,265";
            }
            if (checkload == 11)
            {
                toado = "1287,265";
            }
            if (checkload == 12)
            {
                toado = "15,517";
            }
            if (checkload == 13)
            {
                toado = "265,517";
            }
            if (checkload == 14)
            {
                toado = "517,517";
            }
            if (checkload == 15)
            {
                toado = "778,517";
            }
            if (checkload == 16)
            {
                toado = "1025,517";
            }
            if (checkload == 17)
            {
                toado = "1287,517";
            }
            if (checkload == 18)
            {
                toado = "15,778";
            }
            if (checkload == 19)
            {
                toado = "265,778";
            }
            if (checkload == 20)
            {
                toado = "517,778";
            }
            if (checkload == 21)
            {
                toado = "778,778";
            }
            if (checkload == 22)
            {
                toado = "1025,778";
            }
            if (checkload == 23)
            {
                toado = "1287,778";
            }
            return toado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facebook.Dgvfacebook = DGVLD;
            isStop = false;
            int i = 0;
            int iThread = 0;
            var soluong = Convert.ToInt32(luong.Value);
            int Multi_Thread = soluong;
            (new Thread(() =>
            {
                    while (i < (DGVLD.Rows.Count))
                    {
                        if (iThread < Multi_Thread)
                        {
                            if (isStop == true)
                            {
                                return;
                            }
                            Interlocked.Increment(ref iThread);
                            int row = i;
                            (new Thread(() =>
                            {
                                DataGridViewRow r = DGVLD.Rows[row];
                                try
                                {
                                    Run(row);
                                }
                                catch (Exception loi)
                                {
                                    DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.LightPink;
                                    LoadStatusGrid(loi.ToString(), "status", row, 2, DGVLD);
                                }
                                Interlocked.Decrement(ref iThread);
                            })).Start();
                            i += 1;
                        }
                        else
                            Thread.Sleep(100);
                        if (isStop == true)
                        {
                            return;
                        }
                }
            })).Start();
        }
        private void Run(int row)
        {
            DataGridViewRow r = DGVLD.Rows[row];
            string LoadRow = (r.Cells["LoadRow"].Value == null) ? "" : r.Cells["LoadRow"].Value.ToString();
            string Username = (r.Cells["Username"].Value == null) ? "" : r.Cells["Username"].Value.ToString();
            string Password = (r.Cells["Password"].Value == null) ? "" : r.Cells["Password"].Value.ToString();
            string Mabaomat = (r.Cells["Mabaomat"].Value == null) ? "" : r.Cells["Mabaomat"].Value.ToString();
            string FBCOOKIE = (r.Cells["Cookiefb"].Value == null) ? "" : r.Cells["Cookiefb"].Value.ToString();
            if (FBCOOKIE != "")
            {
                goto LoadSpam123;
            }
            DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.LightGreen;
            ChromeDriverService ChromeDriverService = ChromeDriverService.CreateDefaultService();
            ChromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            string pointload = PointLocationBrowser(row, Int32.Parse(LoadRow));
            if (pointload == null)
            {
                pointload = "0,0";
            }
            //chromeOptions.AddArgument("user-data-dir=" + Application.StartupPath + "\\Profile\\" + Username);
            chromeOptions.AddArgument("--window-position=" + pointload);
            chromeOptions.AddArgument("--app=" + "https://mbasic.facebook.com/home.php");
            chromeOptions.AddArguments(new string[]
{
                "--enable-automation"
});
            //chromeOptions.AddAdditionalCapability("useAutomationExtension", false);
            chromeOptions.AddArguments(new string[]
            {
                "--disable-notifications"
            });
            chromeOptions.AddArgument("--blink-settings=imagesEnabled=false");
            chromeOptions.AddArguments(new string[]
            {
                "--enable-application-cache"
            });
            chromeOptions.AddArguments(new string[]
            {
                "--disable-popup-blocking"
            });
            chromeOptions.AddArguments(new string[]
            {
                "--disable-geolocation"
            });
            chromeOptions.AddArguments(new string[]
            {
                "--no-sandbox"
            });
            chromeOptions.AddArguments(new string[]
            {
                "--disable-gpu"
            });
            chromeOptions.AddArguments(new string[]
            {
                "--window-size=450,450"
            });
            chromeOptions.AddArgument("--lang=vi");
            chromeOptions.AddArgument("--disable-ipv6");
            chromeOptions.AddArgument("--disable-dev-shm-usage");
            chromeOptions.AddArgument("--disable-impl-side-painting");
            chromeOptions.AddArgument("--disable-setuid-sandbox");
            chromeOptions.AddArgument("--disable-seccomp-filter-sandbox");
            chromeOptions.AddArgument("--disable-breakpad");
            chromeOptions.AddArgument("--disable-client-side-phishing-detection");
            chromeOptions.AddArgument("--disable-cast");
            chromeOptions.AddArgument("--disable-cast-streaming-hw-encoding");
            chromeOptions.AddArgument("--disable-cloud-import");
            chromeOptions.AddArgument("--disable-popup-blocking");
            chromeOptions.AddArgument("--ignore-certificate-errors");
            chromeOptions.AddArgument("--disable-session-crashed-bubble");
            chromeOptions.AddArgument("--allow-http-screen-capture");
            chromeOptions.AddArgument("--start-maximized");
            ChromeDriver webDriver = null;
            try
            {
                webDriver = new ChromeDriver(ChromeDriverService, chromeOptions);
            }
            catch (Exception loi)
            {
                LoadStatusGrid("Lỗi mở chrome ....", "status", row, 2, DGVLD);
                return;
            }
            LoadStatusGrid("Đang login facebook ....", "status", row, 2, DGVLD);
            string checkfb = Facebook.LoginFacebook_mfb(row, Username, Password, Mabaomat, webDriver);
            if (checkfb == "Live")
            {
                LoadStatusGrid("Nick fb đã được đăng nhập ....", "status", row, 2, DGVLD);
            }
            if (checkfb == "Checkpoint")
            {
                LoadStatusGrid("Nick đã bị checkpoint !!!", "status", row, 2, DGVLD);
                webDriver.Quit();
                return;
            }
            if (checkfb == "Die")
            {
                LoadStatusGrid("Nick fb chưa đăng nhập ....", "status", row, 2, DGVLD);
                webDriver.Quit();
                return;
            }
            //FBCOOKIE = Facebook.GetCookie(webDriver);
            //LoadStatusGrid(FBCOOKIE, "Cookiefb", row, 2, DGVLD);
            Facebook.ReportFB(row, UIDPOST.Text, webDriver);
            webDriver.Quit();
            LoadSpam123:       
            return;
        }
        private void CommentSpam(int row,string cookiefb, string uid,string noidung)
        {
            LoadStatusGrid("Đang chuẩn bị comment !!!", "status", row, 2, DGVLD);
            HttpRequest https = new HttpRequest();
            https.AddHeader("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            //https.AddHeader("accept-encoding", "gzip,deflate,br");
            https.AddHeader("accept-language", "vi-VN,vi;q=0.9,fr-FR;q=0.8,fr;q=0.7,en-US;q=0.6,en;q=0.5");
            https.AddHeader("cache-control", "max-age=0");
            https.AddHeader("cookie", cookiefb);
            //https.AddHeader("sec-ch-ua", "\"NotA;Brand\";v=\"99\",\"Chromium\";v=\"96\",\"GoogleChrome\";v=\"96\"");
            https.AddHeader("sec-ch-ua-mobile", "?0");
            //https.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            https.AddHeader("sec-fetch-dest", "document");
            https.AddHeader("sec-fetch-mode", "navigate");
            https.AddHeader("sec-fetch-site", "same-origin");
            https.AddHeader("sec-fetch-user", "?1");
            https.AddHeader("upgrade-insecure-requests", "1");
            https.UserAgent = "Mozilla/5.0(WindowsNT10.0;Win64;x64)AppleWebKit/537.36(KHTML,likeGecko)Chrome/96.0.4664.110Safari/537.36";
            string gettoken = https.Get("https://business.facebook.com/business_locations/").ToString();
            gettoken = gettoken.Replace("[", "");
            string token = Regex.Match(gettoken, ",\"EAAG(.*?)\",\"").Groups[1].ToString();
            if (token == "")
            {
                LoadStatusGrid("Không get được token !!", "status", row, 2, DGVLD);
                LoadStatusGrid("null", "Tokenfb", row, 2, DGVLD);
                return;
            }
            else
            {
            }
            string fulltoken = "EAAG" + token;
            LoadStatusGrid(fulltoken, "Tokenfb", row, 2, DGVLD);
            string nd = RandomString(10);
            LoadStatusGrid("Đang comment nội dung: " + nd, "status", row, 2, DGVLD);
            string getcomment = Get("https://graph.facebook.com/" + uid  +"/comments?access_token=" + fulltoken + "&method=post&message=" + nd);
            string id = Regex.Match(getcomment, "id\": \"(.*?)\"").Groups[1].ToString();
            if (getcomment.Contains("limit"))
            {
                LoadStatusGrid("Comment bị limit !!!", "status", row, 2, DGVLD);
                DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.Red;
                return;
            }
            if (id == "")
            {
                LoadStatusGrid("Comment thất bại !!!", "status", row, 2, DGVLD);
                DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.Red;
                return;
            }
            else
            {
                LoadStatusGrid("Comment thành công !!", "status", row, 2, DGVLD);
                DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }
            //WebRequest request = WebRequest.Create("https://graph.facebook.com/v13.0/" + id + "?access_token=" + fulltoken);
            //request.Method = "DELETE";
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string check123 = Delete("https://graph.facebook.com/v13.0/" + id + "?access_token=" + fulltoken);
            if (check123.Contains("success"))
            {
                LoadStatusGrid("Xóa thành công !!", "status", row, 2, DGVLD);
                DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.LightSkyBlue;
            }
            else
            {
                LoadStatusGrid("Xóa thất bại !!!", "status", row, 2, DGVLD);
                DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.Red;
            }
            //File.WriteAllText("Data.html", gettoken);
            //Process.Start("Data.html");
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&*qwertyuiopasdfghjklzxcvbnmm";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #region Request

        public HttpResponseHeaders headers { get; set; }
        string Delete(string url)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            HttpClient client = new HttpClient(handler);

            HeaderSite(ref client);

            var res = client.DeleteAsync(url).Result;
            var buffer = res.Content.ReadAsByteArrayAsync().Result;
            var byteArray = buffer.ToArray();
            var responseString = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
            return responseString;
        }
        string Get(string url)
        {
            HttpClientHandler handler = new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            HttpClient client = new HttpClient(handler);

            HeaderSite(ref client);

            var res = client.GetAsync(url).Result;
            var buffer = res.Content.ReadAsByteArrayAsync().Result;
            var byteArray = buffer.ToArray();
            var responseString = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
            return responseString;
        }

        void HeaderSite(ref HttpClient client)
        {
            client.DefaultRequestHeaders.TryAddWithoutValidation("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.TryAddWithoutValidation("upgrade-insecure-requests", "1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("content-type", "application/x-www-form-urlencoded");
            client.DefaultRequestHeaders.TryAddWithoutValidation("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/94.0.4606.81 Safari/537.36");
            client.DefaultRequestHeaders.TryAddWithoutValidation("accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
            client.DefaultRequestHeaders.TryAddWithoutValidation("sec-fetch-site", "same-origin");
            client.DefaultRequestHeaders.TryAddWithoutValidation("sec-fetch-mode", "navigate");
            client.DefaultRequestHeaders.TryAddWithoutValidation("sec-fetch-user", "?1");
            client.DefaultRequestHeaders.TryAddWithoutValidation("sec-fetch-dest", "document");
            client.DefaultRequestHeaders.TryAddWithoutValidation("accept-language", "en-US,en;q=0.9,vi;q=0.8");
        }

        #endregion

        private void opentab(ChromeDriver chrome)
        {
            IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
            js.ExecuteScript("window.open();");
        }
        private void luotluotxuong(ChromeDriver chrome)
        {
            IJavaScriptExecutor js = chrome as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,25)");
        }
        int check = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
                
        }
        bool isStop = false;
        private void button2_Click(object sender, EventArgs e)
        {
            isStop = true;
            MessageBox.Show("Chờ các luồng chạy xong sẽ dừng !!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("Data.txt");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete("DataProxy.txt");
            }
            catch
            {
            }
            string load = Clipboard.GetText();
            File.WriteAllText("DataProxy.txt", load);
            string[] Fileload = File.ReadAllLines("DataProxy.txt");
            int tongfile = Fileload.Length;
            int tongrow = DGVLD.Rows.Count;
            int check = 0;
            for (int row = 0; row < tongrow; row++)
            {
                if (check >= tongfile)
                {
                    goto tieptuc;
                }
                LoadStatusGrid(Fileload[check], "Proxys", row, 2, DGVLD);
                check = check + 1;
            }
        tieptuc:
            try
            {
                File.Delete("DataProxy.txt");
            }
            catch
            {
            }
            MessageBox.Show("Đã thêm " + tongfile.ToString() + " proxy !!!");
        }

        private void thêmTàiKhoảngFacebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    File.Delete("data.txt");
                }
                catch
                {
                }
                string load = Clipboard.GetText();
                File.WriteAllText("data.txt", load);
                var load123 = File.ReadAllLines("data.txt");
                int xuantruong = load123.Length;
                for (int row = 0; row < xuantruong; row++)
                {
                    string[] paste = load123[row].Split('|');
                    int myRowIndex = DGVLD.Rows.Add();
                    if (check % 23 == 0)
                    {
                        check = 0;
                    }
                    if (check == 0)
                    {
                        check = 0;
                    }
                    check = check + 1;
                    DGVLD.Rows[myRowIndex].Cells["LoadRow"].Value = check;
                    DGVLD.Rows[myRowIndex].Cells["STT"].Value = DGVLD.Rows.Count;
                    DGVLD.Rows[myRowIndex].Cells["Username"].Value = paste[0].ToString();
                    DGVLD.Rows[myRowIndex].Cells["Password"].Value = paste[1].ToString();
                    try
                    {
                        DGVLD.Rows[myRowIndex].Cells["Mabaomat"].Value = paste[2].ToString();
                    }
                    catch { }
                }
                try
                {
                    File.Delete("data.txt");
                }
                catch
                {
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được dữ liệu vui lòng xem lại !!", "");
            }
        }

        private void xóaTấtCảNickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGVLD.Rows.Clear();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void DGVLD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int row = DGVLD.CurrentRow.Index;
            //DataGridViewRow r = DGVLD.Rows[row];
            //Facebook.Dgvfacebook = DGVLD;
            //if (e.ColumnIndex == 8)
            //{
            //    (new Thread(() =>
            //    {
            //        try
            //        {
            //            Run(row);
            //        }
            //        catch (Exception loi)
            //        {
            //            DGVLD.Rows[row].DefaultCellStyle.BackColor = Color.LightPink;
            //            LoadStatusGrid(loi.ToString(), "status", row, 2, DGVLD);
            //        }
            //    })).Start();
            //}
        }
        private void button6_Click(object sender, EventArgs e)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
            File.Delete("DataFacebook.json");
            List<Thongtin> thongtins = new List<Thongtin>();
            List<DataGridViewRow> rows = DGVLD.Rows.Cast<DataGridViewRow>().ToList();
            if (rows != null)
            {
                rows.ForEach(row => thongtins.Add(new Thongtin
                {
                    LoadRow = Convert.ToString(row.Cells["LoadRow"].Value),
                    STT = Convert.ToString(row.Cells["STT"].Value),
                    Username = Convert.ToString(row.Cells["Username"].Value),
                    Password = Convert.ToString(row.Cells["Password"].Value),
                    Mabaomat = Convert.ToString(row.Cells["Mabaomat"].Value),
                    Proxys = Convert.ToString(row.Cells["Proxys"].Value),
                }));
                var json = JsonConvert.SerializeObject(thongtins);
                File.AppendAllText("DataFacebook.json", json);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                Process.Start("DataCmt.txt");
            }
            catch
            {
                File.CreateText("DataCmt.txt");
                Process.Start("DataCmt.txt");
            }

        }
    }
}
