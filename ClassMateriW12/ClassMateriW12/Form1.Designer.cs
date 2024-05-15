namespace ClassMateriW12
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
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_3 = new System.Windows.Forms.TextBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.btn_masuk = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tb_UpdateNim = new System.Windows.Forms.TextBox();
            this.tb_UpdateName = new System.Windows.Forms.TextBox();
            this.tb_UpdateID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIM";
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(201, 24);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(172, 31);
            this.tb_1.TabIndex = 4;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(201, 95);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(172, 31);
            this.tb_2.TabIndex = 5;
            // 
            // tb_3
            // 
            this.tb_3.Location = new System.Drawing.Point(201, 165);
            this.tb_3.Name = "tb_3";
            this.tb_3.Size = new System.Drawing.Size(172, 31);
            this.tb_3.TabIndex = 6;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(755, 44);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 33;
            this.dgv1.Size = new System.Drawing.Size(1111, 546);
            this.dgv1.TabIndex = 7;
            this.dgv1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv1_CellContentClick);
            this.dgv1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv1_CellMouseDoubleClick);
            // 
            // btn_masuk
            // 
            this.btn_masuk.Location = new System.Drawing.Point(98, 235);
            this.btn_masuk.Name = "btn_masuk";
            this.btn_masuk.Size = new System.Drawing.Size(193, 64);
            this.btn_masuk.TabIndex = 8;
            this.btn_masuk.Text = "MASOK";
            this.btn_masuk.UseVisualStyleBackColor = true;
            this.btn_masuk.Click += new System.EventHandler(this.btn_masuk_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(98, 594);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(193, 64);
            this.btn_Update.TabIndex = 15;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tb_UpdateNim
            // 
            this.tb_UpdateNim.Location = new System.Drawing.Point(201, 524);
            this.tb_UpdateNim.Name = "tb_UpdateNim";
            this.tb_UpdateNim.Size = new System.Drawing.Size(172, 31);
            this.tb_UpdateNim.TabIndex = 14;
            // 
            // tb_UpdateName
            // 
            this.tb_UpdateName.Location = new System.Drawing.Point(201, 454);
            this.tb_UpdateName.Name = "tb_UpdateName";
            this.tb_UpdateName.Size = new System.Drawing.Size(172, 31);
            this.tb_UpdateName.TabIndex = 13;
            // 
            // tb_UpdateID
            // 
            this.tb_UpdateID.Location = new System.Drawing.Point(201, 383);
            this.tb_UpdateID.Name = "tb_UpdateID";
            this.tb_UpdateID.Size = new System.Drawing.Size(172, 31);
            this.tb_UpdateID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "NIM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1989, 923);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.tb_UpdateNim);
            this.Controls.Add(this.tb_UpdateName);
            this.Controls.Add(this.tb_UpdateID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_masuk);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.tb_3);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_3;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button btn_masuk;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox tb_UpdateNim;
        private System.Windows.Forms.TextBox tb_UpdateName;
        private System.Windows.Forms.TextBox tb_UpdateID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

