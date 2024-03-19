using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classassignmentweek5
{
    public partial class Form1 : Form
    {// Sean Matthew-0706022310037
        DataTable dt = new DataTable();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Team ID", typeof(string));
            dt.Columns.Add("Nama Team", typeof(string));
            dt.Columns.Add("Nama Stadium", typeof(string));
            dt.Columns.Add("Kota", typeof(string));
            dt.Columns.Add("Kapasitas", typeof(string));
            dt.Columns.Add("Nama Manager", typeof(string));
            dataGridView1.DataSource = dt;
        }

        private void btn_input_Click(object sender, EventArgs e)
        {
            bool cek = false;
            if (tb_NamaTeam.Text != "" && tb_Nama_Stadium.Text != "" && tb_Kota.Text != "" && tb_Kapasitas.Text != "" && tb_Nama_Manager.Text != "")
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Nama Team"].ToString() == tb_NamaTeam.Text)
                    {
                        cek = true;
                    }
                    if (row["Nama Stadium"].ToString() == tb_Nama_Stadium.Text)
                    {
                        cek = true;
                    }
                    if (row["Nama Manager"].ToString() == tb_Nama_Manager.Text)
                    {
                        cek = true;
                    }
                }
                if (cek)
                {
                    MessageBox.Show("Cannot be the same");
                }
                else if (cek == false)
                {
                    dt.Rows.Add(tb_TeamID.Text, tb_NamaTeam.Text, tb_Nama_Stadium.Text, tb_Nama_Manager.Text, tb_Kapasitas.Text, tb_Kota.Text);
                }
            }
            else
            {
                MessageBox.Show("Cannot be blank");   
            }
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
            }
            



            tb_Kota.Clear();
            tb_Kapasitas.Clear();
            tb_NamaTeam.Clear();
            tb_Nama_Manager.Clear();
            tb_Nama_Stadium.Clear();
        }

        private void tb_NamaTeam_TextChanged(object sender, EventArgs e)
        {
            char penampung;
            string nampung;
            int counter = 1;
            if (tb_NamaTeam.Text !="")
            {
                penampung = tb_NamaTeam.Text[0];
                nampung = penampung.ToString();
                penampung = Convert.ToChar(nampung.ToUpper());
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (penampung == dt.Rows[i][0].ToString()[0])
                    {
                        counter++;
                    }
                }
                if (counter < 10)
                {
                    tb_TeamID.Text = penampung + "0" + counter.ToString();
                }
            }
            
        }
    }
}
