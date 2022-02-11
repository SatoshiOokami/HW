namespace HW
{
    partial class DBConnectionDialog
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
            this.lblDBServer = new System.Windows.Forms.Label();
            this.tbDBServer = new System.Windows.Forms.TextBox();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.tbDBUser = new System.Windows.Forms.TextBox();
            this.lblDBUser = new System.Windows.Forms.Label();
            this.tbDBPsw = new System.Windows.Forms.TextBox();
            this.lblDBPsw = new System.Windows.Forms.Label();
            this.btnSaveDBConn = new System.Windows.Forms.Button();
            this.cbIS = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblDBServer
            // 
            this.lblDBServer.AutoSize = true;
            this.lblDBServer.Location = new System.Drawing.Point(12, 9);
            this.lblDBServer.Name = "lblDBServer";
            this.lblDBServer.Size = new System.Drawing.Size(38, 13);
            this.lblDBServer.TabIndex = 0;
            this.lblDBServer.Text = "Server";
            // 
            // tbDBServer
            // 
            this.tbDBServer.Location = new System.Drawing.Point(89, 6);
            this.tbDBServer.Name = "tbDBServer";
            this.tbDBServer.Size = new System.Drawing.Size(120, 20);
            this.tbDBServer.TabIndex = 1;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(89, 39);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(120, 20);
            this.tbDB.TabIndex = 3;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(12, 42);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(53, 13);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database";
            // 
            // tbDBUser
            // 
            this.tbDBUser.Location = new System.Drawing.Point(89, 74);
            this.tbDBUser.Name = "tbDBUser";
            this.tbDBUser.Size = new System.Drawing.Size(120, 20);
            this.tbDBUser.TabIndex = 5;
            // 
            // lblDBUser
            // 
            this.lblDBUser.AutoSize = true;
            this.lblDBUser.Location = new System.Drawing.Point(12, 77);
            this.lblDBUser.Name = "lblDBUser";
            this.lblDBUser.Size = new System.Drawing.Size(47, 13);
            this.lblDBUser.TabIndex = 4;
            this.lblDBUser.Text = "DB User";
            // 
            // tbDBPsw
            // 
            this.tbDBPsw.Location = new System.Drawing.Point(89, 108);
            this.tbDBPsw.Name = "tbDBPsw";
            this.tbDBPsw.PasswordChar = '*';
            this.tbDBPsw.Size = new System.Drawing.Size(120, 20);
            this.tbDBPsw.TabIndex = 7;
            // 
            // lblDBPsw
            // 
            this.lblDBPsw.AutoSize = true;
            this.lblDBPsw.Location = new System.Drawing.Point(12, 111);
            this.lblDBPsw.Name = "lblDBPsw";
            this.lblDBPsw.Size = new System.Drawing.Size(71, 13);
            this.lblDBPsw.TabIndex = 6;
            this.lblDBPsw.Text = "DB Password";
            // 
            // btnSaveDBConn
            // 
            this.btnSaveDBConn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveDBConn.Location = new System.Drawing.Point(12, 167);
            this.btnSaveDBConn.Name = "btnSaveDBConn";
            this.btnSaveDBConn.Size = new System.Drawing.Size(192, 23);
            this.btnSaveDBConn.TabIndex = 8;
            this.btnSaveDBConn.Text = "Save Database Connection";
            this.btnSaveDBConn.UseVisualStyleBackColor = true;
            this.btnSaveDBConn.Click += new System.EventHandler(this.BtnSaveDBConn_Click);
            // 
            // cbIS
            // 
            this.cbIS.AutoSize = true;
            this.cbIS.Location = new System.Drawing.Point(15, 144);
            this.cbIS.Name = "cbIS";
            this.cbIS.Size = new System.Drawing.Size(115, 17);
            this.cbIS.TabIndex = 9;
            this.cbIS.Text = "Integrated Security";
            this.cbIS.UseVisualStyleBackColor = true;
            // 
            // DBConnectionDialog
            // 
            this.AcceptButton = this.btnSaveDBConn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 202);
            this.Controls.Add(this.cbIS);
            this.Controls.Add(this.btnSaveDBConn);
            this.Controls.Add(this.tbDBPsw);
            this.Controls.Add(this.lblDBPsw);
            this.Controls.Add(this.tbDBUser);
            this.Controls.Add(this.lblDBUser);
            this.Controls.Add(this.tbDB);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.tbDBServer);
            this.Controls.Add(this.lblDBServer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConnectionDialog";
            this.Text = "Database Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDBServer;
        private System.Windows.Forms.TextBox tbDBServer;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox tbDBUser;
        private System.Windows.Forms.Label lblDBUser;
        private System.Windows.Forms.TextBox tbDBPsw;
        private System.Windows.Forms.Label lblDBPsw;
        private System.Windows.Forms.Button btnSaveDBConn;
        private System.Windows.Forms.CheckBox cbIS;
    }
}