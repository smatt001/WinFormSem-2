namespace TH02_0706022310037
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            inpt1 = new Label();
            inpt2 = new Label();
            inpt3 = new Label();
            inpt4 = new Label();
            inpt5 = new Label();
            Play = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(40, 18);
            label1.Name = "label1";
            label1.Size = new Size(224, 29);
            label1.TabIndex = 0;
            label1.Text = "Guess The Word";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(99, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(99, 87);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(99, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 3;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(99, 161);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 4;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(99, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 5;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // inpt1
            // 
            inpt1.AutoSize = true;
            inpt1.Location = new Point(23, 53);
            inpt1.Name = "inpt1";
            inpt1.Size = new Size(73, 25);
            inpt1.TabIndex = 6;
            inpt1.Text = "Input 1:";
            inpt1.Click += inpt1_Click;
            // 
            // inpt2
            // 
            inpt2.AutoSize = true;
            inpt2.Location = new Point(19, 89);
            inpt2.Name = "inpt2";
            inpt2.Size = new Size(78, 25);
            inpt2.TabIndex = 7;
            inpt2.Text = "Input 2 :";
            // 
            // inpt3
            // 
            inpt3.AutoSize = true;
            inpt3.Location = new Point(19, 130);
            inpt3.Name = "inpt3";
            inpt3.Size = new Size(78, 25);
            inpt3.TabIndex = 8;
            inpt3.Text = "Input 3 :";
            // 
            // inpt4
            // 
            inpt4.AutoSize = true;
            inpt4.Location = new Point(23, 167);
            inpt4.Name = "inpt4";
            inpt4.Size = new Size(78, 25);
            inpt4.TabIndex = 9;
            inpt4.Text = "Input 4 :";
            // 
            // inpt5
            // 
            inpt5.AutoSize = true;
            inpt5.Location = new Point(23, 204);
            inpt5.Name = "inpt5";
            inpt5.Size = new Size(78, 25);
            inpt5.TabIndex = 10;
            inpt5.Text = "Input 5 :";
            // 
            // Play
            // 
            Play.Location = new Point(99, 249);
            Play.Name = "Play";
            Play.Size = new Size(139, 44);
            Play.TabIndex = 11;
            Play.Text = "PLAY";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Play);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(inpt5);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(inpt4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(inpt3);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(inpt2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(inpt1);
            panel1.Controls.Add(textBox5);
            panel1.Location = new Point(120, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 314);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 363);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label inpt1;
        private Label inpt2;
        private Label inpt3;
        private Label inpt4;
        private Label inpt5;
        private Button Play;
        private Panel panel1;
    }
}