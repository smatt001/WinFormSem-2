namespace ClassMateriWeek09
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.dgv_mahasiswa = new System.Windows.Forms.DataGridView();
            this.btn_submit = new System.Windows.Forms.Button();
            this.tb_kota = new System.Windows.Forms.TextBox();
            this.tb_nim = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(45, 43);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(122, 25);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(45, 97);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(118, 25);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Password :";
            // 
            // lbl_Database
            // 
            this.lbl_Database.AutoSize = true;
            this.lbl_Database.Location = new System.Drawing.Point(51, 159);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(116, 25);
            this.lbl_Database.TabIndex = 2;
            this.lbl_Database.Text = "Database :";
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(173, 40);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(152, 31);
            this.tb_Username.TabIndex = 3;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(173, 94);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(152, 31);
            this.tb_Password.TabIndex = 4;
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(173, 156);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(152, 31);
            this.tb_Database.TabIndex = 5;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(173, 231);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(123, 64);
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(12, 575);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 82;
            this.dgv_data.RowTemplate.Height = 33;
            this.dgv_data.Size = new System.Drawing.Size(1382, 278);
            this.dgv_data.TabIndex = 7;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(356, 231);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(123, 64);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // dgv_mahasiswa
            // 
            this.dgv_mahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mahasiswa.Location = new System.Drawing.Point(12, 334);
            this.dgv_mahasiswa.Name = "dgv_mahasiswa";
            this.dgv_mahasiswa.RowHeadersWidth = 82;
            this.dgv_mahasiswa.RowTemplate.Height = 33;
            this.dgv_mahasiswa.Size = new System.Drawing.Size(1382, 235);
            this.dgv_mahasiswa.TabIndex = 9;
            this.dgv_mahasiswa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(1066, 234);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(123, 64);
            this.btn_submit.TabIndex = 23;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // tb_kota
            // 
            this.tb_kota.Location = new System.Drawing.Point(1066, 159);
            this.tb_kota.Name = "tb_kota";
            this.tb_kota.Size = new System.Drawing.Size(152, 31);
            this.tb_kota.TabIndex = 22;
            // 
            // tb_nim
            // 
            this.tb_nim.Location = new System.Drawing.Point(1066, 97);
            this.tb_nim.Name = "tb_nim";
            this.tb_nim.Size = new System.Drawing.Size(152, 31);
            this.tb_nim.TabIndex = 21;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(1066, 43);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(152, 31);
            this.tb_nama.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(944, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "kota asal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(938, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(938, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 865);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.tb_kota);
            this.Controls.Add(this.tb_nim);
            this.Controls.Add(this.tb_nama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_mahasiswa);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Database);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Database);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Database;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView dgv_mahasiswa;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox tb_kota;
        private System.Windows.Forms.TextBox tb_nim;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

