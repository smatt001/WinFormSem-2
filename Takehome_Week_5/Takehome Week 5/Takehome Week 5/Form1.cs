using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takehome_Week_5
{
    public partial class Form1 : Form
    {
        DataTable dtProdukSimpan = new DataTable();
        DataTable dtProdukTampil = new DataTable();
        DataTable dtCategory = new DataTable();
        string[] selectselectseletsleecselelclclslw = { "", "" };

        public Form1()
        {
            InitializeComponent();

            dtProdukSimpan.Columns.Add("ID Product");
            dtProdukSimpan.Columns.Add("Nama Product");
            dtProdukSimpan.Columns.Add("Harga");
            dtProdukSimpan.Columns.Add("Stock");
            dtProdukSimpan.Columns.Add("ID Category");

            dtProdukTampil.Columns.Add("ID Product");
            dtProdukTampil.Columns.Add("Nama Product");
            dtProdukTampil.Columns.Add("Harga");
            dtProdukTampil.Columns.Add("Stock");
            dtProdukTampil.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category");
            dtCategory.Columns.Add("Nama Category");

            dtProdukSimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProdukSimpan.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            dtProdukSimpan.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            dtProdukSimpan.Rows.Add("R001", "Rok mini", "82000", "26", "C3");
            dtProdukSimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProdukSimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProdukSimpan.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            dtProdukSimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            dgv_1.ReadOnly = true;
            dgv_2.ReadOnly = true;

            dgv_1.DataSource = dtProdukTampil;
            dgv_2.DataSource = dtCategory;
            dgv_1.AllowUserToAddRows = false;
            dgv_2.AllowUserToAddRows = false;

            dgv_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_1.MultiSelect = false;
            dgv_1.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);

            dgv_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_2.MultiSelect = false;
            dgv_2.RowPrePaint += new DataGridViewRowPrePaintEventHandler(dgv_RowPrePaint);

            no();
            yes();
        }
        private void no()
        {
            CBT_2.Items.Clear();
            CBT_1.Items.Clear();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                CBT_2.Items.Add(dtCategory.Rows[i][1].ToString());
                CBT_1.Items.Add(dtCategory.Rows[i][1].ToString());
            }
        }

        private void yes()
        {
            dtProdukTampil.Rows.Clear();
            for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
            {
                string id = dtProdukSimpan.Rows[j][0].ToString();
                string nama = dtProdukSimpan.Rows[j][1].ToString();
                string category = dtProdukSimpan.Rows[j][4].ToString();
                string harga = dtProdukSimpan.Rows[j][2].ToString();
                string stock = dtProdukSimpan.Rows[j][3].ToString();
                dtProdukTampil.Rows.Add(id, nama, harga, stock, category);
            }
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            e.PaintParts &= ~DataGridViewPaintParts.Focus;
        }



        private void pnl_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lbl_stok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (pnl_harga.Text != "" && pnl_name.Text != "" && lbl_stok.Text != "" && CBT_1.SelectedIndex != -1)
            {
                string id = pnl_name.Text.ToUpper().Substring(0, 1);
                int idcounter = 0;
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString().Contains(id))
                    {
                        string idn = dtProdukSimpan.Rows[i][0].ToString();
                        idcounter = Convert.ToInt32(idn.Substring(1, idn.Length - 1));
                    }
                }
                idcounter++;
                if (idcounter < 10)
                {
                    id = id + "00" + idcounter.ToString();
                }
                else if (idcounter < 100)
                {
                    id = id + "0" + idcounter.ToString();
                }
                else if (idcounter < 1000)
                {
                    id = id + idcounter.ToString();
                }
                string nama = pnl_name.Text;
                string category = dtCategory.Rows[CBT_1.SelectedIndex][0].ToString();
                string harga = pnl_harga.Text;
                string stock = lbl_stok.Text;
                dtProdukSimpan.Rows.Add(id, nama, harga, stock, category);
                yes();
                no();
                selectselectseletsleecselelclclslw[0] = "";
                CBT_1.SelectedIndex = -1;
                CBT_1.Text = "";
                pnl_harga.Text = "";
                pnl_name.Text = "";
                lbl_stok.Text = "";
                
            }
            else
            {
                MessageBox.Show("Silakan isi semua dulu");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (pnl_harga.Text != "" && pnl_name.Text != "" && lbl_stok.Text != "" && CBT_1.SelectedIndex != -1 && selectselectseletsleecselelclclslw[0] != "")
            {
                string nama = pnl_name.Text;
                string category = dtCategory.Rows[CBT_1.SelectedIndex][0].ToString();
                string harga = pnl_harga.Text;
                string stock = lbl_stok.Text;
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString() == selectselectseletsleecselelclclslw[0])
                    {
                        dtProdukSimpan.Rows[i][1] = nama;
                        dtProdukSimpan.Rows[i][2] = harga;
                        dtProdukSimpan.Rows[i][3] = stock;
                        dtProdukSimpan.Rows[i][4] = category;
                    }
                }
                if (stock == "0")
                {
                    for (int j = 0; j < dtProdukSimpan.Rows.Count; j++)
                    {
                        if (dtProdukSimpan.Rows[j][0].ToString() == selectselectseletsleecselelclclslw[0])
                        {
                            dtProdukSimpan.Rows[j].Delete();
                        }
                    }
                    pnl_harga.Text = "";
                    pnl_name.Text = "";
                    lbl_stok.Text = "";
                    CBT_1.SelectedIndex = -1;
                    CBT_1.Text = "";
                    yes();
                    no();
                    selectselectseletsleecselelclclslw[0] = "";
                }
                pnl_harga.Text = "";
                pnl_name.Text = "";
                lbl_stok.Text = "";
                CBT_1.SelectedIndex = -1;
                CBT_1.Text = "";
                yes();
                no();
                selectselectseletsleecselelclclslw[0] = "";

            }
            else
            {
                MessageBox.Show("Silakan Pilih");
            }
        }

        private void rem_whos_rem_Click(object sender, EventArgs e)
        {
            if (pnl_harga.Text != "" && pnl_name.Text != "" && lbl_stok.Text != "" && CBT_1.SelectedIndex != -1 && selectselectseletsleecselelclclslw[0] != "")
            {
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][0].ToString() == selectselectseletsleecselelclclslw[0])
                    {
                        dtProdukSimpan.Rows[i].Delete();
                    }
                }
                yes();
                no();
                selectselectseletsleecselelclclslw[0] = "";
            }
            else
            {
                MessageBox.Show("Please select an item first");
            }
        }

        private void catadd_Click(object sender, EventArgs e)
        {
            if (lbl_name.Text != "")
            {
                int count_check = 0;
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][1].ToString() == lbl_name.Text)
                    {
                        count_check++;
                        break;
                    }
                }
                if (count_check == 0)
                {
                    string id = dtCategory.Rows[dtCategory.Rows.Count - 1][0].ToString();
                    id = id.Substring(1, id.Length - 1);
                    dtCategory.Rows.Add("C" + (Convert.ToInt32(id) + 1).ToString(), lbl_name.Text);
                    yes();
                    no();
                    lbl_name.Text = "";
                    selectselectseletsleecselelclclslw[1] = "";
                }
                else
                {
                    MessageBox.Show("Category sudah ada");
                }
            }
            else
            {
                MessageBox.Show("Silakan namain dulu");
            }
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            if (selectselectseletsleecselelclclslw[1] != "")
            {
                for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
                {
                    if (dtProdukSimpan.Rows[i][4].ToString() == selectselectseletsleecselelclclslw[1])
                    {
                        dtProdukSimpan.Rows[i].Delete();
                        i = -1;
                    }
                }
                for (int i = 0; i < dtCategory.Rows.Count; i++)
                {
                    if (dtCategory.Rows[i][0].ToString() == selectselectseletsleecselelclclslw[1])
                    {
                        dtCategory.Rows[i].Delete();
                        break;
                    }
                }
                yes();
                no();
                selectselectseletsleecselelclclslw[0] = "";
            }
            else
            {
                MessageBox.Show("Klik Item Dulu");
            }
        }

        private void dgv_1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectselectseletsleecselelclclslw[0] = dgv_1.Rows[dgv_1.CurrentCell.RowIndex].Cells[0].Value.ToString();
            for (int i = 0; i < dtProdukSimpan.Rows.Count; i++)
            {
                if (dtProdukSimpan.Rows[i][0].ToString() == selectselectseletsleecselelclclslw[0])
                {
                    pnl_name.Text = dtProdukSimpan.Rows[i][1].ToString();
                    pnl_harga.Text = dtProdukSimpan.Rows[i][2].ToString();
                    lbl_stok.Text = dtProdukSimpan.Rows[i][3].ToString();

                    string idcat = dtProdukSimpan.Rows[i][4].ToString();
                    for (int j = 0; j < dtCategory.Rows.Count; j++)
                    {
                        if (idcat == dtCategory.Rows[j][0].ToString())
                        {
                            CBT_1.SelectedIndex = j;
                        }
                    }
                }
            }
        }

        private void dgv_2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectselectseletsleecselelclclslw[1] = dgv_2.Rows[dgv_2.CurrentCell.RowIndex].Cells[0].Value.ToString();
            for (int i = 0; i < dtCategory.Rows.Count; i++)
            {
                if (dtCategory.Rows[i][0].ToString() == selectselectseletsleecselelclclslw[1])
                {
                    lbl_name.Text = dtCategory.Rows[i][1].ToString();
                }
            }
        }

        private void btn_btn_btn_Click(object sender, EventArgs e)
        {
            CBT_2.Enabled = false;
            yes();
        }

        private void btn_btn_btn_btn_Click(object sender, EventArgs e)
        {
            CBT_2.Enabled = true;
        }
    }
}
