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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1_attendance = new System.Windows.Forms.TabPage();
            this.tabPage2_tasklogger = new System.Windows.Forms.TabPage();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1_attendance);
            this.tabControl1.Controls.Add(this.tabPage2_tasklogger);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(468, 214);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1_attendance
            // 
            this.tabPage1_attendance.Location = new System.Drawing.Point(4, 28);
            this.tabPage1_attendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1_attendance.Name = "tabPage1_attendance";
            this.tabPage1_attendance.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1_attendance.Size = new System.Drawing.Size(460, 182);
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
            this.tabPage2_tasklogger.Size = new System.Drawing.Size(460, 182);
            this.tabPage2_tasklogger.TabIndex = 1;
            this.tabPage2_tasklogger.Text = "Task Tracker";
            this.tabPage2_tasklogger.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "Time Management System";
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // frm_mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 214);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Management System";
            this.Load += new System.EventHandler(this.frm_mainWindow_Load);
            this.Resize += new System.EventHandler(this.frm_mainWindow_Resize);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1_attendance;
        private System.Windows.Forms.TabPage tabPage2_tasklogger;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

