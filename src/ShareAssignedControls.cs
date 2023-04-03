/**********************************************************************/
/* Copyright (c) 2023 Carpe Diem Software Developing by Alex Versetty */
/**********************************************************************/

using System.Runtime.InteropServices;

namespace NetShareFreeSpace
{
    public class ShareAssignedControls
    {
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public string name;
        public Label labelName;
        public ProgressBar indicator;
        public Label labelFree;
        public Label labelTotal;
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.

        public void setDiskStats(ulong FreeBytes, ulong TotalBytes, ulong TotalFreeBytes)
        {
            if (TotalBytes == 0)
            {
                labelFree.Text = "";
            }
            else
            {
                SendMessage(indicator.Handle,
                    0x400 + 16, //WM_USER + PBM_SETSTATE
                    0x0001, //PBST_UNPAUSED
                    0);

                ulong busyBytes = TotalBytes - FreeBytes;
                indicator.Value = (int)(100F * busyBytes / TotalBytes);

                double freeGB = Math.Round(1d * FreeBytes / 1024 / 1024 / 1024, 1, MidpointRounding.ToNegativeInfinity);
                double totalGB = Math.Round(1d * TotalBytes / 1024 / 1024 / 1024, 1, MidpointRounding.ToNegativeInfinity);
                labelFree.Text = $"{freeGB,10:0.0} ГБ";
                labelTotal.Text = $"{totalGB,10:0.0} ГБ";

                SendMessage(indicator.Handle,
                    0x400 + 16, //WM_USER + PBM_SETSTATE
                    0x0003, //PBST_PAUSED
                    0);
            }
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern uint SendMessage(IntPtr hWnd, uint Msg, uint wParam, uint lParam);
    }
}
