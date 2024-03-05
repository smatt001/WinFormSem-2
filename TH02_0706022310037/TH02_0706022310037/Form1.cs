using System;

namespace TH02_0706022310037
{
    public partial class Form1 : Form
    {
        List<string> letter = new List<string>();
        string[] Input = new string[5];
        
        public Form1()
        {
            InitializeComponent();
        }

        private void inpt1_Click(object sender, EventArgs e)
        {

        }
        private void Play_Click(object sender, EventArgs e)
        {
            bool cek = false;
            if (textBox1.Text.Length == 5 || textBox2.Text.Length == 5 || textBox3.Text.Length == 5 || textBox4.Text.Length == 5 || textBox5.Text.Length == 5)
            {
                int nomer = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0;i < 5; i++)
                    {
                        if (Input[i].ToString().Any(char.IsDigit))
                        {
                            nomer++;
                        }
                    }
                }
                if (nomer == 5)
                {
                    MessageBox.Show("Input must not contain Numbers");
                }
                for (int i = 0; i < 5; i++)
                {
                    Input[i] = Input[i].ToUpper();
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }
                        if (Input[i] == Input[j])
                        {
                            cek = true;
                        }
                    }
                }
                if (cek == true)
                {
                    MessageBox.Show("Error, Cant be the same Words");
                }
                else
                {
                    Form2 playpage = new Form2(Input);
                    playpage.ShowDialog();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Input Cant be less or more than 5 letters");
            }
            
            
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Input[0] = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Input[1] = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Input[2] = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Input[3] = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Input[4] = textBox5.Text;
        }
        
        

    }
}