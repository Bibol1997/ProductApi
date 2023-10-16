using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductApi.Model;

namespace ProductApi
{
    public class Data : DbContext
    {
        public Data (DbContextOptions<Data> options)
            : base(options)
        {
        }

        public DbSet<ProductApi.Model.Product> Product { get; set; }
        public DbSet<ProductApi.Model.Product> Category { get; set; }
    }
}
