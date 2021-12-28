using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccessLib
{
    public class EFDataAccessLayer
    {
        public List<tbl_employee> GetAllEmps()
        {
            using(var dbCtx=new DemoDBEntities() )
            {
                var lstEmps = dbCtx.tbl_employee.ToList();
                return lstEmps;
            }
        }

        public tbl_employee GetEmpById(int id)
        {
            using (var dbCtx = new DemoDBEntities())
            {
                var emp = dbCtx.tbl_employee
                               .Where(o => o.ecode == id)
                               .SingleOrDefault();

                //delete the record if found                
                return emp;                
            }
        }
        public void AddEmployee(tbl_employee emp)
        {
            using(var dbCtx=new DemoDBEntities())
            {
                dbCtx.tbl_employee.Add(emp);
                dbCtx.SaveChanges();
            }
        }
        public void DeleteEmpById(int id)
        {
            using(var dbCtx=new DemoDBEntities())
            {
                var emp = dbCtx.tbl_employee
                               .Where(o => o.ecode == id)
                               .SingleOrDefault();

                //delete the record if found
                if (emp != null)
                {
                    dbCtx.tbl_employee.Remove(emp);
                    dbCtx.SaveChanges();
                }
            }
        }

        public void UpdateEmp(tbl_employee emp)
        {
            using (var dbCtx = new DemoDBEntities())
            {
                var record = dbCtx.tbl_employee
                               .Where(o => o.ecode == emp.ecode)
                               .SingleOrDefault();

                //update the record if found
                if (record != null)
                {
                    record.ename = emp.ename;
                    record.salary = emp.salary;
                    record.deptid = emp.deptid;

                    dbCtx.SaveChanges();
                }
            }
        }

        public void CallSP(int ec,int sal)
        {
            using(var dbCtx=new DemoDBEntities())
            {
                dbCtx.sp_updateemp(ec, sal);
            }
        }
    }
}
