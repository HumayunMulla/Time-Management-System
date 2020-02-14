namespace Time_Management_System
{
    partial class frm_mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1_attendance = new System.Windows.Forms.TabPage();
            this.tabPage2_tasklogger = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_status = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lbl_sunyid = new System.Windows.Forms.Label();
            this.txtBox_sunyid = new System.Windows.Forms.TextBox();
            this.tabControl.SuspendLayout();
            this.tabPage1_attendance.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1_attendance);
            this.tabControl.Controls.Add(this.tabPage2_tasklogger);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(468, 222);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1_attendance
            // 
            this.tabPage1_attendance.Controls.Add(this.txtBox_sunyid);
            this.tabPage1_attendance.Controls.Add(this.lbl_sunyid);
            this.tabPage1_attendance.Location = new System.Drawing.Point(4, 28);
            this.tabPage1_attendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1_attendance.Name = "tabPage1_attendance";
            this.tabPage1_attendance.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1_attendance.Size = new System.Drawing.Size(460, 190);
            this.tabPage1_attendance.TabIndex = 0;
            this.tabPage1_attendance.Text = "Attendance";
            this.tabPage1_attendance.UseVisualStyleBackColor = true;
            // 
            // tabPage2_tasklogger
            // 
            this.tabPage2_tasklogger.Location = new System.Drawing.Point(4, 28);
            this.tabPage2_tasklogger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2_tasklogger.Name = "tabPage2_tasklogger";
            this.tabPage2_tasklogger.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2_tasklogger.Size = new System.Drawing.Size(460, 190);
            this.tabPage2_tasklogger.TabIndex = 1;
            this.tabPage2_tasklogger.Text = "Task Tracker";
            this.tabPage2_tasklogger.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Time Management System";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.progressBar);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 26);
            this.panel1.TabIndex = 1;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(3, 5);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(45, 18);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "Ready";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(340, 1);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 1;
            this.progressBar.Visible = false;
            // 
            // lbl_sunyid
            // 
            this.lbl_sunyid.AutoSize = true;
            this.lbl_sunyid.Location = new System.Drawing.Point(22, 21);
            this.lbl_sunyid.Name = "lbl_sunyid";
            this.lbl_sunyid.Size = new System.Drawing.Size(65, 19);
            this.lbl_sunyid.TabIndex = 0;
            this.lbl_sunyid.Text = "SUNY ID";
            // 
            // txtBox_sunyid
            // 
            this.txtBox_sunyid.Location = new System.Drawing.Point(93, 17);
            this.txtBox_sunyid.Name = "txtBox_sunyid";
            this.txtBox_sunyid.Size = new System.Drawing.Size(129, 27);
            this.txtBox_sunyid.TabIndex = 1;
            this.txtBox_sunyid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_sunyid_KeyPress);
            // 
            // frm_mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 247);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Management System";
            this.Load += new System.EventHandler(this.frm_mainWindow_Load);
            this.Resize += new System.EventHandler(this.frm_mainWindow_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPage1_attendance.ResumeLayout(false);
            this.tabPage1_attendance.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1_attendance;
        private System.Windows.Forms.TabPage tabPage2_tasklogger;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lbl_sunyid;
        private System.Windows.Forms.TextBox txtBox_sunyid;
    }
}

