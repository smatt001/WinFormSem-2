namespace ClassMateriWeek05
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
            this.tb_button_number = new System.Windows.Forms.TextBox();
            this.tb_Remove_Button = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_button_number
            // 
            this.tb_button_number.Location = new System.Drawing.Point(53, 49);
            this.tb_button_number.Name = "tb_button_number";
            this.tb_button_number.Size = new System.Drawing.Size(143, 31);
            this.tb_button_number.TabIndex = 1;
            // 
            // tb_Remove_Button
            // 
            this.tb_Remove_Button.Location = new System.Drawing.Point(53, 291);
            this.tb_Remove_Button.Name = "tb_Remove_Button";
            this.tb_Remove_Button.Size = new System.Drawing.Size(143, 31);
            this.tb_Remove_Button.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 735);
            this.Controls.Add(this.tb_Remove_Button);
            this.Controls.Add(this.tb_button_number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_button_number;
        private System.Windows.Forms.TextBox tb_Remove_Button;
    }
}

