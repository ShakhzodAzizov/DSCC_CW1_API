using Microsoft.EntityFrameworkCore;
using ProductsAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.DBContexts
{
    public class ProductContext: DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base (options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }
    }
}
