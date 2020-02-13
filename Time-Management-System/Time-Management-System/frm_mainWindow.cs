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
                notifyIcon.Visible = true; // make the system-tray icon to be visible
                notifyIcon.ShowBalloonTip(100); // timeout time of the notification
                this.Hide(); // hide the Main Window
            }
        }

        private void frm_mainWindow_Load(object sender, EventArgs e)
        {
            notifyIcon.Icon = SystemIcons.Application; // set the icon to default application icon
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show(); // show the Main Window
            notifyIcon.Visible = false; // hide the system tray icon
            this.WindowState = FormWindowState.Normal; // resize the Main Windows

        }
    }
}
