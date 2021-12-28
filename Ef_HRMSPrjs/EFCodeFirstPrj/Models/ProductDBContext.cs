using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirstPrj.Models
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext() : base("name=ProductDBEntities")
        {

        }

        public DbSet<tbl_product> tbl_products { get; set; }
        public DbSet<tbl_order> tbl_orders { get; set; }
    }
}