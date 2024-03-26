namespace Takehome_Week_5
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
            this.dgv_1 = new System.Windows.Forms.DataGridView();
            this.dgv_2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnl_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.TextBox();
            this.CBT_1 = new System.Windows.Forms.ComboBox();
            this.CBT_2 = new System.Windows.Forms.ComboBox();
            this.pnl_harga = new System.Windows.Forms.TextBox();
            this.lbl_stok = new System.Windows.Forms.TextBox();
            this.btn_btn_btn = new System.Windows.Forms.Button();
            this.btn_btn_btn_btn = new System.Windows.Forms.Button();
            this.catadd = new System.Windows.Forms.Button();
            this.edit2 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.rem_whos_rem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_1
            // 
            this.dgv_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_1.Location = new System.Drawing.Point(35, 48);
            this.dgv_1.Name = "dgv_1";
            this.dgv_1.RowTemplate.Height = 21;
            this.dgv_1.Size = new System.Drawing.Size(455, 267);
            this.dgv_1.TabIndex = 0;
            this.dgv_1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_1_CellMouseClick);
            // 
            // dgv_2
            // 
            this.dgv_2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_2.Location = new System.Drawing.Point(553, 48);
            this.dgv_2.Name = "dgv_2";
            this.dgv_2.RowTemplate.Height = 21;
            this.dgv_2.Size = new System.Drawing.Size(263, 173);
            this.dgv_2.TabIndex = 1;
            this.dgv_2.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_2_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Harga :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock :";
            // 
            // pnl_name
            // 
            this.pnl_name.Location = new System.Drawing.Point(105, 355);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(385, 19);
            this.pnl_name.TabIndex = 7;
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(616, 239);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(200, 19);
            this.lbl_name.TabIndex = 8;
            // 
            // CBT_1
            // 
            this.CBT_1.FormattingEnabled = true;
            this.CBT_1.Location = new System.Drawing.Point(105, 379);
            this.CBT_1.Name = "CBT_1";
            this.CBT_1.Size = new System.Drawing.Size(121, 20);
            this.CBT_1.TabIndex = 9;
            // 
            // CBT_2
            // 
            this.CBT_2.Enabled = false;
            this.CBT_2.FormattingEnabled = true;
            this.CBT_2.Location = new System.Drawing.Point(369, 22);
            this.CBT_2.Name = "CBT_2";
            this.CBT_2.Size = new System.Drawing.Size(121, 20);
            this.CBT_2.TabIndex = 10;
            // 
            // pnl_harga
            // 
            this.pnl_harga.Location = new System.Drawing.Point(105, 405);
            this.pnl_harga.Name = "pnl_harga";
            this.pnl_harga.Size = new System.Drawing.Size(121, 19);
            this.pnl_harga.TabIndex = 11;
            this.pnl_harga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pnl_harga_KeyPress);
            // 
            // lbl_stok
            // 
            this.lbl_stok.Location = new System.Drawing.Point(105, 429);
            this.lbl_stok.Name = "lbl_stok";
            this.lbl_stok.Size = new System.Drawing.Size(121, 19);
            this.lbl_stok.TabIndex = 12;
            this.lbl_stok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbl_stok_KeyPress);
            // 
            // btn_btn_btn
            // 
            this.btn_btn_btn.Location = new System.Drawing.Point(278, 20);
            this.btn_btn_btn.Name = "btn_btn_btn";
            this.btn_btn_btn.Size = new System.Drawing.Size(40, 23);
            this.btn_btn_btn.TabIndex = 13;
            this.btn_btn_btn.Text = "all";
            this.btn_btn_btn.UseVisualStyleBackColor = true;
            this.btn_btn_btn.Click += new System.EventHandler(this.btn_btn_btn_Click);
            // 
            // btn_btn_btn_btn
            // 
            this.btn_btn_btn_btn.Location = new System.Drawing.Point(323, 20);
            this.btn_btn_btn_btn.Name = "btn_btn_btn_btn";
            this.btn_btn_btn_btn.Size = new System.Drawing.Size(40, 23);
            this.btn_btn_btn_btn.TabIndex = 14;
            this.btn_btn_btn_btn.Text = "filter";
            this.btn_btn_btn_btn.UseVisualStyleBackColor = true;
            this.btn_btn_btn_btn.Click += new System.EventHandler(this.btn_btn_btn_btn_Click);
            // 
            // catadd
            // 
            this.catadd.Location = new System.Drawing.Point(680, 266);
            this.catadd.Name = "catadd";
            this.catadd.Size = new System.Drawing.Size(66, 49);
            this.catadd.TabIndex = 15;
            this.catadd.Text = "Add Category";
            this.catadd.UseVisualStyleBackColor = true;
            this.catadd.Click += new System.EventHandler(this.catadd_Click);
            // 
            // edit2
            // 
            this.edit2.Location = new System.Drawing.Point(752, 266);
            this.edit2.Name = "edit2";
            this.edit2.Size = new System.Drawing.Size(66, 49);
            this.edit2.TabIndex = 16;
            this.edit2.Text = "Remove Category";
            this.edit2.UseVisualStyleBackColor = true;
            this.edit2.Click += new System.EventHandler(this.edit2_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(280, 404);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(66, 49);
            this.add.TabIndex = 17;
            this.add.Text = "Add Product";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(352, 404);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(66, 49);
            this.edit.TabIndex = 18;
            this.edit.Text = "Edit Product";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // rem_whos_rem
            // 
            this.rem_whos_rem.Location = new System.Drawing.Point(424, 404);
            this.rem_whos_rem.Name = "rem_whos_rem";
            this.rem_whos_rem.Size = new System.Drawing.Size(66, 49);
            this.rem_whos_rem.TabIndex = 19;
            this.rem_whos_rem.Text = "Remove Product";
            this.rem_whos_rem.UseVisualStyleBackColor = true;
            this.rem_whos_rem.Click += new System.EventHandler(this.rem_whos_rem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(533, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Category";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 484);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rem_whos_rem);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.edit2);
            this.Controls.Add(this.catadd);
            this.Controls.Add(this.btn_btn_btn_btn);
            this.Controls.Add(this.btn_btn_btn);
            this.Controls.Add(this.lbl_stok);
            this.Controls.Add(this.pnl_harga);
            this.Controls.Add(this.CBT_2);
            this.Controls.Add(this.CBT_1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_2);
            this.Controls.Add(this.dgv_1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_1;
        private System.Windows.Forms.DataGridView dgv_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pnl_name;
        private System.Windows.Forms.TextBox lbl_name;
        private System.Windows.Forms.ComboBox CBT_1;
        private System.Windows.Forms.ComboBox CBT_2;
        private System.Windows.Forms.TextBox pnl_harga;
        private System.Windows.Forms.TextBox lbl_stok;
        private System.Windows.Forms.Button btn_btn_btn;
        private System.Windows.Forms.Button btn_btn_btn_btn;
        private System.Windows.Forms.Button catadd;
        private System.Windows.Forms.Button edit2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button rem_whos_rem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

