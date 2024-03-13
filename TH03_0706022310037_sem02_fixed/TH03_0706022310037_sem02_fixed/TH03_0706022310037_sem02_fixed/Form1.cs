namespace TH03_0706022310037_sem02_fixed
{
    public partial class Form1 : Form
    {
        List<string> username = new List<string>();
        List<string> password = new List<string>();
        List<long> balance = new List<long>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            regispnl.Visible = false;
            depositpnl.Visible = false;
            withdrawpnl.Visible = false;
            balancepnl.Visible = false;
            //balancedisp.Text = balance.ToString();
        }

        private void logintopnl_Click(object sender, EventArgs e)
        {
            bool check = false;
            int index = -1;
            foreach (string s in username)
            {
                index++;
                if (s == username[index])
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                MessageBox.Show("No Account Found");
            }
            else if (password[index] == passbox.Text)
            {
                MessageBox.Show("Logged in Successfully");
                balancepnl.Visible = true;
                balancedisp.Text = "Rp." + balance[index];
            }
        }

        private void registopnl_Click(object sender, EventArgs e)
        {
            regispnl.Visible = true;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            bool cek = false;
            foreach (string a in username)
            {
                if (a == userbox.Text)
                {
                    cek = true;
                }
            }
            if (cek)
            {
                MessageBox.Show("Account Existed");
            }
            else
            {
                username.Add(userbox.Text);
                password.Add(passbox.Text);
                balance.Add(0);
                regispnl.Visible = false;
                MessageBox.Show("Register Successful");
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            regispnl.Visible = false;
            depositpnl.Visible = false;
            withdrawpnl.Visible = false;
            balancepnl.Visible = false;
            userbox.Text = "";
            passbox.Text = "";
            MessageBox.Show("Logged Out");
        }

        private void deposittopnl_Click(object sender, EventArgs e)
        {
            depositpnl.Visible = true;
        }

        private void withdrawtopnl_Click(object sender, EventArgs e)
        {
            withdrawpnl.Visible = true;
        }

        private void depositbtn_Click(object sender, EventArgs e)
        {
            long tampung = Convert.ToInt64(depositbox.Text);
            if (tampung < 0)
            {
                MessageBox.Show("Cant deposit lower than 0");
            }
            else
            {
                balance[index] = balance[index] + tampung;
                MessageBox.Show("Successfully Deposited");
            }
            balancedisp.Text = balance[index].ToString();
            depositbox.Text = "";
            depositpnl.Visible = false;
        }

        private void withdrawbtn_Click(object sender, EventArgs e)
        {
            long tampung = Convert.ToInt64(withdrawbox.Text);
            if (tampung < 0 || tampung > balance[index])
            {
                MessageBox.Show("Cant withdraw lower than 0");
            }
            else
            {
                balance[index] = balance[index] - tampung;
                MessageBox.Show("Successfully Withdrew");
            }
            balancedisp.Text = balance[index].ToString();
            withdrawbox.Text = "";
            withdrawpnl.Visible = false;
        }
    }
}