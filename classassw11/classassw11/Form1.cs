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

namespace classassw11
{// sean matthew- 0706022310037
    public partial class Form1 : Form
    {
        DataTable dtTeam = new DataTable();
        DataTable dtMatch = new DataTable();
        DataTable dtMatchdgv = new DataTable();
        MySqlConnection sqlconnect;
        MySqlCommand sqlcmd;
        MySqlDataAdapter sqladapter;
        string home = "";
        string away = "";

        string[] temp = new string[2];
        string sqlquery = "";
        string query = "";
        public Form1()
        {
            InitializeComponent();
            tb_matchid.Enabled = false;
            tb_matchid.Text = "";
            dtMatchdgv.Columns.Add("minute");
            dtMatchdgv.Columns.Add("team_name");
            dtMatchdgv.Columns.Add("player_name");
            dtMatchdgv.Columns.Add("type");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Server.Text == "localhost" && (tb_User.Text == "root" || tb_User.Text == "student") && tb_Password.Text == "isbmantap" && tb_Database.Text == "premier_league")
                {
                    MessageBox.Show("masuk");
                    sqlconnect = new MySqlConnection("Server=localhost;uid=root;password=isbmantap;database=premier_league");
                    sqlconnect.Open();
                    sqlconnect.Close();
                    query = "select * from team;";
                    sqlcmd = new MySqlCommand(query, sqlconnect);
                    sqladapter = new MySqlDataAdapter(sqlcmd);
                    sqladapter.Fill(dtTeam);
                    MessageBox.Show("before cb");

                    for (int i = 0; i < dtTeam.Rows.Count; i++)
                    {
                        cb_TeamHome.Items.Add(dtTeam.Rows[i][1]);
                        cb_TeamAway.Items.Add(dtTeam.Rows[i][1]);
                    }
                    tb_Database.Clear();
                    tb_User.Clear();
                    tb_Password.Clear();
                    tb_Database.Clear();
                    
                }
                else
                {
                    MessageBox.Show("rusak");
                }
            }
            catch
            {
                MessageBox.Show("One or more error occured");
            }
        }

        private void cb_TeamHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cb_TeamAway.Text != "")
            {
                MessageBox.Show("uhd masuk");
                temp[0] = cb_TeamHome.Text;
                temp[1] = cb_TeamAway.Text;
                foreach (DataRow row in dtTeam.Rows)
                {
                    if (row["team_name"].ToString() == temp[0])
                    {
                        home = row["team_id"].ToString();
                        break;
                    }

                }
                foreach (DataRow row in dtTeam.Rows)
                {
                    if (row["team_name"].ToString() == temp[1])
                    {
                        away = row["team_id"].ToString();
                        break;
                    }
                }
                MessageBox.Show("masuk 2");
                sqlconnect.Open();
                sqlquery = "select d.match_id,d.minute, t.team_name, p.player_name, d.type from dmatch d, team t, player p, `match` m " +
                    "where d.team_id = t.team_id and d.player_id = p.player_id and m.match_id = d.match_id and m.team_away= " + "'"+home+"'" + " and m.team_home = " + "'" + away +"';";
                
                sqlcmd = new MySqlCommand(sqlquery, sqlconnect);
                sqladapter = new MySqlDataAdapter(sqlcmd);
                sqladapter.Fill(dtMatch);
                tb_matchid.Text = dtMatch.Rows[0][0].ToString();

                foreach (DataRow row in dtMatch.Rows)
                {
                    dtMatchdgv.Rows.Add(row["minute"], row["team_name"], row["player_name"], row["type"]);
                }
                dgv_1.DataSource = dtMatchdgv;
                sqlconnect.Close();
            }
        }

        private void cb_TeamAway_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_TeamHome.Text != "")
            {
                MessageBox.Show("uhd masuk");
                temp[0] = cb_TeamHome.Text;
                temp[1] = cb_TeamAway.Text;
                foreach(DataRow row in dtTeam.Rows)
                {
                    if (row["team_name"].ToString() == temp[0])
                    {
                        home = row["team_id"].ToString();
                        break;
                    }
                    
                }
                foreach (DataRow row in dtTeam.Rows)
                {
                    if (row["team_name"].ToString() == temp[1])
                    {
                        away = row["team_id"].ToString();
                        break;
                    }
                }
                sqlconnect.Open();
                MessageBox.Show("masuk 2");
                sqlquery = "select d.match_id,d.minute, t.team_name, p.player_name, d.type from dmatch d, team t, player p, `match` m " +
                    "where d.team_id = t.team_id and d.player_id = p.player_id and m.match_id = d.match_id and m.team_away= " + "'" + home + "'" + " and m.team_home = " + "'" + away + "';";

                sqlcmd = new MySqlCommand(sqlquery, sqlconnect);
                sqladapter = new MySqlDataAdapter(sqlcmd);
                sqladapter.Fill(dtMatch);
                tb_matchid.Text = dtMatch.Rows[0][0].ToString();

                foreach (DataRow row in dtMatch.Rows)
                {
                    dtMatchdgv.Rows.Add(row["minute"], row["team_name"], row["player_name"], row["type"]);
                }

                dgv_1.DataSource = dtMatchdgv;
                sqlconnect.Close();
            }
        }
    }
}
