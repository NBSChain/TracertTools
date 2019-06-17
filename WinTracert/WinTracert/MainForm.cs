using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WinTracert.Properties;
using WinTracert.Util;

namespace WinTracert
{
    public partial class MainForm : Form
    {
        public String isRun = "start";
        private String PREFIX = "tracert ";
        private const string regexStrIp4 = @"^(((2[0-4]\d|25[0-5]|[01]?\d\d?)\.){3}(2[0-4]\d|25[0-5]|[01]?\d\d?))$";

        private CmderUtil cmder = new CmderUtil();

        public MainForm()
        {
            InitializeComponent();
            initComponents();

            new Thread(new ThreadStart(SendCommands)).Start();
        }

        private void initComponents()
        {
            this.IPTips.Text = "";
            this.IPAddress.Text = "123.56.153.221";
            this.Icon = Icon.FromHandle(Resources.logo.GetHicon());
            this.TipsShow.Text = "";
        }

        private void SendCommands()
        {
            cmder.Tracert(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            if(cmder != null && cmder.Excuting)
            {
                MessageBox.Show("正在执行命令，不能关闭...");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                isRun = "stop";
                Thread.Sleep(1000);
                System.Environment.Exit(0);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IPAddress_TextChanged(object sender, EventArgs e)
        {
            bool b = validateIP();
            this.btnStart.Enabled = b;
        }

        private bool validateIP()
        {
            string ipText = IPAddress.Text.Trim();
            if (string.IsNullOrEmpty(ipText))
            {
                this.IPTips.Text = "IP 地址不能为空.";
                return false;
            }
            if (!Regex.IsMatch(ipText, regexStrIp4))
            {
                this.IPTips.Text = "IP 地址不正确.";
                return false;
            }
            this.IPTips.Text = "";
            return true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cmder.shell = PREFIX + this.IPAddress.Text.Trim();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
