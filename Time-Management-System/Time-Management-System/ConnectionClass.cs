using System.Text;
using System.Windows;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Time_Management_System
{
    class ConnectionClass
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        public static string database { get; set; }
        public static string hostname { get; set; }
        public static string refGroup { get; set; }
        public static string password { get; set; }
        public static string UserID { get; set; }
        string providerName = "", connectionString = "", result = "";
        public ConnectionClass(string IniPath = null)
        {
            providerName = ConfigurationManager.AppSettings["providerName"].ToString();
            var MyIni = new IniFile("configuration.ini");
            var DATABASE = IniFile.Read("DATABASE", "SERVER");
            var HOSTNAME = IniFile.Read("HOSTNAME", "SERVER");
            var REFGROUP = IniFile.Read("REFGROUP", "SERVER");
            var USERNAME = IniFile.Read("USERNAME", "SERVER");
            var PASSWORD = IniFile.Read("PASSWORD", "SERVER");
            hostname = HOSTNAME.ToString();
            database = DATABASE.ToString();
            refGroup = REFGROUP.ToString();
            UserID = USERNAME.ToString();
            password = PASSWORD.ToString();
        }
        public void ConnectionOpen() // Method to Open Connection 
        {
            try
            {
                connectionString = "Data Source=" + hostname + ";Port=3306;UID=" + UserID + ";PWD=" + password + ";Database=" + database + ";";
                conn = new MySqlConnection(connectionString);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to Connect to Database - " + ex.ToString(), "Time Management System");
            }
        }
        public void ExecuteCommand(string sql) // Method to execute single SQL
        {
            try
            {
                cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to Execute Command[501] - " + ex.ToString(), "Time Management System");
            }
        }
        public string ExecuteScalar(string sql) // Method to execute and return result of SQL
        {
            try
            {
                cmd = new MySqlCommand(sql, conn);
                result = cmd.ExecuteScalar().ToString();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Failed to Execute Command[502] - " + ex.ToString(), "Time Management System");
            }
            return result;
        }
        public void ConnectionClose() // Method to Close Connection 
        {
            conn.Close();
        }
    }
    class IniFile
    {
        static string Path;
        static string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName.ToString();
        }

        public static string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }
    }
}
