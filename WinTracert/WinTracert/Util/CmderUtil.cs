using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;



/**
 * ┌───────────────────────────────────────────────────────────────────────┐
 * │Project	: WinTracert.Util
 * │Comment	:
 * │
 * │Version	: V1.0.0.0
 * │Author		: 
 * │CreatTime	: 2019/6/17 18:58:35													
 * ├───────────────────────────────────────────────────────────────────────┤
 * │Copyright © UTech Team 2015-2019. All rights reserved.
 * └───────────────────────────────────────────────────────────────────────┘
 */


namespace WinTracert.Util
{
    public class CmderUtil
    {

        public String shell = "";
        private bool isExcuting = false;
        public String currentPID = string.Empty;

        public bool Excuting { get { return isExcuting; } }

        public void Tracert(MainForm mf)
        {
            Process p = null;
            if (p == null)
            {
                p = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                startInfo.Arguments = "";//
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardInput = true;
                startInfo.RedirectStandardOutput = true;
                startInfo.CreateNoWindow = true;
                p.StartInfo = startInfo;
                
            }

            if (p.Start())
            {
                p.StandardOutput.ReadLine().Trim();
                p.StandardOutput.ReadLine().Trim();

                while (mf.isRun.IndexOf("start") != -1)
                {
                    if(shell.Length > 0)
                    {
                        p.StandardInput.WriteLine(shell);
                        p.StandardInput.AutoFlush = true;
                        isExcuting = true;
                        changedFormBtn(mf, false);
                        changedTips(mf, "tracert is running...");

                        p.StandardOutput.ReadLine();
                        
                        p.StandardInput.WriteLine("\n");
                        String log = p.StandardOutput.ReadLine().Trim();
                        String path = log.Substring(0, 2).ToUpper();
                        string ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        updateLog(mf, ts+"\n"+log);
                        log = "";
                        
                        while (true)
                        {
                            String logm = p.StandardOutput.ReadLine().Trim();
                            if(logm.IndexOf(path) != -1)
                            {
                                //处理界面
                                changedTips(mf,"tracert completed.");
                                changedFormBtn(mf, true);
                                isExcuting = false;
                                break;
                            }
                            updateLog(mf, logm);
                            log += logm;
                        }
                        shell = "";

                    }
                }
                changedTips(mf, "commander is stop.");
                p.Dispose();
                p.Close();
                p = null;
                return;
            }

            return;
        }

        /// <summary>
        /// 
        /// </summary>
        private delegate void UpdateLog();
        private void updateLog(MainForm mf,String text)
        {
            UpdateLog logSet = delegate ()
            {
                mf.richTextBoxLog.AppendText("\n"+text);
            };
            mf.Invoke(logSet);
        }

        /// <summary>
        /// 更新Tips
        /// </summary>
        private delegate void ChangedTips();
        private void changedTips(MainForm mf,String text)
        {
            ChangedTips tipSet = delegate ()
            {
                mf.TipsShow.Text = text;
            };

            mf.Invoke(tipSet);

        }

        /// <summary>
        /// 
        /// </summary>
        private delegate void ChangedFormBtn();
        private void changedFormBtn(MainForm mf,bool enable)
        {
            ChangedFormBtn btnSet = delegate ()
            {
                mf.btnStart.Enabled = enable;
            };
            mf.Invoke(btnSet);
        }
    }
}
