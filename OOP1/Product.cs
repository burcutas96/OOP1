using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //snippet: "Hazır kodlar"a snippet denir.
    internal class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }  //kategori id'isi
        public string ProductName { get; set; }  //ürün ismi
        public double UnitPrice { get; set; }  //ürünün birim fiyatı
        public int UnitInStock { get; set; }  //ürünün stok adeti
    }
}
