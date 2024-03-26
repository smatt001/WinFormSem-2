namespace ClassAssignmentWeek06
{
    partial class Main
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
            this.pnl_Start = new System.Windows.Forms.Panel();
            this.tb_Size = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.lbl_Merah = new System.Windows.Forms.Label();
            this.lbl_Biru = new System.Windows.Forms.Label();
            this.lbl_Blue = new System.Windows.Forms.Label();
            this.lbl_Red = new System.Windows.Forms.Label();
            this.pnl_Start.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Start
            // 
            this.pnl_Start.Controls.Add(this.btn_Start);
            this.pnl_Start.Controls.Add(this.label1);
            this.pnl_Start.Controls.Add(this.tb_Size);
            this.pnl_Start.Location = new System.Drawing.Point(883, 12);
            this.pnl_Start.Name = "pnl_Start";
            this.pnl_Start.Size = new System.Drawing.Size(277, 132);
            this.pnl_Start.TabIndex = 0;
            // 
            // tb_Size
            // 
            this.tb_Size.Location = new System.Drawing.Point(115, 34);
            this.tb_Size.Name = "tb_Size";
            this.tb_Size.Size = new System.Drawing.Size(136, 26);
            this.tb_Size.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input Size :";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(115, 66);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(112, 40);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pnl_Main
            // 
            this.pnl_Main.Controls.Add(this.lbl_Blue);
            this.pnl_Main.Controls.Add(this.lbl_Red);
            this.pnl_Main.Controls.Add(this.lbl_Biru);
            this.pnl_Main.Controls.Add(this.lbl_Merah);
            this.pnl_Main.Location = new System.Drawing.Point(12, 12);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(865, 435);
            this.pnl_Main.TabIndex = 2;
            // 
            // lbl_Merah
            // 
            this.lbl_Merah.AutoSize = true;
            this.lbl_Merah.Location = new System.Drawing.Point(588, 65);
            this.lbl_Merah.Name = "lbl_Merah";
            this.lbl_Merah.Size = new System.Drawing.Size(54, 20);
            this.lbl_Merah.TabIndex = 0;
            this.lbl_Merah.Text = "Merah";
            // 
            // lbl_Biru
            // 
            this.lbl_Biru.AutoSize = true;
            this.lbl_Biru.Location = new System.Drawing.Point(662, 65);
            this.lbl_Biru.Name = "lbl_Biru";
            this.lbl_Biru.Size = new System.Drawing.Size(37, 20);
            this.lbl_Biru.TabIndex = 1;
            this.lbl_Biru.Text = "Biru";
            // 
            // lbl_Blue
            // 
            this.lbl_Blue.AutoSize = true;
            this.lbl_Blue.Location = new System.Drawing.Point(662, 95);
            this.lbl_Blue.Name = "lbl_Blue";
            this.lbl_Blue.Size = new System.Drawing.Size(18, 20);
            this.lbl_Blue.TabIndex = 3;
            this.lbl_Blue.Text = "0";
            // 
            // lbl_Red
            // 
            this.lbl_Red.AutoSize = true;
            this.lbl_Red.Location = new System.Drawing.Point(588, 95);
            this.lbl_Red.Name = "lbl_Red";
            this.lbl_Red.Size = new System.Drawing.Size(18, 20);
            this.lbl_Red.TabIndex = 2;
            this.lbl_Red.Text = "0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Start);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.pnl_Start.ResumeLayout(false);
            this.pnl_Start.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            this.pnl_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Size;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Label lbl_Blue;
        private System.Windows.Forms.Label lbl_Red;
        private System.Windows.Forms.Label lbl_Biru;
        private System.Windows.Forms.Label lbl_Merah;
    }
}

