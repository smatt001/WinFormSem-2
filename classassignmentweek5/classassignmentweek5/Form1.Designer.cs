namespace classassignmentweek5
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_NamaTeam = new System.Windows.Forms.TextBox();
            this.tb_Nama_Stadium = new System.Windows.Forms.TextBox();
            this.tb_Kapasitas = new System.Windows.Forms.TextBox();
            this.tb_Kota = new System.Windows.Forms.TextBox();
            this.tb_Nama_Manager = new System.Windows.Forms.TextBox();
            this.tb_TeamID = new System.Windows.Forms.TextBox();
            this.btn_input = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Team:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Stadium:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kapasitas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kota:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nama Manager:";
            // 
            // tb_NamaTeam
            // 
            this.tb_NamaTeam.Location = new System.Drawing.Point(184, 69);
            this.tb_NamaTeam.Name = "tb_NamaTeam";
            this.tb_NamaTeam.Size = new System.Drawing.Size(162, 31);
            this.tb_NamaTeam.TabIndex = 6;
            this.tb_NamaTeam.TextChanged += new System.EventHandler(this.tb_NamaTeam_TextChanged);
            // 
            // tb_Nama_Stadium
            // 
            this.tb_Nama_Stadium.Location = new System.Drawing.Point(184, 103);
            this.tb_Nama_Stadium.Name = "tb_Nama_Stadium";
            this.tb_Nama_Stadium.Size = new System.Drawing.Size(162, 31);
            this.tb_Nama_Stadium.TabIndex = 7;
            // 
            // tb_Kapasitas
            // 
            this.tb_Kapasitas.Location = new System.Drawing.Point(184, 141);
            this.tb_Kapasitas.Name = "tb_Kapasitas";
            this.tb_Kapasitas.Size = new System.Drawing.Size(162, 31);
            this.tb_Kapasitas.TabIndex = 8;
            // 
            // tb_Kota
            // 
            this.tb_Kota.Location = new System.Drawing.Point(184, 175);
            this.tb_Kota.Name = "tb_Kota";
            this.tb_Kota.Size = new System.Drawing.Size(162, 31);
            this.tb_Kota.TabIndex = 9;
            // 
            // tb_Nama_Manager
            // 
            this.tb_Nama_Manager.Location = new System.Drawing.Point(184, 210);
            this.tb_Nama_Manager.Name = "tb_Nama_Manager";
            this.tb_Nama_Manager.Size = new System.Drawing.Size(162, 31);
            this.tb_Nama_Manager.TabIndex = 10;
            // 
            // tb_TeamID
            // 
            this.tb_TeamID.Enabled = false;
            this.tb_TeamID.Location = new System.Drawing.Point(184, 32);
            this.tb_TeamID.Name = "tb_TeamID";
            this.tb_TeamID.Size = new System.Drawing.Size(162, 31);
            this.tb_TeamID.TabIndex = 11;
            // 
            // btn_input
            // 
            this.btn_input.Location = new System.Drawing.Point(184, 272);
            this.btn_input.Name = "btn_input";
            this.btn_input.Size = new System.Drawing.Size(138, 48);
            this.btn_input.TabIndex = 13;
            this.btn_input.Text = "Input";
            this.btn_input.UseVisualStyleBackColor = true;
            this.btn_input.Click += new System.EventHandler(this.btn_input_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1161, 372);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1587, 710);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_input);
            this.Controls.Add(this.tb_TeamID);
            this.Controls.Add(this.tb_Nama_Manager);
            this.Controls.Add(this.tb_Kota);
            this.Controls.Add(this.tb_Kapasitas);
            this.Controls.Add(this.tb_Nama_Stadium);
            this.Controls.Add(this.tb_NamaTeam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NamaTeam;
        private System.Windows.Forms.TextBox tb_Nama_Stadium;
        private System.Windows.Forms.TextBox tb_Kapasitas;
        private System.Windows.Forms.TextBox tb_Kota;
        private System.Windows.Forms.TextBox tb_Nama_Manager;
        private System.Windows.Forms.TextBox tb_TeamID;
        private System.Windows.Forms.Button btn_input;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

