using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirstPrj.Models
{
    public class tbl_order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public List<tbl_product> Products { get; set; }
    }
}