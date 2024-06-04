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

namespace ClassAssW15
{
    public partial class Form1 : Form
    {
       MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter adapter;
        string query = "";
        DataTable dteam1;
        DataTable dteam2;
        DataTable dgvdata;
        DataTable dtLable;
        string team1;
        string team2;   
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dteam1 = new DataTable();
                dteam2 = new DataTable();
                dtLable
                    = new DataTable();
                connection = new MySqlConnection("server = localhost; uid=root;pwd=isbmantap; database = premier_league");
                connection.Open();
                query = "SELECT t.team_name, t.team_id from team t, `dmatch` d";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dteam1);
                adapter.Fill(dteam2);
                query = "select t.team_name, m.manager_name, p.player_name from team t, player p, manager m where m.manager_id = t.assmanager_id and p.team_id = t.team_id and p.player_id = t.captain_id";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtLable);
                connection.Close();
                cb_Team1.DataSource = dteam1;
                cb_Team1.DisplayMember = "team_name";
                cb_Team1.ValueMember = "team_id";
                cb_Team2.DataSource = dteam2;
                cb_Team2.DisplayMember = "team_name";
                cb_Team2.ValueMember = "team_id";
                dataGridView1.DataSource = dtLable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cb_Team1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Team1.SelectedIndex == - 1)
            {

            }
            else
            {
                dtLable = new DataTable();
                query = $"select t.team_name, m.manager_name, p.player_name from team t, player p, manager m where m.manager_id = t.assmanager_id and p.team_id = t.team_id and p.player_id = t.captain_id and t.team_id = '{cb_Team1.SelectedValue}'";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtLable);
                if (dtLable.Rows.Count != 0)
                {
                    label2.Text = dtLable.Rows[0][1].ToString();
                    label3.Text = dtLable.Rows[0][2].ToString();
                }
            }
            team1 = cb_Team1.SelectedValue.ToString();
        }

        private void cb_Team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Team2.SelectedIndex == -1)
            {

            }
            else
            {
                dtLable = new DataTable();
                query = $"select t.team_name, m.manager_name, p.player_name from team t, player p, manager m where m.manager_id = t.assmanager_id and p.team_id = t.team_id and p.player_id = t.captain_id and t.team_id = '{cb_Team2.SelectedValue}'";
                command = new MySqlCommand(query, connection);
                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dtLable);
                if (dtLable.Rows.Count != 0)
                {
                    label5.Text = dtLable.Rows[0][1].ToString();
                    label7.Text = dtLable.Rows[0][2].ToString();
                }
            }
            team2 = cb_Team2.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtLable = new DataTable();
            query = $"select goal_home, goal_away from `match` where team_home = '{team1}' and team_away = '{team2}'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dtLable);
            if (dtLable.Rows.Count != 0)
            {
                label11.Text = dtLable.Rows[0][0].ToString() + " - " + dtLable.Rows[0][1].ToString();
            }
            dtLable = new DataTable();
            query = $"select home_stadium, capacity from team where team_id = '{team1}'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dtLable);
            if (dtLable.Rows.Count != 0)
            {
                label9.Text = dtLable.Rows[0][0].ToString();
                label13.Text = dtLable.Rows[0][1].ToString();
            }
            dtLable = new DataTable();
            query = $"select match_date from `match` where team_home = '{team1}' and team_away = '{team2}'";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dtLable);
            if (dtLable.Rows.Count != 0)
            {
                label15.Text = dtLable.Rows[0][0].ToString();
            }
            dgvdata = new DataTable();
            query = $"select d.minute, p.player_name, d.type, p.player_name, d.type from player p, `dmatch` d where p.player_id = d.player_id order by 1";
            command = new MySqlCommand(query, connection);
            adapter = new MySqlDataAdapter(command);
            adapter.Fill(dgvdata);
            dataGridView1.DataSource = dgvdata;
        }
    }
}
