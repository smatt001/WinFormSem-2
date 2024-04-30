using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH09Sem2_0706022310037
{
    public partial class MainPage : Form
    {
        int counter = 0;
        int price = 0;
        int price2 = 0;
        int price3 = 0;
        int subtotal = 0;
        int total = 0;
        int[] quantity = new int[3];
        DataTable isidgv = new DataTable();
        List<int> listharga = new List<int>();
        OpenFileDialog ofd = new OpenFileDialog();
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            pnl_main.Visible = false;
            pnl_Others.Visible = false;
            isidgv.Columns.Add("Items");
            isidgv.Columns.Add("Quantity");
            isidgv.Columns.Add("Harga");
            isidgv.Columns.Add("Total");
            dgv_Cart.DataSource = isidgv;
            tb_SubTotal.ReadOnly = true;
            tb_Total.ReadOnly = true;
        }

        private void tsm_Tshirt_Click(object sender, EventArgs e)
        {
            price = 120000;
            price2 = 150000;
            price3 = 170000;

            pnl_main.Visible=true;
            lbl_1.Text = "T-Shirt Crocodile";
            lbl_2.Text = "T-Shirt Random";
            lbl_3.Text = "T-Shirt Brang";

            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");

            pb_1.Image = Properties.Resources.Aligator_Tshirt;
            pb_2.Image = Properties.Resources.tshirt_bolo;
            pb_3.Image = Properties.Resources.tshirt_brang;
            btn_1.Click += Btn_1_Click;
            btn_2.Click += Btn_2_Click;
            btn_3.Click += Btn_3_Click;
        }

        private void Btn_1_Click(object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }

        private void Btn_2_Click(object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }

        private void Btn_3_Click(object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }

        private void tsm_Shirt_Click(object sender, EventArgs e)
        {
            price = 100000;
            price2 = 180000;
            price3 = 210000;
            pnl_main.Visible = true;
            lbl_1.Text = "White Shirt";
            lbl_2.Text = "Black Shirt";
            lbl_3.Text = "Red Shirt";
            pb_1.Image = Properties.Resources.White_Shirt;
            pb_2.Image = Properties.Resources.Black_Shirt;
            pb_3.Image = Properties.Resources.Red_Shirt;
            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");
            btn_1.Click += Btn_1_Shirt;
            btn_2.Click += Btn_2_Shirt;
            btn_3.Click += Btn_3_Shirt;
        }
        private void Btn_1_Shirt(object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void Btn_2_Shirt(object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void Btn_3_Shirt(object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void tsm_Pants_Click(object sender, EventArgs e)
        {
            price = 200000;
            price2 = 170000;
            price3 = 275000;
            pnl_main.Visible = true;
            lbl_1.Text = "Cargo Shorts";
            lbl_2.Text = "Jeans Shorts";
            lbl_3.Text = "Short Pants";
            pb_1.Image = Properties.Resources.cargo_shorts;
            pb_2.Image = Properties.Resources.jean_shorts;
            pb_3.Image = Properties.Resources.shortpants;
            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");
            btn_1.Click += btn_1_pants;
            btn_2.Click += btn_2_pants;
            btn_3.Click += btn_3_pants;
        }
        private void btn_1_pants(object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_2_pants(object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_3_pants(object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void tsm_LongPants_Click(object sender, EventArgs e)
        {
            price = 300000;
            price2 = 200000;
            price3 = 500000;
            pnl_main.Visible = true;
            lbl_1.Text = "Cargo Pants";
            lbl_2.Text = "Joggers";
            lbl_3.Text = "Slim Jeans";
            pb_1.Image = Properties.Resources.Cargo_Pants;
            pb_2.Image = Properties.Resources.joggers;
            pb_3.Image = Properties.Resources.jeans_slim_fit;
            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");
            btn_1.Click += btn_1_longpants;
            btn_2.Click += btn_2_longpants;
            btn_3.Click += btn_3_longpants;
        }
        private void btn_1_longpants(object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_2_longpants(object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_3_longpants(object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void tsm_Shoes_Click(object sender, EventArgs e)
        {
            price = 5400000;
            price2 = 3700000;
            price3 = 4000000;
            pnl_main.Visible = true;
            lbl_1.Text = "Boots";
            lbl_2.Text = "Formal Shoes";
            lbl_3.Text = "Sports Shoes";
            pb_1.Image = Properties.Resources.boots;
            pb_2.Image = Properties.Resources.pantofel;
            pb_3.Image = Properties.Resources.sneakers;
            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");
            btn_1.Click += btn_1_shoes;
            btn_2.Click += btn_2_shoes;
            btn_3.Click += btn_3_shoes;
        }
        private void btn_1_shoes(object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_2_shoes(Object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_3_shoes(Object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void tsm_Jewelleries_Click(object sender, EventArgs e)
        {
            price = 5000000;
            price2 = 10000000;
            price3 = 7500000;
            pnl_main.Visible = true;
            lbl_1.Text = "White Gold";
            lbl_2.Text = "Platinum Ring";
            lbl_3.Text = "Gold Bracelette";
            pb_1.Image = Properties.Resources.WhiteGold_Tanzanite;
            pb_2.Image = Properties.Resources.PLATINUM_RING;
            pb_3.Image = Properties.Resources.goLD_BRACELETTE;
            lbl_harga1.Text = price.ToString("C");
            lbl_harga2.Text = price2.ToString("C");
            lbl_harga3.Text = price3.ToString("C");
            btn_1.Click += btn_1_longpants;
            btn_2.Click += btn_2_longpants;
            btn_3.Click += btn_3_longpants;
        }
        private void btn_1_jewel(Object sender, EventArgs e)
        {
            quantity[0]++;
            isidgv.Rows.Add(lbl_1.Text, quantity[0], price, quantity[0] * price);
            subtotal += price;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_2_jewel(Object sender, EventArgs e)
        {
            quantity[1]++;
            isidgv.Rows.Add(lbl_2.Text, quantity[1], price, quantity[1] * price);
            subtotal += price2;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_3_jewel(Object sender, EventArgs e)
        {
            quantity[2]++;
            isidgv.Rows.Add(lbl_3.Text, quantity[2], price, quantity[2] * price);
            subtotal += price3;
            total = subtotal / 10 + subtotal;
            tb_SubTotal.Text = subtotal.ToString();
            tb_Total.Text = total.ToString();
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Cart.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_Cart.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgv_Cart.Rows.Remove(row);
                        tb_SubTotal.Text = subtotal.ToString();
                        tb_Total.Text = total.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void tsm_Others_Click(object sender, EventArgs e)
        {
            pnl_main.Visible = false;
            pnl_Others.Location =new Point(13,37);
            pnl_Others.Visible = true;

        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Pictures (*.png)|*.png|Pictures (*.jpg)|*.jpg";
            ofd.InitialDirectory = "C:\\Users\\ASUS\\Pictures";

            ofd.ShowDialog();
            pb_Others.Image = new Bitmap(ofd.FileName);
            pb_Others.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void tb_itemPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btn_AddOthers_Click(object sender, EventArgs e)
        {
            counter++;
            int harga = Convert.ToInt32(tb_itemPrice.Text);
            isidgv.Rows.Add(tb_ItemName.Text,counter , harga, harga*counter);
        }
    }
}
