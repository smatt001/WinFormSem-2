using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TH0402_0706022310037
{
    public partial class Form1 : Form
    {
        List<Team> Teamlist = new List<Team>();
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                string[] Arrayforcountry = { "Japan", "Japan" , "Korea" };
                string[] Arrayforcity = { "Tokyo", "Osaka", "Seoul" };
                string[] Arrayforteam = { "FC Tokyo", "Cerezo", "FC Seoul" };
                Team team = new Team();
                team.teamCountry = Arrayforcountry[i];
                team.teamCity = Arrayforcity[i];
                team.teamName = Arrayforteam[i];
                List<Player> playerlist = new List<Player>();
                for (int j = 0; j < 12; j++)
                {
                    string[] t1 = { "Kazuki Nagasawa", "Diego Oliveira", "Tsuyoshi Watanabe", "Yojiro Takahagi", "Leandro","Takahashi Kento" ,"Kyosuke Tagawa", "Joan Oumari", "Ryoya Ogawa", "Taichi Hara", "Hotaka Nakamura", "Adailton" };
                    string[] t2 = { "Yuto Nagasato", "Kento Hashimoto", "Hirotaka Mita", "Takuya Uchida", "Shuto Abe","Namakura Bajo" ,"Kensuke Nagai", "Yojiro Takahagi", "Tsuyoshi Watanabe", "Leandro", "Joan Oumari", "Taishi Nozawa" };
                    string[] t3 = { "Son Heung-min", "Hwang Hee-chan", "Ki Sung-yueng", "Lee Kang-in", "Kim Min-jae", "Kim Sung Lee","Kwon Chang-hoon", "Lee Jae-sung", "Kim Jin-su", "Hwang Ui-jo", "Park Ji-sung", "Jang Hyun-soo" };
                    Player player = new Player();
                    if (i == 0)
                    {
                        player.playerName = t1[j];
                    }
                    else if (i == 1)
                    {
                        player.playerName = t2[j];
                    }
                    else
                    {
                        player.playerName = t3[j];
                    }
                    string[] ArrayForTeamnomer = { "01", "02", "03", "04", "08", "10", "13", "15", "18", "19", "21", "22" };
                    string[] ArrayForTeamposisi = { "GK", "DF", "DF", "DF", "MF", "MF", "MF", "MF", "MF", "FW", "FW", "FW" };
                    player.playerNum = ArrayForTeamnomer[j];
                    player.playerPos = ArrayForTeamposisi[j];
                    playerlist.Add(player);
                }
                team.Players = playerlist;
                Teamlist.Add(team);
            }

            for (int i = 0; i < Teamlist.Count; i++)
            {
                if (!cb_choose_nation.Items.Contains(Teamlist[i].teamCountry))
                {
                    cb_choose_nation.Items.Add(Teamlist[i].teamCountry);
                }
            }
        }

        private void CBCountryChangeWhenSelected(object sender, EventArgs e)
        {
            cb_choose_team.Items.Clear();
            cb_choose_team.Text = "";
            for (int i = 0; i < Teamlist.Count; i++)
            {
                string country = cb_choose_nation.SelectedItem.ToString();
                if (Teamlist[i].teamCountry == country)
                {
                    cb_choose_team.Items.Add(Teamlist[i].teamName);
                }
            }
        }

        private void CBTeamChangeWhenSelected(object sender, EventArgs e)
        {
            lb_members.Items.Clear();
            for (int i = 0; i < Teamlist.Count; i++)
            {
                string team = cb_choose_team.SelectedItem.ToString();
                if (Teamlist[i].teamName == team)
                {
                    for(int j = 0; j< Teamlist[i].Players.Count; j++)
                    {
                        string nama = Teamlist[i].Players[j].playerName;
                        string nom = Teamlist[i].Players[j].playerNum;
                        string pos = Teamlist[i].Players[j].playerPos;
                        lb_members.Items.Add("("+ nom + ") "+ nama + ","+ pos);
                    }
                    break;
                }
            }
        }

        private void BtnAddTeam(object sender, EventArgs e)
        {
            bool allow = true;
            if (tb_team_name.Text != "" && tb_team_country.Text != "" && tb_team_city.Text != "")
            {
                for(int i = 0; i < Teamlist.Count; i++)
                {
                    if (Teamlist[i].teamName == tb_team_country.Text)
                    {
                        MessageBox.Show("Failed to Create Team, Team name is already there, cannot be the same name");
                        break;
                        allow = true;
                    }
                }
                if (allow)
                {
                    Team team = new Team();
                    team.teamCountry = tb_team_name.Text;
                    team.teamName = tb_team_country.Text;
                    team.teamCity = tb_team_city.Text;
                    List<Player> playerlist = new List<Player>();
                    team.Players = playerlist;
                    Teamlist.Add(team);

                    tb_team_name.Text = "";
                    tb_team_country.Text = "";
                    tb_team_city.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Cannot be blank");
            }

            for (int o = 0; o < Teamlist.Count; o++)
            {
                if (!cb_choose_nation.Items.Contains(Teamlist[o].teamCountry))
                {
                    cb_choose_nation.Items.Add(Teamlist[o].teamCountry);
                }
            }
        }
        private void DeletePlayer(object sender, EventArgs e)
        {
            for (int i = 0; i < Teamlist.Count; i++)
            {
                string team = cb_choose_team.SelectedItem.ToString();
                if (Teamlist[i].teamName == team && Teamlist[i].Players.Count > 11)
                {
                    Teamlist[i].Players.Remove(Teamlist[i].Players[lb_members.SelectedIndex]);
                    break;
                }
                else if (Teamlist[i].Players.Count <= 11)
                {
                    MessageBox.Show("Member cannot be below 11");
                    break;
                }
                
            }

            lb_members.Items.Clear();
            for (int i = 0; i < Teamlist.Count; i++)
            {
                string team = cb_choose_team.SelectedItem.ToString();
                if (Teamlist[i].teamName == team)
                {
                    for (int j = 0; j < Teamlist[i].Players.Count; j++)
                    {
                        string nama = Teamlist[i].Players[j].playerName;
                        string nom = Teamlist[i].Players[j].playerNum;
                        string pos = Teamlist[i].Players[j].playerPos;
                        lb_members.Items.Add("(" + nom + ") " + nama + "," + pos);
                    }
                    break;
                }
            }
        }

        private void BtnAddPlayer(object sender, EventArgs e)
        {
            string[] Posisi = { "GK", "DF", "MF", "FW" };
            string nama = tb_player_name.Text;
            string nom = tb_player_number.Text;
            string pos = Posisi[cb_player_position.SelectedIndex];

            if (nama != "" && nom != "" && cb_player_position.SelectedIndex != -1)
            {
                if (cb_choose_nation.SelectedIndex != -1 && cb_choose_team.SelectedIndex != -1)
                {
                    for (int i = 0; i < Teamlist.Count; i++)
                    {
                        string team = cb_choose_team.SelectedItem.ToString();
                        if (Teamlist[i].teamName == team)
                        {
                            bool cek2 = true;
                            for(int k = 0; k < Teamlist[i].Players.Count; k++)
                            {
                                if (Teamlist[i].Players[k].playerName == nama)
                                {
                                    cek2 = false;
                                } 
                            }
                            if (cek2)
                            {
                                Player player = new Player();
                                player.playerName = nama;
                                player.playerNum = nom;
                                player.playerPos = pos;
                                Teamlist[i].Players.Add(player);
                                lb_members.Items.Add("(" + nom + ") " + nama + "," + pos);
                            }
                            else
                            {
                                MessageBox.Show("Can't add the same player, already added");
                            }
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select a team");
                }
                tb_player_name.Text = "";
                tb_player_number.Text = "";
                cb_player_position.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Cannot be blank");
            }
        }
    }
}