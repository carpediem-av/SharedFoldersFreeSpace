/**********************************************************************/
/* Copyright (c) 2023 Carpe Diem Software Developing by Alex Versetty */
/**********************************************************************/

using Common;
using SharedFoldersFreeSpace.Properties;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace NetShareFreeSpace
{
    public partial class Form1 : Form
    {
        List<ShareAssignedControls> shareAssignedControlsList = new List<ShareAssignedControls>();
        string servername = "localhost";

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

        public Form1()
        {
            Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args.Count() > 1)
            {
                labelServer.Hide();
                tbServer.Hide();
                submit.Hide();

                servername = args[1];
                Text = servername;
                var shareList = getServerShares(servername);
                foreach (var x in shareList) AddShare(x);
                updateDiskStats();
                recalcSizes();
            }
            else
            {
                tableLayoutPanel1.Hide();
            }
        }

        void updateDiskStats()
        {
            foreach (var s in shareAssignedControlsList)
            {
                ulong FreeBytes;
                ulong TotalBytes;
                ulong TotalFreeBytes;

                bool success = GetDiskFreeSpaceEx($@"\\{servername}\{s.name}", out FreeBytes, out TotalBytes, out TotalFreeBytes);

                if (!success)
                {
                    //throw new System.ComponentModel.Win32Exception();
                    s.setDiskStats(0, 0, 0);
                }
                else
                {
                    s.setDiskStats(FreeBytes, TotalBytes, TotalFreeBytes);
                }
            }
        }

        private void recalcSizes()
        {
            for (int i = 1; i < tableLayoutPanel1.RowCount; i++) tableLayoutPanel1.RowStyles[i].SizeType = SizeType.AutoSize;
            foreach (ColumnStyle x in tableLayoutPanel1.ColumnStyles) x.SizeType = SizeType.AutoSize;

            var colWidths = tableLayoutPanel1.GetColumnWidths();
            var rowHeights = tableLayoutPanel1.GetRowHeights();
            var totalHeight = 0;
            foreach (var x in rowHeights) totalHeight += x;

            ClientSize = tableLayoutPanel1.Size = new Size(colWidths[0] + colWidths[1] + colWidths[2] + colWidths[3] + 15, totalHeight + 50);
        }

        private void AddShare(string name)
        {
            var s = new ShareAssignedControls()
            {
                name = name,
                labelName = new Label() { Text = name, AutoSize = true },
                indicator = new ProgressBar() { Height = 13, Width = 130 },
                labelFree = new Label() { Text = "", AutoSize = true, Font = new Font("Lucida Console", 9F), Margin = new Padding(0, 5, 0, 5) },
                labelTotal = new Label() { Text = "", AutoSize = true, Font = new Font("Lucida Console", 9F), Margin = new Padding(0, 5, 0, 5) }
            };
            shareAssignedControlsList.Add(s);

            var row = shareAssignedControlsList.Count + 1;
            tableLayoutPanel1.Controls.Add(s.labelName, 0, row);
            tableLayoutPanel1.Controls.Add(s.indicator, 1, row);
            tableLayoutPanel1.Controls.Add(s.labelFree, 2, row);
            tableLayoutPanel1.Controls.Add(s.labelTotal, 3, row);
        }

        static List<string> getServerShares(string servername)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            cmd.Start();
            cmd.StandardInput.WriteLine("net view \\\\" + servername);
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            string output = cmd.StandardOutput.ReadToEnd();
            cmd.WaitForExit();
            cmd.Close();

            List<string> dirlist = new List<string>();

            if (output.Contains("Диск"))
            {
                Regex rg = new Regex("(.+)(\\s+Диск)");
                var matches = rg.Matches(output);

                foreach (Match m in matches)
                {
                    dirlist.Add(m.Groups[1].Value.TrimEnd());
                }
            }
            else if (output.Contains("Disk"))
            {
                Regex rg = new Regex("(.+)(\\s+Disk)");
                var matches = rg.Matches(output);

                foreach (Match m in matches)
                {
                    dirlist.Add(m.Groups[1].Value.TrimEnd());
                }
            }

            return dirlist;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            updateDiskStats();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbServer.Text)) return;

            labelServer.Hide();
            tbServer.Hide();
            submit.Hide();
            tableLayoutPanel1.Show();

            servername = tbServer.Text.Trim();
            Text = servername;
            var shareList = getServerShares(servername);
            foreach (var x in shareList) AddShare(x);
            updateDiskStats();
            recalcSizes();
        }

        private void about_Click(object sender, EventArgs e)
        {
            new FAbout().ShowDialog();
        }
    }
}
