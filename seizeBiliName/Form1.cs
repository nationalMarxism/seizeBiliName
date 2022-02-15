using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace seizeBiliName
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            AimName.Items.Clear();
            Ini ini = new Ini("./data.ini");
            Data.number = int.Parse(ini.IniRead("AimName", "number"));

            for (int i = 0; i < Data.number; i++)
            {
                Data.name[i] = ini.IniRead("AimName", "_" + i);

                AimName.Items.Add(Data.name[i]);
            }
        }

        public string Send(string name)
        {
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create("https://passport.bilibili.com/web/generic/check/nickname?nickName="+name);
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Method = "GET";
                httpWebRequest.Timeout = 2000;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.Default);
                string responseContent = streamReader.ReadToEnd();
                streamReader.Close();
                httpWebResponse.Close();
                httpWebRequest.Abort();
                return responseContent;
            }
            catch
            {
                state.Text = "网络出现异常";
                state.ForeColor = Color.Red;

                if (hide.Checked)
                {
                    WindowState = FormWindowState.Normal;
                    ShowInTaskbar = true;
                }
            }
            return "Error";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("添加用户名不能为空");
                return;
            }

            Ini ini = new Ini("./data.ini");
            ini.IniWrite("AimName", "_" + Data.number, textBox1.Text);
            Data.number++;
            ini.IniWrite("AimName", "number", Data.number.ToString());
            Reset();
            textBox1.Clear();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (AimName.SelectedIndex==-1)
            {
                MessageBox.Show("未选中任何项");
                return;
            }

            Ini ini = new Ini("./data.ini");
            Data.number--;
            ini.IniWrite("AimName", "number", Data.number.ToString());
            ini.IniWrite("AimName", "_"+AimName.SelectedIndex, null);
            for (int i = AimName.SelectedIndex; i < Data.number; i++)
            {
                string ls = ini.IniRead("AimName", "_"+(i+1).ToString());
                ini.IniWrite("AimName", "_"+i, ls);
            }
            ini.IniWrite("AimName", "_" + Data.number, null);
            Reset();
        }

        void SendEmail(int i)
        {
            try
            {
                MailMessage msg = new MailMessage();
                msg.To.Add(Data.emailAddress);
                msg.From = new MailAddress(Data.emailAddress, "myself", System.Text.Encoding.UTF8);
                msg.Subject = "b站昵称可用";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                if (i==-1)
                {
                    msg.Body = "测试邮件";
                }
                else
                {
                    msg.Body = "可用昵称为" + Data.name[i];
                }
                msg.BodyEncoding = System.Text.Encoding.UTF8; 
                msg.IsBodyHtml = false;  
                msg.Priority = MailPriority.High; 
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(Data.emailAddress, Data.emailKey);
                client.Host = Data.emailSmtpHost;
                object userState = msg;
                client.SendAsync(msg, userState);
            }
            catch
            {
                email.Text = "邮件发送失败";
                email.ForeColor = Color.Red;

                if (hide.Checked)
                {
                    WindowState = FormWindowState.Normal;
                    ShowInTaskbar = true;
                }
            }
        }

        bool CheckResetShow(string data,int id)
        {
            if (data == "{\"code\":0}")
            {
                for (int allowName = 0; allowName < AllowName.Items.Count; allowName++)
                {
                    if (AllowName.Items[allowName].ToString() == Data.name[id])
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void check_Tick(object sender, EventArgs e)
        {
            check.Enabled = false;
            for (int i = 0; i < Data.number; i++)
            {
                string data=Send(Data.name[i]);
                //Thread.Sleep(50);
                string dataTest = Send(Data.name[i]);
                if (data==dataTest)
                {
                    if (CheckResetShow(data, i))
                    {
                        AllowName.Items.Add(Data.name[i]);
                        if (ifSendEmail.Checked)
                        {
                            SendEmail(i);
                        }

                        if (hide.Checked)
                        {
                            WindowState = FormWindowState.Normal;
                            ShowInTaskbar = true;
                        }
                    }
                }

            }
            check.Enabled = true;
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (hide.Checked)
            {
                WindowState = FormWindowState.Minimized;
                ShowInTaskbar = false;
            }
            label1.Text = "已开始";
            check.Enabled = true;
        }

        private void over_Click(object sender, EventArgs e)
        {
            label1.Text = "已结束";
            check.Enabled = false;
        }

        private void checkEmail_Click(object sender, EventArgs e)
        {
            SendEmail(-1);
        }

        private void e_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
