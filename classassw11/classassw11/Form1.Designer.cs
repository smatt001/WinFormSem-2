namespace classassw11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.cb_TeamHome = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_matchid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_TeamAway = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server :";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(161, 52);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(193, 31);
            this.tb_Server.TabIndex = 1;
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(161, 106);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(193, 31);
            this.tb_User.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "User ";
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(161, 216);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(193, 31);
            this.tb_Database.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Database";
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(161, 162);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(193, 31);
            this.tb_Password.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(190, 267);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(124, 53);
            this.btn_Login.TabIndex = 8;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // dgv_1
            // 
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(369, 279);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowHeadersWidth = 82;
            this.dgv_1.RowTemplate.Height = 33;
            this.dgv_1.Size = new System.Drawing.Size(689, 454);
            this.dgv_1.TabIndex = 9;
            // 
            // cb_TeamHome
            // 
            this.cb_TeamHome.FormattingEnabled = true;
            this.cb_TeamHome.Location = new System.Drawing.Point(574, 118);
            this.cb_TeamHome.Name = "cb_TeamHome";
            this.cb_TeamHome.Size = new System.Drawing.Size(226, 33);
            this.cb_TeamHome.TabIndex = 10;
            this.cb_TeamHome.SelectedIndexChanged += new System.EventHandler(this.cb_TeamHome_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Team Home";
            // 
            // tb_matchid
            // 
            this.tb_matchid.Location = new System.Drawing.Point(566, 55);
            this.tb_matchid.Name = "tb_matchid";
            this.tb_matchid.Size = new System.Drawing.Size(193, 31);
            this.tb_matchid.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "MatchID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1101, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Team Away";
            // 
            // cb_TeamAway
            // 
            this.cb_TeamAway.FormattingEnabled = true;
            this.cb_TeamAway.Location = new System.Drawing.Point(1231, 118);
            this.cb_TeamAway.Name = "cb_TeamAway";
            this.cb_TeamAway.Size = new System.Drawing.Size(265, 33);
            this.cb_TeamAway.TabIndex = 15;
            this.cb_TeamAway.SelectedIndexChanged += new System.EventHandler(this.cb_TeamAway_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1101, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Match Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1231, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(385, 31);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 923);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_TeamAway);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_matchid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_TeamHome);
            this.Controls.Add(this.dgv_1);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Database);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Server);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Database;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.ComboBox cb_TeamHome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_matchid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_TeamAway;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

