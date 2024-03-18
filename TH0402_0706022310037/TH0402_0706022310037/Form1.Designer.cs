namespace TH0402_0706022310037
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
            this.cb_choose_nation = new System.Windows.Forms.ComboBox();
            this.cb_choose_team = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_members = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_team_name = new System.Windows.Forms.TextBox();
            this.tb_team_country = new System.Windows.Forms.TextBox();
            this.tb_team_city = new System.Windows.Forms.TextBox();
            this.tb_player_name = new System.Windows.Forms.TextBox();
            this.tb_player_number = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_player_position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Nation";
            // 
            // cb_choose_nation
            // 
            this.cb_choose_nation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choose_nation.FormattingEnabled = true;
            this.cb_choose_nation.Location = new System.Drawing.Point(87, 84);
            this.cb_choose_nation.Name = "cb_choose_nation";
            this.cb_choose_nation.Size = new System.Drawing.Size(167, 28);
            this.cb_choose_nation.TabIndex = 3;
            this.cb_choose_nation.SelectedIndexChanged += new System.EventHandler(this.CBCountryChangeWhenSelected);
            // 
            // cb_choose_team
            // 
            this.cb_choose_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_choose_team.FormattingEnabled = true;
            this.cb_choose_team.Location = new System.Drawing.Point(87, 138);
            this.cb_choose_team.Name = "cb_choose_team";
            this.cb_choose_team.Size = new System.Drawing.Size(167, 28);
            this.cb_choose_team.TabIndex = 4;
            this.cb_choose_team.SelectedIndexChanged += new System.EventHandler(this.CBTeamChangeWhenSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Team Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Team Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(354, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Team City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(653, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Player Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(653, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Player Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(653, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Player Position";
            // 
            // lb_members
            // 
            this.lb_members.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_members.FormattingEnabled = true;
            this.lb_members.ItemHeight = 20;
            this.lb_members.Location = new System.Drawing.Point(29, 190);
            this.lb_members.Name = "lb_members";
            this.lb_members.Size = new System.Drawing.Size(297, 224);
            this.lb_members.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(332, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DeletePlayer);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(501, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnAddTeam);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(821, 184);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 32);
            this.button3.TabIndex = 15;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnAddPlayer);
            // 
            // tb_team_name
            // 
            this.tb_team_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_team_name.Location = new System.Drawing.Point(399, 84);
            this.tb_team_name.Name = "tb_team_name";
            this.tb_team_name.Size = new System.Drawing.Size(160, 26);
            this.tb_team_name.TabIndex = 16;
            // 
            // tb_team_country
            // 
            this.tb_team_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_team_country.Location = new System.Drawing.Point(399, 136);
            this.tb_team_country.Name = "tb_team_country";
            this.tb_team_country.Size = new System.Drawing.Size(160, 26);
            this.tb_team_country.TabIndex = 17;
            // 
            // tb_team_city
            // 
            this.tb_team_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_team_city.Location = new System.Drawing.Point(395, 188);
            this.tb_team_city.Name = "tb_team_city";
            this.tb_team_city.Size = new System.Drawing.Size(160, 26);
            this.tb_team_city.TabIndex = 18;
            // 
            // tb_player_name
            // 
            this.tb_player_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_player_name.Location = new System.Drawing.Point(700, 84);
            this.tb_player_name.Name = "tb_player_name";
            this.tb_player_name.Size = new System.Drawing.Size(177, 26);
            this.tb_player_name.TabIndex = 19;
            // 
            // tb_player_number
            // 
            this.tb_player_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_player_number.Location = new System.Drawing.Point(700, 138);
            this.tb_player_number.Name = "tb_player_number";
            this.tb_player_number.Size = new System.Drawing.Size(177, 26);
            this.tb_player_number.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Adding Team";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(607, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Adding Player";
            // 
            // cb_player_position
            // 
            this.cb_player_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_player_position.FormattingEnabled = true;
            this.cb_player_position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cb_player_position.Location = new System.Drawing.Point(700, 190);
            this.cb_player_position.Name = "cb_player_position";
            this.cb_player_position.Size = new System.Drawing.Size(34, 28);
            this.cb_player_position.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 435);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_player_number);
            this.Controls.Add(this.tb_player_name);
            this.Controls.Add(this.tb_team_city);
            this.Controls.Add(this.tb_team_country);
            this.Controls.Add(this.tb_team_name);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_members);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_player_position);
            this.Controls.Add(this.cb_choose_team);
            this.Controls.Add(this.cb_choose_nation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_choose_nation;
        private System.Windows.Forms.ComboBox cb_choose_team;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lb_members;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_team_name;
        private System.Windows.Forms.TextBox tb_team_country;
        private System.Windows.Forms.TextBox tb_team_city;
        private System.Windows.Forms.TextBox tb_player_name;
        private System.Windows.Forms.TextBox tb_player_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_player_position;
    }
}

