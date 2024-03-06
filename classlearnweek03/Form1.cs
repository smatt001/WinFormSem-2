using System.Data;

namespace classlearnweek03
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID Makanan");
            dt.Columns.Add("Nama Makanan");
            dt.Columns.Add("Harga Makanan");
            dt.Rows.Add("F001", "Kentang GOreng", "15000");
            dt.Rows.Add("F002", "Ayam Goreng", "20000");
            dt.Rows.Add("F003", "Daging Goreng", "25000");
            dt.Rows.Add("F004", "Chicken Katsu", "20000");
            dt.Rows.Add("F005", "Steak", "200000");

            listBox1.DataSource = dt;
            listBox1.ValueMember = "ID Makanan";
            listBox1.DisplayMember = "Nama Makanan";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void pilihbtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedValue.ToString());
            //string haha = listBox1.SelectedIndex.ToString();

            //MessageBox.Show(listBox1.SelectedIndex.ToString());
            int index = listBox1.SelectedIndex;
            DataRow selectedhihi = dt.Rows[index];

            string ID = selectedhihi["ID Makanan"].ToString();
            string pepessasas = selectedhihi["Nama Makanan"].ToString();
            int hargamama = Convert.ToInt32(selectedhihi["Harga Makanan"]);
            MessageBox.Show($"{ID} - {pepessasas} - {hargamama.ToString("C")}");

        }
    }
}
