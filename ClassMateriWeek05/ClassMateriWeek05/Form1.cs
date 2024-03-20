using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassMateriWeek05
{
    public partial class Form1 : Form
    {
        int x = 250;
        int y = 100;
        List<Button> list_btn = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Button btn_show = new Button();
            btn_show.Name = "Hello";
            btn_show.Visible = true;
            btn_show.Text = "Add";
            btn_show.Size = new System.Drawing.Size(120, 55);
            btn_show.BackColor = System.Drawing.Color.Black;
            btn_show.Location = new System.Drawing.Point(25, 43);
            btn_show.ForeColor = System.Drawing.Color.Yellow;
            btn_show.Click += btn_show_CLick;
            this.Controls.Add(btn_show);

            Button btn = new Button();
            btn.Name = "Hello";
            btn.Visible = true;
            btn.Text = "Remove";
            btn.Size = new System.Drawing.Size(120, 55);
            btn.BackColor = System.Drawing.Color.Black;
            btn.Location = new System.Drawing.Point(25, 170);
            btn.ForeColor = System.Drawing.Color.Yellow;
            btn.Click += btn_CLick;
            this.Controls.Add(btn);
        }
        private void btn_show_CLick (object sender, EventArgs e)
        {
            for (int i = 0; i < Convert.ToInt32(tb_button_number.Text); i++)
            {
                Button btn_show = new Button();
                btn_show.Name = "Hello";
                btn_show.Visible = true;
                btn_show.Text = "Button Ke-" + i;
                btn_show.Size = new System.Drawing.Size(100, 45);
                btn_show.BackColor = System.Drawing.Color.Black;
                btn_show.Location = new System.Drawing.Point(x, y);
                btn_show.ForeColor = System.Drawing.Color.Yellow;
                btn_show.Click += btn_mulitple;
                this.Controls.Add(btn_show);
                list_btn.Insert(0, btn_show);

                if (list_btn.Count == 5)
                {
                    x += 100;
                    y = 50;
                }
                y += 55;
            }
        }
        
        private void btn_CLick(object sender, EventArgs e)
        {
            if (list_btn.Count> 0)
            {
                Button buttonToRemove = list_btn[0];
                list_btn.Remove(buttonToRemove);
                this.Controls.Remove(buttonToRemove);
            }
        }
        private void btn_mulitple (object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        

        
    }
}
