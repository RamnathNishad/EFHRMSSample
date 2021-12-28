using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstPrj.Models
{
    public class ProductDataAccessLayer
    {
        public void AddProduct(tbl_product product)
        {
            //TODO Insert
            using (var dbCtx=new ProductDBContext())
            {
                dbCtx.tbl_products.Add(product);
                dbCtx.SaveChanges();
            }
        }
        public void DeleteProductById(int id)
        {
            using(var dbCtx =new ProductDBContext())
            {
                var product = dbCtx.tbl_products.Where(p => p.Id == id).SingleOrDefault();
                if(product!=null)
                {
                    dbCtx.tbl_products.Remove(product);
                    dbCtx.SaveChanges();
                }
            }
        }
        public void UpdateProductById(tbl_product product)
        {
            using (var dbCtx = new ProductDBContext())
            {
                var record = dbCtx.tbl_products.Where(p => p.Id == product.Id).SingleOrDefault();
                if (record != null)
                {
                    record.Name = product.Name;
                    record.Price = product.Price;
                    dbCtx.SaveChanges();
                }
            }
        }

        public List<tbl_product> GetAllProducts()
        {
            using(var dbCtx=new  ProductDBContext())
            {
                var lstProducts = dbCtx.tbl_products.ToList();
                return lstProducts;
            }
        }
        public tbl_product GetProductDetails(int id)
        {
            using (var dbCtx = new ProductDBContext())
            {
                var product = dbCtx.tbl_products.Where(p => p.Id == id).SingleOrDefault();
                return product;
            }
        }
    }
}