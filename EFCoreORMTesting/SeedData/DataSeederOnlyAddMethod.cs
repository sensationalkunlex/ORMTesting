using ORMTesting.Data;
using ORMTesting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreORMTesting.SeedData
{
    public static class DataSeederOnlyAddMethod
    {
        public static int SeedData(int totalSize=5000)
        {
            using (var context = new AppDBContext())
            {
                //context.Database.EnsureCreated();
                for (int i = 0; i < totalSize; i++)
                {
                    Product product = new()
                    {
                        Name = $"Product {i + 1}",
                        Description = $"Description of the product with Reg {i + 1}",
                        Category = $"Category {i % 5}"
                    };
                   

                    context.Products.Add(product);
                }

             return   context.SaveChanges();
            }
        }
    }
}
