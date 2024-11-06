using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai11_form_the_moi
{
    internal class Product
    {
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public decimal Price { get; set; }
        public string Hinhanh { get; set; }
        public string Motangan { get; set; }
        public string Motachitiet { get; set; }
        public string Loaisanpham { get; set; }

        public Product(string maSP, string tenSP, decimal price, string hinhanh, string motangan, string motachitiet, string loaisanpham)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.Price = price;
            this.Hinhanh = hinhanh;
            this.Motangan = motangan;
            this.Motachitiet = motachitiet;
            this.Loaisanpham = loaisanpham;
        }
    }
}
