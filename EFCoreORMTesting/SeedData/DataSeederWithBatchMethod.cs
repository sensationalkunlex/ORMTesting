using ORMTesting.Data;
using ORMTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreORMTesting.SeedData
{
    public static class DataSeederWithBatchMethod
    {
        public static int SeedData(int totalSize=5000)
        {
            //int count;
            using (var context = new AppDBContext())
            {
             
                //context.Database.EnsureCreated();
                
                int batchSize = 1000;
                for (int i = 0; i < totalSize; i += batchSize)
                {

                    var products= GenerateProductsUsingBatches(i,i+ batchSize);
                    context.Products.AddRange(products);
                  
                }
                return context.SaveChanges();

               
            }
        }
        static List<Product> GenerateProductsUsingBatches(int startId, int batchSize)
        {
            var products = new List<Product>();
            for (int i = startId; i < batchSize; i++)
            {
                var product = new Product
                {
                    Name = $"Product {i + 1}",
                    Description = $"Description of the product with Reg {i + 1}",
                    Category = $"Category {i % 5}"
                };

                products.Add(product);
            }
            return products;
        }
    }
}
