using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HW
{
    public partial class MainScreen : Form
    {
        public DBConnection DBConn { get; set; }
        public string ConnectionString { get; set; }
        private bool _connectionReady { get; set; }

        public MainScreen()
        {
            DBConn = new DBConnection();
            ConnectionString = string.Empty;
            _connectionReady = false;
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            ReportStatus(Color.Red, "Not connected to the database source.");
        }

        #region MENU
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

                try
                {
                    //Creating connection string using the provided data
                    ConnectionString = $"Data Source={DBConn.DBServer};Initial Catalog={DBConn.DBName};";
                    ConnectionString = DBConn.IntegratedSecurity ? $"{ConnectionString}Integrated Security=True;" : $"{ConnectionString}User Id={DBConn.DBUser};Password={DBConn.DBPass};";

                    //Testing connection to the provided database
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        connection.Open();
                        connection.Close();
                    }

                    //Status bar reports successful connection
                    ReportStatus(Color.Lime, "Database connnection established.");
                    initializeDatabaseToolStripMenuItem.Enabled = true;
                }
                catch (Exception ex)
                {
                    _connectionReady = false;
                    //Status bar reports unsuccessful connection
                    ReportStatus(Color.Red, "Connection to the database could not have been established.");
                }
            }
        }

        private void InitializeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating initial table
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    var query = $"IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Trip') " +
                        $"CREATE TABLE Trip (ID int, Employee varchar(MAX), Purpose varchar(MAX), Destination varchar(MAX), FromDate datetime, ToDate datetime)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    _connectionReady = true;
                    connection.Close();
                }
                //Status bar reports successful creation
                ReportStatus(Color.Lime, "Database successfully initialized.");
            }
            catch (Exception ex)
            {
                //Status bar reports unsuccessful table creation
                ReportStatus(Color.Red, "Could not initialize database.");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (_connectionReady)
            {
                SaveForm();
            }
            else
            {
                ReportStatus(Color.Red, "Unable to save record without database initialization.");
            }
        }

        /// <summary>
        /// Method for clearing the save form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            tbName.Text = tbPurpose.Text = tbDestination.Text = string.Empty;
            fromDate.Value = toDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Reporting status to the status bar
        /// </summary>
        /// <param name="color">Color used</param>
        /// <param name="message">Message to show</param>
        private void ReportStatus(Color color, string message)
        {
            statusBarLabel.ForeColor = color;
            statusBarLabel.Text = message;
        }

        /// <summary>
        /// Saving form data to database
        /// </summary>
        private void SaveForm()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Class for carrying database connection 
    /// </summary>
    public class DBConnection
    {
        public string DBServer { get; set; }
        public string DBName { get; set; }
        public string DBUser { get; set; }
        public string DBPass { get; set; }
        public bool IntegratedSecurity { get; set; }
    }
}
