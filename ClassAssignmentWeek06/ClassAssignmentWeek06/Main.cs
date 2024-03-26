using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassAssignmentWeek06
{
    public partial class Main : Form
    {
        int x = 8, y = 9;
        List<Button> list_Btn = new List<Button>();
        int ukuran = 0;
        int merah = 0;
        int biru = 0;
        public Main()
        {
            InitializeComponent();
        }

        

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            int counter = 1;
            ukuran = Convert.ToInt32(tb_Size.Text);
            if (ukuran < 3 || ukuran > 9 || ukuran % 2 == 0)
            {
                MessageBox.Show("Size cannot be smaller than 3 or bigger than 9 or be an even number");
            }
            else
            {
                for (int i = 0; i < ukuran ; i++)
                {
                    for (int j = 0; j < ukuran ; j++)
                    {
                        Button btn_show = new Button();
                        btn_show.Name = "Play";
                        btn_show.Tag = counter.ToString();
                        btn_show.Visible = true;
                        btn_show.Size = new System.Drawing.Size(40, 40);
                        btn_show.Location = new System.Drawing.Point(i *40, j*40);
                        btn_show.Click += btn_game;
                        list_Btn.Insert(0, btn_show);
                        counter++;
                        this.pnl_Main.Controls.Add(btn_show);
                    }
                }
            }
            
        }
        private void btn_game (object sender, EventArgs e)
        {
            Button tombol = (Button)sender;
            if (tombol.BackColor == Color.Red)
            {
                tombol.BackColor = Color.Blue;
            }
            else
            {
                tombol.BackColor = Color.Red;
            }
            int cek = Convert.ToInt32(tombol.Tag) - 1;
            int cek2 = Convert.ToInt32(tombol.Tag) + 1;
            int cek3 = Convert.ToInt32(tombol.Tag) + ukuran;
            int cek4 = Convert.ToInt32(tombol.Tag) - ukuran;

            if (Convert.ToInt32(tombol.Tag)%ukuran == 0)
            {
                cek2 = 0;
            }

            if (Convert.ToInt32(tombol.Tag)%ukuran == 1)
            {
                cek = 0;
            }

            foreach(Button a in list_Btn)
            {
                if (a.Tag.ToString() == cek.ToString() || a.Tag.ToString() == cek2.ToString() ||
                    a.Tag.ToString() == cek3.ToString() || a.Tag.ToString() == cek4.ToString())
                {
                    if (a.BackColor == Color.Red)
                    {
                        a.BackColor = Color.Blue;
                    }
                    else if (a.BackColor == Color.Blue)
                    {
                        a.BackColor= Color.Red;
                    }
                }
            }

            merah = 0;
            biru = 0;
            foreach (Button a in list_Btn)
            {
                if (a.BackColor == Color.Red)
                {
                    merah++;
                }
                if (a.BackColor == Color.Blue)
                {
                    biru++;
                }
            }
            if (merah == ukuran * ukuran || biru == ukuran * ukuran)
            {
                MessageBox.Show("WINNN");
            }

            lbl_Blue.Text = biru.ToString();
            lbl_Red.Text = merah.ToString();
        }
    }
}
