using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFCodeFirstPrj.Models
{
    public class tbl_product
    {      
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }        
        public tbl_order OrderId { get; set; }
    }
}