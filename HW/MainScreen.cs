using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HW
{
    //TODO: 
    //Designer - autocompletes for textboxes, remembering the previously entered values 
    public partial class MainScreen : Form
    {
        public DBConnection DBConn { get; set; }
        public string ConnectionString { get; set; }
        private bool _connectionReady { get; set; }
        public Dictionary<int, SortDirectionEnum> ColumnsSort { get; set; }

        public MainScreen()
        {
            DBConn = new DBConnection();
            ConnectionString = string.Empty;
            _connectionReady = false;
            ColumnsSort = new Dictionary<int, SortDirectionEnum>();
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
                        $"CREATE TABLE Trip (ID int IDENTITY(1,1) PRIMARY KEY, Employee varchar(MAX), Purpose varchar(MAX), Destination varchar(MAX), FromDate datetime, ToDate datetime, RecordDate datetime)";
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

        private void BtnShowAll_Click(object sender, EventArgs e)
        {
            if (_connectionReady)
            {
                ShowAllTrips();
            }
            else
            {
                ReportStatus(Color.Red, "Unable to get data from the source.");
            }
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
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    //TODO: 
                    //Include status in the table schema
                    var query = $"INSERT INTO Trip (Employee, Purpose, Destination, FromDate, ToDate, RecordDate)" +
                                $"VALUES (@emp, @purp, @dest, @from, @to, @record)";
                    var cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@emp", tbName.Text);
                    cmd.Parameters.AddWithValue("@purp", tbPurpose.Text);
                    cmd.Parameters.AddWithValue("@dest", tbDestination.Text);
                    cmd.Parameters.AddWithValue("@from", fromDate.Value.Date);
                    cmd.Parameters.AddWithValue("@to", toDate.Value.Date);
                    cmd.Parameters.AddWithValue("@record", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                //Status bar reports successful creation
                ReportStatus(Color.Lime, "Record successfully saved.");
            }
            catch (Exception ex)
            {
                //Status bar reports unsuccessful record creation
                ReportStatus(Color.Red, "Unable to save record.");
            }
        }

        private void ShowAllTrips()
        {
            try
            {
                List<Trip> trips = new List<Trip>();
                using (var connection = new SqlConnection(ConnectionString))
                {
                    //reading rows from the database
                    connection.Open();
                    var query = $"SELECT * FROM Trip";
                    var cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            trips.Add(new Trip
                            {
                                TripID = !reader.IsDBNull(reader.GetOrdinal("ID")) ? int.Parse(reader["ID"].ToString()) : -1,
                                Employee = reader["Employee"]?.ToString(),
                                Purpose = reader["Purpose"]?.ToString(),
                                Destination = reader["Destination"]?.ToString(),
                                FromDate = !reader.IsDBNull(reader.GetOrdinal("FromDate")) ? DateTime.Parse(reader["FromDate"].ToString()) : new DateTime(1900, 1, 1),
                                ToDate = !reader.IsDBNull(reader.GetOrdinal("ToDate")) ? DateTime.Parse(reader["ToDate"].ToString()) : new DateTime(1900, 1, 1),
                                RecordDate = !reader.IsDBNull(reader.GetOrdinal("RecordDate")) ? DateTime.Parse(reader["RecordDate"].ToString()) : new DateTime(1900, 1, 1),
                                //TODO: 
                                //Include status
                            });
                        }
                    }
                    connection.Close();
                }

                //filling the grid with data from the database using the created list
                dataGridViewTrips.DataSource = trips;

                foreach (DataGridViewColumn column in dataGridViewTrips.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Programmatic;
                    ColumnsSort.Add(column.Index, SortDirectionEnum.Unsorted);
                }
            }
            catch (Exception ex)
            {
                //Status bar reports unsuccessful select
                ReportStatus(Color.Red, "Unable to get records.");
            }
        }

        //sorting
        private void DataGridViewTrips_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var trips = (List<Trip>)dataGridViewTrips.DataSource;
            var index = e.ColumnIndex;

            if (ColumnsSort[index] == SortDirectionEnum.Unsorted || ColumnsSort[index] == SortDirectionEnum.Descending)
            {
                dataGridViewTrips.DataSource = trips.OrderBy(x => x.GetType().GetProperty(dataGridViewTrips.Columns[index].DataPropertyName).GetValue(x, null)).ToList();
                ColumnsSort[index] = SortDirectionEnum.Ascending;
            }
            else
            {
                dataGridViewTrips.DataSource = trips.OrderByDescending(x => x.GetType().GetProperty(dataGridViewTrips.Columns[index].DataPropertyName).GetValue(x, null)).ToList();
                ColumnsSort[index] = SortDirectionEnum.Descending;
            }
        }
    }
}
