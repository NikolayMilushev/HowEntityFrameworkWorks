using System;
using System.Data.Entity;
using System.Linq;

namespace HowEntityFrameworkWorks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyDb())
            {
                db.Products.Add(new Product { Name = "Product 1" });
                db.Products.Add(new Product { Name = "Product 2" });
                db.SaveChanges();

                var products = db.Products.AsNoTracking().ToList();
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);
                }
                
                

                products = db.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);//names not changed
                }
            }

            using (var db = new MyDb())
            {
                var products = db.Products.ToList();
                foreach (var product in products)
                {
                    Console.WriteLine(product.Name);//names changed
                }
            }

        }
    }

    public class MyDb: DbContext
    {
        public MyDb()
            :base("server=.;database=products;integrated security=true;")
        {
            
        }
        
        public DbSet<Product> Products { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
