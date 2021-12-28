using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFDataAccessLib;

namespace Ef_HRMSPrj.Models
{
    public class HRMSBusinessLayer
    {
        public List<tbl_employee> GetAllEmps()
        {
            
            var dal = new EFDataAccessLayer();
            var lstEmps = dal.GetAllEmps();
            return lstEmps;
        }
    }
}