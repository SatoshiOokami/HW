using System;
using System.Windows.Forms;

namespace HW
{
    public partial class DBConnectionDialog : Form
    {
        public DBConnection DBConnection { get; set; }

        public DBConnectionDialog()
        {
            DBConnection = new DBConnection();
            InitializeComponent();
        }

        private void BtnSaveDBConn_Click(object sender, EventArgs e)
        {
            DBConnection.DBServer = tbDBServer.Text;
            DBConnection.DBName = tbDB.Text;
            DBConnection.DBUser = tbDBUser.Text;
            DBConnection.DBPass = tbDBPsw.Text;
            DBConnection.IntegratedSecurity = cbIS.Checked;

            SaveDatabaseConnection();
        }

        private void SaveDatabaseConnection()
        {
            //TODO: 
            //registry or file
        }
    }
}
