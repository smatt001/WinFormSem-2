namespace TH09Sem2_0706022310037
{
    partial class MainPage
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
            this.dgv_Cart = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.topWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Tshirt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Shirt = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Pants = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_LongPants = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Shoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Jewelleries = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_Others = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SubTotal = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.lbl_harga3 = new System.Windows.Forms.Label();
            this.lbl_harga2 = new System.Windows.Forms.Label();
            this.lbl_harga1 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.pnl_Others = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_itemPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.btn_Upload = new System.Windows.Forms.Button();
            this.pb_Others = new System.Windows.Forms.PictureBox();
            this.pb_3 = new System.Windows.Forms.PictureBox();
            this.pb_1 = new System.Windows.Forms.PictureBox();
            this.pb_2 = new System.Windows.Forms.PictureBox();
            this.btn_AddOthers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnl_main.SuspendLayout();
            this.pnl_Others.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Others)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Cart
            // 
            this.dgv_Cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Cart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Cart.Location = new System.Drawing.Point(489, 36);
            this.dgv_Cart.Name = "dgv_Cart";
            this.dgv_Cart.RowHeadersWidth = 62;
            this.dgv_Cart.RowTemplate.Height = 28;
            this.dgv_Cart.Size = new System.Drawing.Size(463, 257);
            this.dgv_Cart.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topWearToolStripMenuItem,
            this.bottomWearToolStripMenuItem,
            this.accesoriesToolStripMenuItem,
            this.tsm_Others});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // topWearToolStripMenuItem
            // 
            this.topWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Tshirt,
            this.tsm_Shirt});
            this.topWearToolStripMenuItem.Name = "topWearToolStripMenuItem";
            this.topWearToolStripMenuItem.Size = new System.Drawing.Size(102, 29);
            this.topWearToolStripMenuItem.Text = "Top Wear";
            // 
            // tsm_Tshirt
            // 
            this.tsm_Tshirt.Name = "tsm_Tshirt";
            this.tsm_Tshirt.Size = new System.Drawing.Size(166, 34);
            this.tsm_Tshirt.Text = "T-Shirt";
            this.tsm_Tshirt.Click += new System.EventHandler(this.tsm_Tshirt_Click);
            // 
            // tsm_Shirt
            // 
            this.tsm_Shirt.Name = "tsm_Shirt";
            this.tsm_Shirt.Size = new System.Drawing.Size(166, 34);
            this.tsm_Shirt.Text = "Shirt";
            this.tsm_Shirt.Click += new System.EventHandler(this.tsm_Shirt_Click);
            // 
            // bottomWearToolStripMenuItem
            // 
            this.bottomWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Pants,
            this.tsm_LongPants});
            this.bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            this.bottomWearToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.bottomWearToolStripMenuItem.Text = "Bottom Wear";
            // 
            // tsm_Pants
            // 
            this.tsm_Pants.Name = "tsm_Pants";
            this.tsm_Pants.Size = new System.Drawing.Size(201, 34);
            this.tsm_Pants.Text = "Pants";
            this.tsm_Pants.Click += new System.EventHandler(this.tsm_Pants_Click);
            // 
            // tsm_LongPants
            // 
            this.tsm_LongPants.Name = "tsm_LongPants";
            this.tsm_LongPants.Size = new System.Drawing.Size(201, 34);
            this.tsm_LongPants.Text = "Long Pants";
            this.tsm_LongPants.Click += new System.EventHandler(this.tsm_LongPants_Click);
            // 
            // accesoriesToolStripMenuItem
            // 
            this.accesoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_Shoes,
            this.tsm_Jewelleries});
            this.accesoriesToolStripMenuItem.Name = "accesoriesToolStripMenuItem";
            this.accesoriesToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.accesoriesToolStripMenuItem.Text = "Accesories";
            // 
            // tsm_Shoes
            // 
            this.tsm_Shoes.Name = "tsm_Shoes";
            this.tsm_Shoes.Size = new System.Drawing.Size(195, 34);
            this.tsm_Shoes.Text = "Shoes";
            this.tsm_Shoes.Click += new System.EventHandler(this.tsm_Shoes_Click);
            // 
            // tsm_Jewelleries
            // 
            this.tsm_Jewelleries.Name = "tsm_Jewelleries";
            this.tsm_Jewelleries.Size = new System.Drawing.Size(195, 34);
            this.tsm_Jewelleries.Text = "Jewelleries";
            this.tsm_Jewelleries.Click += new System.EventHandler(this.tsm_Jewelleries_Click);
            // 
            // tsm_Others
            // 
            this.tsm_Others.Name = "tsm_Others";
            this.tsm_Others.Size = new System.Drawing.Size(81, 29);
            this.tsm_Others.Text = "Others";
            this.tsm_Others.Click += new System.EventHandler(this.tsm_Others_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(499, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sub-Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(548, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total :";
            // 
            // tb_SubTotal
            // 
            this.tb_SubTotal.Location = new System.Drawing.Point(638, 313);
            this.tb_SubTotal.Name = "tb_SubTotal";
            this.tb_SubTotal.Size = new System.Drawing.Size(156, 26);
            this.tb_SubTotal.TabIndex = 4;
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(638, 350);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(156, 26);
            this.tb_Total.TabIndex = 5;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(337, 265);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(109, 34);
            this.btn_3.TabIndex = 17;
            this.btn_3.Text = "Add To Cart";
            this.btn_3.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(185, 265);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(109, 34);
            this.btn_2.TabIndex = 16;
            this.btn_2.Text = "Add To Cart";
            this.btn_2.UseVisualStyleBackColor = true;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(24, 265);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(109, 34);
            this.btn_1.TabIndex = 15;
            this.btn_1.Text = "Add To Cart";
            this.btn_1.UseVisualStyleBackColor = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Location = new System.Drawing.Point(361, 214);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(57, 20);
            this.lbl_3.TabIndex = 11;
            this.lbl_3.Text = "Tshirt3";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(201, 214);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(57, 20);
            this.lbl_2.TabIndex = 10;
            this.lbl_2.Text = "Tshirt2";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(37, 214);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(57, 20);
            this.lbl_1.TabIndex = 9;
            this.lbl_1.Text = "Tshirt1";
            // 
            // pnl_main
            // 
            this.pnl_main.Controls.Add(this.lbl_harga3);
            this.pnl_main.Controls.Add(this.lbl_harga2);
            this.pnl_main.Controls.Add(this.lbl_harga1);
            this.pnl_main.Controls.Add(this.pb_3);
            this.pnl_main.Controls.Add(this.lbl_1);
            this.pnl_main.Controls.Add(this.btn_3);
            this.pnl_main.Controls.Add(this.lbl_2);
            this.pnl_main.Controls.Add(this.btn_2);
            this.pnl_main.Controls.Add(this.lbl_3);
            this.pnl_main.Controls.Add(this.btn_1);
            this.pnl_main.Controls.Add(this.pb_1);
            this.pnl_main.Controls.Add(this.pb_2);
            this.pnl_main.Location = new System.Drawing.Point(13, 37);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(470, 320);
            this.pnl_main.TabIndex = 18;
            // 
            // lbl_harga3
            // 
            this.lbl_harga3.AutoSize = true;
            this.lbl_harga3.Location = new System.Drawing.Point(361, 234);
            this.lbl_harga3.Name = "lbl_harga3";
            this.lbl_harga3.Size = new System.Drawing.Size(51, 20);
            this.lbl_harga3.TabIndex = 19;
            this.lbl_harga3.Text = "label3";
            // 
            // lbl_harga2
            // 
            this.lbl_harga2.AutoSize = true;
            this.lbl_harga2.Location = new System.Drawing.Point(201, 234);
            this.lbl_harga2.Name = "lbl_harga2";
            this.lbl_harga2.Size = new System.Drawing.Size(51, 20);
            this.lbl_harga2.TabIndex = 19;
            this.lbl_harga2.Text = "label3";
            // 
            // lbl_harga1
            // 
            this.lbl_harga1.AutoSize = true;
            this.lbl_harga1.Location = new System.Drawing.Point(37, 234);
            this.lbl_harga1.Name = "lbl_harga1";
            this.lbl_harga1.Size = new System.Drawing.Size(51, 20);
            this.lbl_harga1.TabIndex = 18;
            this.lbl_harga1.Text = "label3";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(824, 313);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(109, 34);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // pnl_Others
            // 
            this.pnl_Others.Controls.Add(this.btn_AddOthers);
            this.pnl_Others.Controls.Add(this.label5);
            this.pnl_Others.Controls.Add(this.label4);
            this.pnl_Others.Controls.Add(this.tb_itemPrice);
            this.pnl_Others.Controls.Add(this.label3);
            this.pnl_Others.Controls.Add(this.tb_ItemName);
            this.pnl_Others.Controls.Add(this.btn_Upload);
            this.pnl_Others.Controls.Add(this.pb_Others);
            this.pnl_Others.Location = new System.Drawing.Point(13, 373);
            this.pnl_Others.Name = "pnl_Others";
            this.pnl_Others.Size = new System.Drawing.Size(470, 295);
            this.pnl_Others.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Item Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item Name";
            // 
            // tb_itemPrice
            // 
            this.tb_itemPrice.Location = new System.Drawing.Point(205, 142);
            this.tb_itemPrice.Name = "tb_itemPrice";
            this.tb_itemPrice.Size = new System.Drawing.Size(134, 26);
            this.tb_itemPrice.TabIndex = 22;
            this.tb_itemPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_itemPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Upload Picture :";
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.Location = new System.Drawing.Point(205, 90);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(134, 26);
            this.tb_ItemName.TabIndex = 21;
            // 
            // btn_Upload
            // 
            this.btn_Upload.Location = new System.Drawing.Point(192, 20);
            this.btn_Upload.Name = "btn_Upload";
            this.btn_Upload.Size = new System.Drawing.Size(87, 30);
            this.btn_Upload.TabIndex = 21;
            this.btn_Upload.Text = "Upload";
            this.btn_Upload.UseVisualStyleBackColor = true;
            this.btn_Upload.Click += new System.EventHandler(this.btn_Upload_Click);
            // 
            // pb_Others
            // 
            this.pb_Others.Location = new System.Drawing.Point(54, 53);
            this.pb_Others.Name = "pb_Others";
            this.pb_Others.Size = new System.Drawing.Size(132, 194);
            this.pb_Others.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Others.TabIndex = 21;
            this.pb_Others.TabStop = false;
            // 
            // pb_3
            // 
            this.pb_3.Location = new System.Drawing.Point(325, 17);
            this.pb_3.Name = "pb_3";
            this.pb_3.Size = new System.Drawing.Size(132, 194);
            this.pb_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_3.TabIndex = 14;
            this.pb_3.TabStop = false;
            // 
            // pb_1
            // 
            this.pb_1.Location = new System.Drawing.Point(12, 17);
            this.pb_1.Name = "pb_1";
            this.pb_1.Size = new System.Drawing.Size(132, 194);
            this.pb_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_1.TabIndex = 12;
            this.pb_1.TabStop = false;
            // 
            // pb_2
            // 
            this.pb_2.Location = new System.Drawing.Point(171, 17);
            this.pb_2.Name = "pb_2";
            this.pb_2.Size = new System.Drawing.Size(132, 194);
            this.pb_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_2.TabIndex = 13;
            this.pb_2.TabStop = false;
            // 
            // btn_AddOthers
            // 
            this.btn_AddOthers.Location = new System.Drawing.Point(230, 213);
            this.btn_AddOthers.Name = "btn_AddOthers";
            this.btn_AddOthers.Size = new System.Drawing.Size(109, 34);
            this.btn_AddOthers.TabIndex = 21;
            this.btn_AddOthers.Text = "Add To Cart";
            this.btn_AddOthers.UseVisualStyleBackColor = true;
            this.btn_AddOthers.Click += new System.EventHandler(this.btn_AddOthers_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(964, 727);
            this.Controls.Add(this.pnl_Others);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.tb_Total);
            this.Controls.Add(this.tb_SubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Cart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_main.ResumeLayout(false);
            this.pnl_main.PerformLayout();
            this.pnl_Others.ResumeLayout(false);
            this.pnl_Others.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Others)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Cart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsm_Others;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SubTotal;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.ToolStripMenuItem tsm_Tshirt;
        private System.Windows.Forms.ToolStripMenuItem tsm_Shirt;
        private System.Windows.Forms.ToolStripMenuItem tsm_Pants;
        private System.Windows.Forms.ToolStripMenuItem tsm_LongPants;
        private System.Windows.Forms.ToolStripMenuItem tsm_Shoes;
        private System.Windows.Forms.ToolStripMenuItem tsm_Jewelleries;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox pb_3;
        private System.Windows.Forms.PictureBox pb_2;
        private System.Windows.Forms.PictureBox pb_1;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_harga3;
        private System.Windows.Forms.Label lbl_harga2;
        private System.Windows.Forms.Label lbl_harga1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel pnl_Others;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_itemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.Button btn_Upload;
        private System.Windows.Forms.PictureBox pb_Others;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_AddOthers;
    }
}

