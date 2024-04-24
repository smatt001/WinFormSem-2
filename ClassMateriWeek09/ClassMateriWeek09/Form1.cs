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

namespace ClassMateriWeek09
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlconnect; //bantu connect to mysql
        MySqlCommand sqlCommand; // execute query yang di tulis
        MySqlDataAdapter Adapter; // menampung query ?
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server = 10.10.10.136; uid = student;password = isbmantap;database = premier_league");
            sqlconnect.Open();
            MessageBox.Show("opened");
            sqlconnect.Close();
            string sqlquery = "SELECT *From PLAYER";
            DataTable dtplayer = new DataTable();
            sqlCommand = new MySqlCommand(sqlquery, sqlconnect);
            Adapter = new MySqlDataAdapter(sqlCommand);
            Adapter.Fill(dtplayer);
            dgv_data.DataSource = dtplayer;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            sqlconnect = new MySqlConnection("server = 10.10.10.136; uid = student; password = isbmantap; database = premier_league");
            sqlconnect.Open();
            MessageBox.Show("opened2");
            sqlconnect.Close();
            string sqlquery = "SELECT *From MAHASISWA";
            DataTable dtmahasiswa = new DataTable();
            sqlCommand = new MySqlCommand(sqlquery, sqlconnect);
            Adapter = new MySqlDataAdapter(sqlCommand);
            Adapter.Fill(dtmahasiswa);
            dgv_mahasiswa.DataSource = dtmahasiswa;
        }


        private void btn_submit_Click(object sender, EventArgs e)
        {
            string Query = "insert into MAHASISWA values('0706022310037', 'Sean Matthew', 'Surabaya')";
            sqlconnect = new MySqlConnection("server = 10.10.10.136; uid = student; password = isbmantap; database = premier_league");
            sqlCommand = new MySqlCommand(Query, sqlconnect);
            sqlconnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlconnect.Close();
            
        }
    }
}
