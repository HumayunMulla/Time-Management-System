using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Configuration;

namespace Time_Management_System
{
    public partial class frm_mainWindow : Form
    {
        ConnectionClass connectObject = new ConnectionClass(); // create instance of connection class
        public String SunyID { get; set; }
        public String sql { get; set; }

        public String employee_name { get; set; }
        public String strFROMMAIL { get; set; }
        public String strTOMAIL { get; set; }

        // variables used for data & time recording
        public String strDateTime { get; set; }
        DateTime localDate = DateTime.Now;
        DateTime utcDate = DateTime.UtcNow;
        DateTime currentDate;

        // user system's variables used for recording details
        public String checkin_time { get; set; }
        public String checkout_time { get; set; }
        public String status { get; set; }
        public String system_time { get; set; }
        public String hostname { get; set; }
        public String MAC_Address { get; set; }
        public String IP_Address { get; set; }
        public String domain_name { get; set; }
        public String user_name { get; set; }
        string providerName = "";

        public frm_mainWindow(string IniPath = null)
        {
            InitializeComponent();

            providerName = ConfigurationManager.AppSettings["providerName"].ToString();
            var MyIni = new IniFile("configuration.ini");
            var TOMAIL = IniFile.Read("TOMAIL", "MAIL");
            var FROMMAIL = IniFile.Read("FROMMAIL", "MAIL");
            strFROMMAIL = FROMMAIL.ToString();
            strTOMAIL = TOMAIL.ToString();

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
            txtBox_sunyid.MaxLength = 6; // set the default length of txtBox_sunyid limited to only 6 INT values
            connectObject.ConnectionOpen();
            var culture = new CultureInfo("en-US"); // specific to English(United States)
            currentDate = localDate;
            strDateTime = "     Local date and time: " + localDate.ToString(culture) + " " + localDate.Kind;
            lbl_systime.Text = strDateTime; // display current system date and time according to the local setting
            connectObject.ConnectionClose(); // close connection as it will be open when required.
            // initializing system variables on form load only
            user_name = System.Environment.UserName;
            hostname = System.Net.Dns.GetHostName();
            foreach (NetworkInterface n in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (n.OperationalStatus == OperationalStatus.Up)
                {
                    MAC_Address += n.GetPhysicalAddress().ToString();
                    break;
                }
            }
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IP_Address += ip.ToString();
                }
            }
            domain_name = System.Environment.UserDomainName;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show(); // show the Main Window
            notifyIcon.Visible = false; // hide the system tray icon
            this.WindowState = FormWindowState.Normal; // resize the Main Windows
        }

        private void txtBox_sunyid_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*  validation to check if only INT value or SUNY ID number is 
             *  being entered. If any character is entered it will give a 
             *  pop-up message. Also check if any special keys are pressed.
             */


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please enter INT value only!", "Time Management System");
            }

        }

        private void txtBox_sunyid_KeyDown(object sender, KeyEventArgs e)
        {

            connectObject.ConnectionOpen();
            if (e.KeyData == Keys.Enter)
            {
                int result = 0; // local scope for only use in this param only
                SunyID = txtBox_sunyid.Text; // assign textbox value to string variable
                try
                {
                    // validation process to check if the employee is a SUNY employee with valid SUNY ID
                    sql = "SELECT COUNT(*) FROM employeeID WHERE employeeid = " + SunyID.ToString();
                    result = Convert.ToInt32(connectObject.ExecuteScalar(sql));
                    if (result > 0)
                    {
                        sql = "SELECT employee_name FROM employeeID WHERE employeeid = " + SunyID.ToString();
                        employee_name = connectObject.ExecuteScalar(sql);

                        lbl_status.Text = "Valid Employee";
                        lbl_status.ForeColor = System.Drawing.Color.Green;
                        btn_checkin.Enabled = true;
                        btn_checkin.ForeColor = System.Drawing.Color.Red;
                    }
                    else if (result == 0)
                    {
                        MessageBox.Show("Please enter valid SUNY ID", "Time Management System");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error in Authentication - " + ex.ToString(), "Time Management System");
                }

            }
            connectObject.ConnectionClose(); // Calls close connection method to close the connection made to the database
        }

        private void btn_checkin_Click(object sender, EventArgs e)
        {
            /*   This method will record check-in time into database along with 
             *   other attributes such as hostname, ip_address, etc. That is user details 
             *   related to the machine he is using the application.
             */
            var culture = new CultureInfo("en-US"); // specific to English(United States)
            connectObject.ConnectionOpen(); // create connection with the database again for inserting 
            try
            {
                checkin_time = localDate.ToString(culture); // considering current system date and time
                status = "CHECKIN-SUCCESS";
                sql = "insert into " + ConnectionClass.database + ".employee_details values (" + SunyID.ToString() + ",'" + checkin_time + "','','" + status + "','" + user_name + "','" + hostname + "','" + MAC_Address + "','" + IP_Address + "','" + domain_name + "','DXADMIN',now())";
                connectObject.ExecuteCommand(sql);

                btn_checkin.Enabled = false;
                btn_checkin.ForeColor = System.Drawing.Color.Black;
                btn_checkout.Enabled = true;
                btn_checkout.ForeColor = System.Drawing.Color.Red;
                lbl_status.Text = "Ready";
                lbl_status.ForeColor = System.Drawing.Color.Black;
                CreateMailItem("CHECK-IN");

                MessageBox.Show("Check-IN time recorded for user - " + employee_name, "Time Management System");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error in Checking Functionality - " + ex.ToString(), "Time Management System");
            }
        }

        private void CreateMailItem(String Subject)
        {
            Microsoft.Office.Interop.Outlook.Application app = new Microsoft.Office.Interop.Outlook.Application();
            Microsoft.Office.Interop.Outlook.MailItem mailItem = app.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem);

            mailItem.Subject = Subject +" " + currentDate.ToString("dd MMMM yyyy") + " - " + currentDate.ToString("hh:mm:ss tt");
            mailItem.To = strTOMAIL;
            mailItem.Body = "Hi\n\nPlease find my today's "+ Subject + " " + currentDate.ToString("dd MMMM yyyy") + " - " + currentDate.ToString("hh:mm:ss tt") + "." + "\n\nSystem Details:\nUser Name: "+user_name+"\nHOSTNAME: "+hostname+"\nIP Address:"+IP_Address+"\nMAC Address: "+MAC_Address+"\nDOMAIN: "+domain_name+"\n\nThis is autogenerated email sent by Time Management System.\n\nThanks & Regards\n"+user_name;
            //mailItem.Attachments.Add(attachment_path); //attachment_path is a string holding path of the attachment
            mailItem.Importance = Outlook.OlImportance.olImportanceHigh;
            mailItem.Display(false);
            mailItem.Send();
        }

    }
}
