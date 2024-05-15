using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClassMateriW12
{
    public partial class Form1 : Form
    {
        DataTable data = new DataTable();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conn = new MySqlConnection();
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        string date = DateTime.Now.Year.ToString() + '-' + DateTime.Now.Month.ToString() + '-' + DateTime.Now.Day.ToString();
        bool sama = false;

        string query = "";
        public Form1()
        {
            InitializeComponent();
            conn = new MySqlConnection("server=localhost;uid=root;password=isbmantap;database=premier_league");
            query = "Select * from student";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(data);
            dgv1.DataSource = data;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in data.Rows)
            {
                string data = row["student_nim"].ToString();
                if (tb_3.Text == data)
                {
                    sama = true;
                    break;
                }
                
            }

            if (sama)
            {
                MessageBox.Show("Gabisa Nim Sama banh");
            }
            else
            {
                query = $"INSERT INTO student values('{tb_1.Text}','{tb_2.Text}','{date}','{tb_3.Text}')";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                query = "Select * from student";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                data = new DataTable();
                adapter.Fill(data);
                dgv1.DataSource = data;
                tb_1.Clear();
                tb_2.Clear();
                tb_3.Clear();
            }
            

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            query = $"UPDATE student Set student_name='{tb_UpdateName.Text}',student_nim='{tb_UpdateNim.Text}' where id_student = '{tb_UpdateID.Text}'";
            conn.Open();
            cmd = new MySqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            query = "Select * from student";
            cmd = new MySqlCommand(query, conn);
            adapter = new MySqlDataAdapter(cmd);
            data = new DataTable();
            adapter.Fill(data);
            dgv1.DataSource = data;
            tb_1.Clear();
            tb_2.Clear();
            tb_3.Clear();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgv1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_UpdateID.Text = data.Rows[dgv1.CurrentRow.Index][0].ToString();
            tb_UpdateName.Text = data.Rows[dgv1.CurrentRow.Index][1].ToString();
            tb_UpdateNim.Text = data.Rows[dgv1.CurrentRow.Index][3].ToString();
        }
    }
}
