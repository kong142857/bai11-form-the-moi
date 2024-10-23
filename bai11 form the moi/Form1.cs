using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace bai11_form_the_moi
{
    public partial class Form1 : Form
    {
        private BindingList<Product> productList = new BindingList<Product>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = productList;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
        }

        private void btthem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) ||
                string.IsNullOrEmpty(textBox2.Text) ||
                string.IsNullOrEmpty(textBox3.Text) ||
                string.IsNullOrEmpty(textBox4.Text) ||
                string.IsNullOrEmpty(textBox5.Text) ||
                string.IsNullOrEmpty(textBox6.Text) ||
                string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm!");
                return;
            }

            // Chuyển đổi giá trị từ TextBox thành decimal
            if (!decimal.TryParse(textBox3.Text, out decimal price))
            {
                MessageBox.Show("Giá sản phẩm phải là số hợp lệ!");
                return;
            }

            // Tạo sản phẩm mới từ thông tin nhập vào
            Product newProduct = new Product()
            {
                MaSP = textBox1.Text,
                TenSP = textBox2.Text,
                Price = price,
                Hinhanh = textBox4.Text,
                Motangan = textBox5.Text,
                Motachitiet = textBox6.Text
            };

            // Thêm sản phẩm mới vào BindingList
            productList.Add(newProduct);

            // Làm mới DataGridView
            dataGridView1.Refresh();

            // Làm sạch các ô TextBox sau khi thêm
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy sản phẩm đang được chọn từ DataGridView
                var selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;

                // Cập nhật thông tin sản phẩm từ các ô TextBox
                selectedProduct.MaSP = textBox1.Text;
                selectedProduct.TenSP = textBox2.Text;
                selectedProduct.Price = decimal.Parse(textBox3.Text);
                selectedProduct.Hinhanh = textBox4.Text;
                selectedProduct.Motangan = textBox5.Text;
                selectedProduct.Motachitiet =textBox6.Text;

                // Làm mới DataGridView để hiển thị thông tin mới
                dataGridView1.Refresh();
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                // Lấy sản phẩm đang được chọn từ DataGridView
                var selectedProduct = (Product)dataGridView1.CurrentRow.DataBoundItem;

                // Xóa sản phẩm khỏi BindingList
                productList.Remove(selectedProduct);

                // Làm mới DataGridView
                dataGridView1.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy sản phẩm đang được chọn và hiển thị thông tin lên các ô TextBox
                var selectedProduct = (Product)dataGridView1.Rows[e.RowIndex].DataBoundItem;

                textBox1.Text = selectedProduct.MaSP;
                textBox2.Text = selectedProduct.TenSP;
                textBox3.Text = selectedProduct.Price.ToString();
                textBox4.Text = selectedProduct.Hinhanh;
                textBox5.Text = selectedProduct.Motangan;
                textBox6.Text = selectedProduct.Motachitiet;
            }
        }
    }
    public class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Price { get; set; }
        public string Hinhanh { get; set; }
        public string Motangan { get; set; }
        public string Motachitiet { get; set; }

    }
}
