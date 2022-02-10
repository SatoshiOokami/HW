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
        }
    }
}
