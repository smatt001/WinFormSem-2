namespace TH03_0706022310037_sem02_fixed
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logintopnl = new Button();
            registopnl = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userbox = new TextBox();
            passbox = new TextBox();
            regispnl = new Panel();
            registerbtn = new Button();
            passregisbox = new TextBox();
            userregisbox = new TextBox();
            logoutbtn = new Button();
            depositpnl = new Panel();
            depositbtn = new Button();
            withdrawpnl = new Panel();
            withdrawbtn = new Button();
            withdrawbox = new TextBox();
            label5 = new Label();
            depositbox = new TextBox();
            label4 = new Label();
            balancepnl = new Panel();
            withdrawtopnl = new Button();
            balancedisp = new Label();
            deposittopnl = new Button();
            label6 = new Label();
            regispnl.SuspendLayout();
            depositpnl.SuspendLayout();
            withdrawpnl.SuspendLayout();
            balancepnl.SuspendLayout();
            SuspendLayout();
            // 
            // logintopnl
            // 
            logintopnl.Location = new Point(274, 198);
            logintopnl.Name = "logintopnl";
            logintopnl.Size = new Size(112, 34);
            logintopnl.TabIndex = 0;
            logintopnl.Text = "Login";
            logintopnl.UseVisualStyleBackColor = true;
            logintopnl.Click += logintopnl_Click;
            // 
            // registopnl
            // 
            registopnl.Location = new Point(274, 238);
            registopnl.Name = "registopnl";
            registopnl.Size = new Size(112, 34);
            registopnl.TabIndex = 1;
            registopnl.Text = "Register";
            registopnl.UseVisualStyleBackColor = true;
            registopnl.Click += registopnl_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 57);
            label1.Name = "label1";
            label1.Size = new Size(142, 36);
            label1.TabIndex = 2;
            label1.Text = "UC Bank";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 112);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 3;
            label2.Text = "Username :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 154);
            label3.Name = "label3";
            label3.Size = new Size(96, 25);
            label3.TabIndex = 4;
            label3.Text = "Password :";
            // 
            // userbox
            // 
            userbox.Location = new Point(254, 109);
            userbox.Name = "userbox";
            userbox.Size = new Size(150, 31);
            userbox.TabIndex = 5;
            // 
            // passbox
            // 
            passbox.Location = new Point(254, 151);
            passbox.Name = "passbox";
            passbox.Size = new Size(150, 31);
            passbox.TabIndex = 6;
            // 
            // regispnl
            // 
            regispnl.Controls.Add(registerbtn);
            regispnl.Controls.Add(passregisbox);
            regispnl.Controls.Add(userregisbox);
            regispnl.Location = new Point(241, 96);
            regispnl.Name = "regispnl";
            regispnl.Size = new Size(186, 176);
            regispnl.TabIndex = 7;
            // 
            // registerbtn
            // 
            registerbtn.Location = new Point(33, 95);
            registerbtn.Name = "registerbtn";
            registerbtn.Size = new Size(111, 34);
            registerbtn.TabIndex = 9;
            registerbtn.Text = "Register";
            registerbtn.UseVisualStyleBackColor = true;
            registerbtn.Click += registerbtn_Click;
            // 
            // passregisbox
            // 
            passregisbox.Location = new Point(17, 58);
            passregisbox.Name = "passregisbox";
            passregisbox.Size = new Size(149, 31);
            passregisbox.TabIndex = 10;
            // 
            // userregisbox
            // 
            userregisbox.Location = new Point(17, 16);
            userregisbox.Name = "userregisbox";
            userregisbox.Size = new Size(149, 31);
            userregisbox.TabIndex = 9;
            // 
            // logoutbtn
            // 
            logoutbtn.Location = new Point(452, 282);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(111, 34);
            logoutbtn.TabIndex = 10;
            logoutbtn.Text = "Logout";
            logoutbtn.UseVisualStyleBackColor = true;
            logoutbtn.Click += logoutbtn_Click;
            // 
            // depositpnl
            // 
            depositpnl.Controls.Add(depositbtn);
            depositpnl.Controls.Add(depositbox);
            depositpnl.Controls.Add(label4);
            depositpnl.Location = new Point(576, 333);
            depositpnl.Name = "depositpnl";
            depositpnl.Size = new Size(300, 182);
            depositpnl.TabIndex = 11;
            // 
            // depositbtn
            // 
            depositbtn.Location = new Point(102, 92);
            depositbtn.Name = "depositbtn";
            depositbtn.Size = new Size(111, 34);
            depositbtn.TabIndex = 12;
            depositbtn.Text = "Deposit";
            depositbtn.UseVisualStyleBackColor = true;
            depositbtn.Click += depositbtn_Click;
            // 
            // withdrawpnl
            // 
            withdrawpnl.Controls.Add(withdrawbtn);
            withdrawpnl.Controls.Add(withdrawbox);
            withdrawpnl.Controls.Add(label5);
            withdrawpnl.Location = new Point(148, 333);
            withdrawpnl.Name = "withdrawpnl";
            withdrawpnl.Size = new Size(300, 182);
            withdrawpnl.TabIndex = 12;
            // 
            // withdrawbtn
            // 
            withdrawbtn.Location = new Point(91, 92);
            withdrawbtn.Name = "withdrawbtn";
            withdrawbtn.Size = new Size(111, 34);
            withdrawbtn.TabIndex = 12;
            withdrawbtn.Text = "Withdraw";
            withdrawbtn.UseVisualStyleBackColor = true;
            withdrawbtn.Click += withdrawbtn_Click;
            // 
            // withdrawbox
            // 
            withdrawbox.Location = new Point(71, 48);
            withdrawbox.Name = "withdrawbox";
            withdrawbox.Size = new Size(149, 31);
            withdrawbox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 9);
            label5.Name = "label5";
            label5.Size = new Size(216, 25);
            label5.TabIndex = 12;
            label5.Text = "Insert Withdraw Amount :";
            // 
            // depositbox
            // 
            depositbox.Location = new Point(82, 48);
            depositbox.Name = "depositbox";
            depositbox.Size = new Size(149, 31);
            depositbox.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 9);
            label4.Name = "label4";
            label4.Size = new Size(202, 25);
            label4.TabIndex = 12;
            label4.Text = "Insert Deposit Amount :";
            // 
            // balancepnl
            // 
            balancepnl.Controls.Add(withdrawtopnl);
            balancepnl.Controls.Add(balancedisp);
            balancepnl.Controls.Add(deposittopnl);
            balancepnl.Controls.Add(label6);
            balancepnl.Location = new Point(576, 90);
            balancepnl.Name = "balancepnl";
            balancepnl.Size = new Size(300, 182);
            balancepnl.TabIndex = 13;
            // 
            // withdrawtopnl
            // 
            withdrawtopnl.Location = new Point(103, 128);
            withdrawtopnl.Name = "withdrawtopnl";
            withdrawtopnl.Size = new Size(112, 34);
            withdrawtopnl.TabIndex = 15;
            withdrawtopnl.Text = "Withdraw";
            withdrawtopnl.UseVisualStyleBackColor = true;
            withdrawtopnl.Click += withdrawtopnl_Click;
            // 
            // balancedisp
            // 
            balancedisp.AutoSize = true;
            balancedisp.Location = new Point(103, 60);
            balancedisp.Name = "balancedisp";
            balancedisp.Size = new Size(22, 25);
            balancedisp.TabIndex = 15;
            balancedisp.Text = "0";
            // 
            // deposittopnl
            // 
            deposittopnl.Location = new Point(103, 88);
            deposittopnl.Name = "deposittopnl";
            deposittopnl.Size = new Size(112, 34);
            deposittopnl.TabIndex = 14;
            deposittopnl.Text = "Deposit";
            deposittopnl.UseVisualStyleBackColor = true;
            deposittopnl.Click += deposittopnl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 60);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 14;
            label6.Text = "Balance :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 562);
            Controls.Add(balancepnl);
            Controls.Add(withdrawpnl);
            Controls.Add(depositpnl);
            Controls.Add(logoutbtn);
            Controls.Add(regispnl);
            Controls.Add(passbox);
            Controls.Add(userbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(registopnl);
            Controls.Add(logintopnl);
            Name = "Form1";
            Text = "Form1";
            regispnl.ResumeLayout(false);
            regispnl.PerformLayout();
            depositpnl.ResumeLayout(false);
            depositpnl.PerformLayout();
            withdrawpnl.ResumeLayout(false);
            withdrawpnl.PerformLayout();
            balancepnl.ResumeLayout(false);
            balancepnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logintopnl;
        private Button registopnl;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userbox;
        private TextBox passbox;
        private Panel regispnl;
        private TextBox passregisbox;
        private TextBox userregisbox;
        private Button registerbtn;
        private Button logoutbtn;
        private Panel depositpnl;
        private Button depositbtn;
        private TextBox depositbox;
        private Label label4;
        private Panel withdrawpnl;
        private Button withdrawbtn;
        private TextBox withdrawbox;
        private Label label5;
        private Panel balancepnl;
        private Label label6;
        private Button withdrawtopnl;
        private Label balancedisp;
        private Button deposittopnl;
    }
}