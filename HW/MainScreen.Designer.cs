namespace HW
{
    partial class MainScreen
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTrips = new System.Windows.Forms.DataGridView();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.tabCreate = new System.Windows.Forms.TabPage();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.statusBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).BeginInit();
            this.tabCreate.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 325);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(334, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "Teeext";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseConnectionToolStripMenuItem,
            this.initializeDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // databaseConnectionToolStripMenuItem
            // 
            this.databaseConnectionToolStripMenuItem.Name = "databaseConnectionToolStripMenuItem";
            this.databaseConnectionToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.databaseConnectionToolStripMenuItem.Text = "Database &Connection";
            this.databaseConnectionToolStripMenuItem.Click += new System.EventHandler(this.DatabaseConnectionToolStripMenuItem_Click);
            // 
            // initializeDatabaseToolStripMenuItem
            // 
            this.initializeDatabaseToolStripMenuItem.Enabled = false;
            this.initializeDatabaseToolStripMenuItem.Name = "initializeDatabaseToolStripMenuItem";
            this.initializeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.initializeDatabaseToolStripMenuItem.Text = "&Initialize Database";
            this.initializeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.InitializeDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(184, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTrips);
            this.tabPage2.Controls.Add(this.btnShowAll);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(327, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Trips";
            // 
            // dataGridViewTrips
            // 
            this.dataGridViewTrips.AllowUserToAddRows = false;
            this.dataGridViewTrips.AllowUserToDeleteRows = false;
            this.dataGridViewTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrips.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewTrips.Name = "dataGridViewTrips";
            this.dataGridViewTrips.ReadOnly = true;
            this.dataGridViewTrips.Size = new System.Drawing.Size(317, 234);
            this.dataGridViewTrips.TabIndex = 15;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(81, 247);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(145, 23);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Show All Trips";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
            // 
            // tabCreate
            // 
            this.tabCreate.Controls.Add(this.toDate);
            this.tabCreate.Controls.Add(this.lblTo);
            this.tabCreate.Controls.Add(this.fromDate);
            this.tabCreate.Controls.Add(this.lblFrom);
            this.tabCreate.Controls.Add(this.btnSave);
            this.tabCreate.Controls.Add(this.btnClear);
            this.tabCreate.Controls.Add(this.tbDestination);
            this.tabCreate.Controls.Add(this.lblDestination);
            this.tabCreate.Controls.Add(this.tbPurpose);
            this.tabCreate.Controls.Add(this.lblPurpose);
            this.tabCreate.Controls.Add(this.tbName);
            this.tabCreate.Controls.Add(this.lblName);
            this.tabCreate.Location = new System.Drawing.Point(4, 22);
            this.tabCreate.Name = "tabCreate";
            this.tabCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCreate.Size = new System.Drawing.Size(327, 276);
            this.tabCreate.TabIndex = 0;
            this.tabCreate.Text = "Create Trip";
            this.tabCreate.UseVisualStyleBackColor = true;
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(8, 197);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(301, 20);
            this.toDate.TabIndex = 9;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(8, 181);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "To:";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(8, 158);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(301, 20);
            this.fromDate.TabIndex = 7;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(8, 142);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "From:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(234, 236);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 236);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(8, 119);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(301, 20);
            this.tbDestination.TabIndex = 5;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(8, 103);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(63, 13);
            this.lblDestination.TabIndex = 4;
            this.lblDestination.Text = "Destination:";
            // 
            // tbPurpose
            // 
            this.tbPurpose.Location = new System.Drawing.Point(8, 80);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(301, 20);
            this.tbPurpose.TabIndex = 3;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(8, 64);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(49, 13);
            this.lblPurpose.TabIndex = 2;
            this.lblPurpose.Text = "Purpose:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(8, 41);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCreate);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(335, 302);
            this.tabControl.TabIndex = 14;
            // 
            // MainScreen
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 347);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.Text = "Trip Manager";
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrips)).EndInit();
            this.tabCreate.ResumeLayout(false);
            this.tabCreate.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem databaseConnectionToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabCreate;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStripMenuItem initializeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewTrips;
    }
}

