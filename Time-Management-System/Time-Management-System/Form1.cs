using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Management_System
{
    public partial class frm_mainWindow : Form
    {
        public frm_mainWindow()
        {
            InitializeComponent();
        }

        private void frm_mainWindow_Resize(object sender, EventArgs e)
        {
            /*  using the Resize Event so that when the form is minized, 
             *  it will minimize it to the system tray.
             */
            notifyIcon.BalloonTipTitle = "Time Management System";
            notifyIcon.BalloonTipText = "You have successfully minimized the application.";

            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(500);
                this.Hide();

            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void frm_mainWindow_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Information;
        }
    }
}
