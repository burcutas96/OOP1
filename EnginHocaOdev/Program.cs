
using EnginHocaOdev;

Product product1 = new Product();

product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Defter";
product1.UnitPrice = 10;
product1.UnitInStock = 7;

Product product2 = new Product();
product2.Id = 2;
product2.CategoryId = 6;
product2.ProductName = "Telefon";
product2.UnitPrice = 7800;
product2.UnitInStock = 3;

Product product3 = new Product();
product3.Id = 3;
product3.CategoryId = 4;
product3.ProductName = "Halı";
product3.UnitPrice = 600;
product3.UnitInStock = 4;

Product product4 = new Product();
product4.Id = 4;
product4.CategoryId = 9;
product4.ProductName = "Tereyağı";
product4.UnitPrice = 25;
product4.UnitInStock = 5;

Product[] products = new Product[]
{
    product1, product2, product3, product4
};


Console.WriteLine("Dizinin for döngüsü ile listelenmesi");
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("Ürünümüzün adı: " + products[i].ProductName);
    Console.WriteLine("Ürünümüzün fiyatı: " + products[i].UnitPrice);
    Console.WriteLine("Ürünümüzün kalan stok adeti: " + products[i].UnitInStock);
}

Console.WriteLine("============================");
Console.WriteLine("Dizinin foreach döngüsü ile listelenmesi");
foreach (Product product in products)
{
    Console.WriteLine("Ürünümüzün adı: " + product.ProductName);
    Console.WriteLine("Ürünümüzün fiyatı: " + product.UnitPrice);
    Console.WriteLine("Ürünümüzün kalan stok adeti: " + product.UnitInStock);
}

Console.WriteLine("============================");
Console.WriteLine("Dizinin while döngüsü ile listelenmesi");
int j = 0;
while (j < products.Length)
{
    Console.WriteLine("Ürünümüzün adı: " + products[j].ProductName);
    Console.WriteLine("Ürünümüzün fiyatı: " + products[j].UnitPrice);
    Console.WriteLine("Ürünümüzün kalan stok adeti: " + products[j].UnitInStock);
    j++;
}


