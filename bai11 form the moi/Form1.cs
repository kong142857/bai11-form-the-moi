using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai11_form_the_moi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        KetNoi kn = new KetNoi();

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            getLoaiSP();
            getData();
        }

        public void getLoaiSP()
        {
            string query = "select * from LoaiSanPham";
            DataSet ds = kn.LayDuLieu(query);
            cmbLoaiSP.DataSource = ds.Tables[0];
            cmbLoaiSP.DisplayMember = "Ten";
            cmbLoaiSP.ValueMember = "MaLoaiSP";

        }

        public void getData()
        {
            string query = "select * from SanPham";
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btthem_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "insert into SanPham VALUES('{0}', N'{1}', {2}, N'{3}', N'{4}', N'{5}', '{6}')",
                txtMaSP.Text,
                txtTen.Text,
                txtDonGia.Text,
                txtHinhAnh.Text,
                txtMoTaNgan.Text,
                txtMoTaChiTiet.Text,
                cmbLoaiSP.SelectedValue
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Thêm mới thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại!");
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "delete from SanPham where MaSP = '{0}'",
                txtMaSP.Text
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Xóa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                txtMaSP.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                txtMaSP.Text = dataGridView1.Rows[r].Cells["MaSP"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[r].Cells["Ten"].Value.ToString();
                txtDonGia.Text = dataGridView1.Rows[r].Cells["DonGia"].Value.ToString();
                txtHinhAnh.Text = dataGridView1.Rows[r].Cells["HinhAnh"].Value.ToString();
                txtMoTaNgan.Text = dataGridView1.Rows[r].Cells["MoTaNgan"].Value.ToString();
                txtMoTaChiTiet.Text = dataGridView1.Rows[r].Cells["MoTaChiTiet"].Value.ToString();
                cmbLoaiSP.SelectedValue = dataGridView1.Rows[r].Cells["MaLoaiSP"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "update SanPham set Ten = N'{1}', DonGia = {2}, HinhAnh = N'{3}', MoTaNgan = N'{4}', MoTaChiTiet = N'{5}', MaLoaiSP = '{6}' where MaSP = '{0}'",
                txtMaSP.Text,
                txtTen.Text,
                txtDonGia.Text,
                txtHinhAnh.Text,
                txtMoTaNgan.Text,
                txtMoTaChiTiet.Text,
                cmbLoaiSP.SelectedValue
            );
            if (kn.ThucThi(query) == true)
            {
                MessageBox.Show("Sửa thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string query = string.Format(
                "select SanPham.* from SanPham inner join LoaiSanPham on SanPham.MaLoaiSP = LoaiSanPham.MaLoaiSP where LoaiSanPham.Ten like N'%{0}%'",
                txtTimKiem.Text
            );
            DataSet ds = kn.LayDuLieu(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearText();
            getData();
        }

        public void clearText()
        {
            txtMaSP.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSP.Text = "";
            txtTen.Text = "";
            txtTimKiem.Text = "";
            txtDonGia.Text = "";
            txtHinhAnh.Text = "";
            txtMoTaNgan.Text = "";
            txtMoTaChiTiet.Text = "";
            //txtLoaiSP.Text = "";
        }
    }
}

