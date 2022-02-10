using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW
{
    public partial class MainScreen : Form
    {
        public DBConnection DBConn { get; set; }
        public MainScreen()
        {
            DBConn = new DBConnection();
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            statusBarLabel.ForeColor = Color.Red;
            statusBarLabel.Text = "Not connected to the database source.";
        }

        private void DatabaseConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBConnectionDialog dia = new DBConnectionDialog();
            var res = dia.ShowDialog();
            if (res == DialogResult.OK)
            {
                DBConn.DBServer = dia.DBConnection.DBServer;
                DBConn.DBName = dia.DBConnection.DBName;
                DBConn.DBUser = dia.DBConnection.DBUser;
                DBConn.DBPass = dia.DBConnection.DBPass;
            }
        }
    }
    public class DBConnection
    {
        public string DBServer { get; set; }
        public string DBName { get; set; }
        public string DBUser { get; set; }
        public string DBPass { get; set; }
    }
}
