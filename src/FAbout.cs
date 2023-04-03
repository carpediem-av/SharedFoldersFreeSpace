/**********************************************************************/
/* Copyright (c) 2023 Carpe Diem Software Developing by Alex Versetty */
/**********************************************************************/

using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Common
{
    public partial class FAbout : Form
    {
        public FAbout()
        {
            InitializeComponent();
        }

        private void www_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenUrl("http://carpediem.0fees.us");
        }

        private void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
