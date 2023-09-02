using ITI.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business
{
    public class DepartmentBL
    {
        public DataTable GetAllDepts()
        {
            DbContext context = new DbContext();
            string command = "select Dept_Id,Dept_Name from Department";

            return context.GetData(command);
        }
    }
}
