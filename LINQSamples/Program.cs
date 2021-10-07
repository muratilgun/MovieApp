using LINQSamples.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LINQSamples
{
    class ProductModel
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                #region ESKİ
                //var products = db.Products.ToList();
                //var products = db.Products.Select(p => p.ProductName).ToList();
                //var products = db.Products.Select(p => new { p.ProductName,p.UnitPrice }).ToList();
                //var products = db.Products.Select(p => new ProductModel 
                //{
                //    Name = p.ProductName,
                //    Price = p.UnitPrice
                //}).ToList();
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p.Name + " " +p.Price);
                //}
                //var product = db.Products.First();
                //var product = db.Products.Select(p=> new { p.ProductName, p.UnitPrice}).FirstOrDefault();
                //Console.WriteLine(product.ProductName + ' ' + product.UnitPrice); 
                #endregion
                #region ESKİ2
                //var products = db.Products.Where(p => p.UnitPrice > 18).ToList();
                //var products = db.Products
                //    .Select(p => new { p.ProductName, p.UnitPrice })
                //    .Where(p => p.UnitPrice > 18).ToList();
                //var products = db.Products
                //       .Where(p => p.UnitPrice > 18 && p.UnitPrice < 30).ToList();

                //var products = db.Products.Where(p => p.CategoryId>= 1 && p.CategoryId<=5).ToList();
                //var products = db.Products.Where(p => p.CategoryId== 1 || p.CategoryId==5).ToList();
                //var products = db.Products.Where(p => p.CategoryId==1)
                //    .Select(p => new { p.ProductName, p.UnitPrice})
                //    .ToList();
                //var products = db.Products.Where(i => i.ProductName == "Chai").ToList();
                //var products = db.Products.Where(i => i.ProductName.Contains("Ch")).ToList();
                //var products = db.Products.Where(i => i.ProductName.Contains("Ch")).ToList();
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p.ProductName + " " + p.UnitPrice);
                //} 
                //var products = db.Products.Skip(15).Take(5).ToList();
                //foreach (var p in products)
                //{
                //    Console.WriteLine(p.ProductName + " " + p.ProductId);
                //}
                #endregion
                #region ESKİ3
                //var result = db.Products.Count();
                //var result = db.Products.Count(i => i.UnitPrice > 10 && i.UnitPrice < 30);
                //var result = db.Products.Count(i => !i.Discontinued);
                //var result = db.Products.Min(p => p.UnitPrice);
                //var result = db.Products.Where(p => p.CategoryId == 2).Max(p => p.UnitPrice);
                //var result = db.Products.Where(p => !p.Discontinued ).Average(p => p.UnitPrice);
                //var result = db.Products.Where(p => !p.Discontinued ).Sum(p => p.UnitPrice);


                //var result = db.Products.OrderBy(o=> o.UnitPrice).ToList();
                //var result = db.Products.OrderByDescending(o=> o.UnitPrice).ToList();
                //var result = db.Products.OrderByDescending(o=> o.UnitPrice).FirstOrDefault();
                //var result = db.Products.OrderByDescending(o=> o.UnitPrice).LastOrDefault();

                //Console.WriteLine(result.ProductName + " " + result.UnitPrice);

                //foreach (var item in result)
                //{
                //    Console.WriteLine(item.ProductName + ' ' + item.UnitPrice);

                //}

                #endregion
                #region ESKi4
                //var p1 = new Product()
                //{
                //    ProductName = "yeni 1 ürün"
                //};
                //db.Products.Add(p1);
                //db.SaveChanges();

                //Console.WriteLine("Veri eklendi.");
                //Console.WriteLine(p1.ProductId);
                //var category = db.Categories.Where(i => i.CategoryName == "Beverages").FirstOrDefault();
                //var p1 = new Product() {ProductName = "yeni 2 ürün", CategoryId = 1};
                //var p2 = new Product() {ProductName = "yeni 3 ürün", Category = category };
                //var p3 = new Product() {ProductName = "yeni 4 ürün", Category = new Category() {CategoryName = "yeni kategori" } };

                //db.Products.AddRange(p1,p2);
                //db.SaveChanges();

                //Console.WriteLine("Veriler eklendi.");
                //Console.WriteLine("Yeni 2 ürün : "+ p1.ProductId + " " + " Yeni 3 ürün : " + p2.ProductId);

                //Kategoriye göre ürün ekleme
                //var category = db.Categories.Where(i => i.CategoryName == "Beverages").FirstOrDefault();
                //var p1 = new Product() { ProductName = "yeni 5 ürün"};
                //var p2 = new Product() { ProductName = "yeni 6 ürün" };

                //category.Products.Add(p1);
                //category.Products.Add(p2);
                //db.SaveChanges();

                //Console.WriteLine("Veriler eklendi.");
                //Console.WriteLine("Yeni 5 ürün : " + p1.ProductId + " " + " Yeni 6 ürün : " + p2.ProductId);

                #endregion
                #region ESKİ5
                //// change tracking
                //var product = db.Products
                //    //.AsNoTracking()
                //    .FirstOrDefault(p => p.ProductId == 1);
                //if (product != null)
                //{
                //    product.UnitsInStock += 10;
                //    db.SaveChanges();
                //    Console.WriteLine("veri güncellendi.");
                //}
                //select olmadanda update yapılabilir.
                //var p = new Product() { ProductId = 1 };
                //db.Products.Attach(p);
                //p.UnitsInStock = 50;
                //db.SaveChanges();
                //Console.WriteLine("işlem tamam");
                //var product = db.Products.Find(1);
                //if (product != null)
                //{
                //    product.UnitPrice = 28; db.Update(product); db.SaveChanges();
                //} 
                #endregion
                #region ESKi6
                //var p = db.Products.Find(99);
                //if (p != null)
                //{
                //    db.Products.Remove(p);
                //    db.SaveChanges();
                //}

                var p = new Product() { ProductId = 87 };
                //db.Entry(p).State = EntityState.Deleted;
                db.Products.Remove(p);
                db.SaveChanges();

                #endregion
                
            }
            Console.ReadLine();
        }
    }
}
