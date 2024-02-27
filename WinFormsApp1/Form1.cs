namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int cek;
        int hasil;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cek = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cek = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cek = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cek = 4;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox2.Text))
            {
                label3.Text = "Error Angka 1 kenot bigger than angka2";
            }
            else if (cek == 0)
            {
                label3.Text = "No mode picked";
            }
            else
            {
                if (cek == 1)
                {
                    hasil = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
                    label3.Text = Convert.ToString(hasil);
                }
                else if (cek == 2)
                {
                    hasil = Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text);
                    label3.Text = Convert.ToString(hasil);
                }
                else if (cek == 3)
                {
                    hasil = Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text);
                    label3.Text = Convert.ToString(hasil);
                }
                else if (cek == 4)
                {
                    hasil = Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text);
                    label3.Text = Convert.ToString(hasil);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
