using Microsoft.EntityFrameworkCore;
using ORMProject.Model;
using ORMTesting.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORMProject.ORM
{
    public static class EFQuery
    {
       static int flag = 0b_1001_1110;
        public static void SelectQueryImplementation(int numberOfRecords= 5000)
        {
            using (var context = new AppDBContext())
            {
                var products = context.Database
                    .SqlQuery<ProductDTO>
                    ($"Select * from Products").Take(numberOfRecords).AsNoTracking()
                    .ToList();
            }
        }
    }
}
