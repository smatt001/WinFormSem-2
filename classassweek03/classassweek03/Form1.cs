namespace classassweek03
{
    public partial class Form1 : Form
    {
        string gender = "";
        string hobbies = "";
        public Form1()
        {
            InitializeComponent();

            if (rb_male.Checked)
            {
                gender = "Male";
            }
            else if (rb_female.Checked)
            {
                gender = "Female";
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (tb_name.Text.ToString().Any(char.IsDigit) == true)
            {
                MessageBox.Show("Name must not contain Number");
            }
            else if (tb_Age.Text.ToString().Any(char.IsLetter) == true)
            {
                MessageBox.Show("Age must not contain Letters");
            }
            else if (tb_other.Text.ToString().Any(char.IsDigit) == true)
            {
                MessageBox.Show("Hobbies must not contain Numbers");
            }
            else
            {
                if (rb_Red.Checked)
                {
                    this.BackColor = System.Drawing.Color.Red;
                }
                else if (rb_green.Checked)
                {
                    this.BackColor = System.Drawing.Color.LightGreen;
                }
                else if (rb_blue.Checked)
                {
                    this.BackColor = System.Drawing.Color.LightBlue;
                }

                if (cb_watching.Checked)
                {
                    hobbies += "Watching TV, ";
                }
                if (cb_reading.Checked)
                {
                    hobbies += "Reading, ";
                }
                if (cb_playsport.Checked)
                {
                    hobbies += "Playing Sports, ";
                }
                if (cb_others.Checked)
                {
                    hobbies += tb_other.Text;
                }

                MessageBox.Show("Name :" + tb_name.Text + " Age :" + tb_Age.Text + "Gender :" + gender + "   " + "Hobbies :" + hobbies);
            }
        }
            
             

    private void btn_clear_Click(object sender, EventArgs e)
        {
            cb_others.Checked = false;
            cb_playsport.Checked = false;
            cb_watching.Checked = false;
            cb_reading.Checked = false;
            rb_female.Checked = false;
            rb_blue.Checked = false;
            rb_Red.Checked = false;
            rb_green.Checked = false;
            rb_male.Checked = false;
            tb_name.Text = "";
            tb_Age.Text = "";
            tb_other.Text = "";
        }
    }
}