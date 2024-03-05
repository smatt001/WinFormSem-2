namespace classassweek03
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
            lbl_name = new Label();
            rb_male = new RadioButton();
            tb_name = new TextBox();
            tb_Age = new TextBox();
            lbl_Age = new Label();
            rb_female = new RadioButton();
            rb_Red = new RadioButton();
            rb_green = new RadioButton();
            rb_blue = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            cb_reading = new CheckBox();
            cb_watching = new CheckBox();
            cb_playsport = new CheckBox();
            label3 = new Label();
            tb_other = new TextBox();
            Submit_btn = new Button();
            panel1 = new Panel();
            cb_others = new CheckBox();
            btn_clear = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(16, 15);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(39, 15);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name";
            // 
            // rb_male
            // 
            rb_male.AutoSize = true;
            rb_male.Location = new Point(4, 3);
            rb_male.Name = "rb_male";
            rb_male.Size = new Size(51, 19);
            rb_male.TabIndex = 1;
            rb_male.TabStop = true;
            rb_male.Text = "Male";
            rb_male.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            tb_name.Location = new Point(99, 15);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(100, 23);
            tb_name.TabIndex = 2;
            tb_name.TextChanged += tb_name_TextChanged;
            // 
            // tb_Age
            // 
            tb_Age.Location = new Point(99, 44);
            tb_Age.Name = "tb_Age";
            tb_Age.Size = new Size(100, 23);
            tb_Age.TabIndex = 4;
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.Location = new Point(16, 44);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(28, 15);
            lbl_Age.TabIndex = 3;
            lbl_Age.Text = "Age";
            // 
            // rb_female
            // 
            rb_female.AutoSize = true;
            rb_female.Location = new Point(4, 28);
            rb_female.Name = "rb_female";
            rb_female.Size = new Size(63, 19);
            rb_female.TabIndex = 5;
            rb_female.TabStop = true;
            rb_female.Text = "Female";
            rb_female.UseVisualStyleBackColor = true;
            // 
            // rb_Red
            // 
            rb_Red.AutoSize = true;
            rb_Red.Location = new Point(99, 129);
            rb_Red.Name = "rb_Red";
            rb_Red.Size = new Size(45, 19);
            rb_Red.TabIndex = 6;
            rb_Red.TabStop = true;
            rb_Red.Text = "Red";
            rb_Red.UseVisualStyleBackColor = true;
            // 
            // rb_green
            // 
            rb_green.AutoSize = true;
            rb_green.Location = new Point(99, 154);
            rb_green.Name = "rb_green";
            rb_green.Size = new Size(56, 19);
            rb_green.TabIndex = 7;
            rb_green.TabStop = true;
            rb_green.Text = "Green";
            rb_green.UseVisualStyleBackColor = true;
            // 
            // rb_blue
            // 
            rb_blue.AutoSize = true;
            rb_blue.Location = new Point(99, 179);
            rb_blue.Name = "rb_blue";
            rb_blue.Size = new Size(48, 19);
            rb_blue.TabIndex = 8;
            rb_blue.TabStop = true;
            rb_blue.Text = "Blue";
            rb_blue.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 74);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 9;
            label1.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 131);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 10;
            label2.Text = "Favorite Color";
            // 
            // cb_reading
            // 
            cb_reading.AutoSize = true;
            cb_reading.Location = new Point(99, 206);
            cb_reading.Name = "cb_reading";
            cb_reading.Size = new Size(69, 19);
            cb_reading.TabIndex = 11;
            cb_reading.Text = "Reading";
            cb_reading.UseVisualStyleBackColor = true;
            // 
            // cb_watching
            // 
            cb_watching.AutoSize = true;
            cb_watching.Location = new Point(99, 231);
            cb_watching.Name = "cb_watching";
            cb_watching.Size = new Size(93, 19);
            cb_watching.TabIndex = 12;
            cb_watching.Text = "Watching TV";
            cb_watching.UseVisualStyleBackColor = true;
            // 
            // cb_playsport
            // 
            cb_playsport.AutoSize = true;
            cb_playsport.Location = new Point(99, 256);
            cb_playsport.Name = "cb_playsport";
            cb_playsport.Size = new Size(101, 19);
            cb_playsport.TabIndex = 13;
            cb_playsport.Text = "Playing Sports";
            cb_playsport.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 210);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 15;
            label3.Text = "Hobbies";
            // 
            // tb_other
            // 
            tb_other.Location = new Point(114, 281);
            tb_other.Name = "tb_other";
            tb_other.Size = new Size(100, 23);
            tb_other.TabIndex = 16;
            // 
            // Submit_btn
            // 
            Submit_btn.Location = new Point(93, 310);
            Submit_btn.Name = "Submit_btn";
            Submit_btn.Size = new Size(75, 23);
            Submit_btn.TabIndex = 17;
            Submit_btn.Text = "Submit";
            Submit_btn.UseVisualStyleBackColor = true;
            Submit_btn.Click += Submit_btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(rb_male);
            panel1.Controls.Add(rb_female);
            panel1.Location = new Point(94, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(74, 56);
            panel1.TabIndex = 18;
            // 
            // cb_others
            // 
            cb_others.AutoSize = true;
            cb_others.Location = new Point(47, 281);
            cb_others.Name = "cb_others";
            cb_others.Size = new Size(61, 19);
            cb_others.TabIndex = 19;
            cb_others.Text = "Others";
            cb_others.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(234, 310);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 20;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 450);
            Controls.Add(btn_clear);
            Controls.Add(cb_others);
            Controls.Add(panel1);
            Controls.Add(Submit_btn);
            Controls.Add(tb_other);
            Controls.Add(label3);
            Controls.Add(cb_playsport);
            Controls.Add(cb_watching);
            Controls.Add(cb_reading);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rb_blue);
            Controls.Add(rb_green);
            Controls.Add(rb_Red);
            Controls.Add(tb_Age);
            Controls.Add(lbl_Age);
            Controls.Add(tb_name);
            Controls.Add(lbl_name);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_name;
        private RadioButton rb_male;
        private TextBox tb_name;
        private TextBox tb_Age;
        private Label lbl_Age;
        private RadioButton rb_female;
        private RadioButton rb_Red;
        private RadioButton rb_green;
        private RadioButton rb_blue;
        private Label label1;
        private Label label2;
        private CheckBox cb_reading;
        private CheckBox cb_watching;
        private CheckBox cb_playsport;
        private Label label3;
        private TextBox tb_other;
        private Button Submit_btn;
        private Panel panel1;
        private CheckBox cb_others;
        private Button btn_clear;
    }
}