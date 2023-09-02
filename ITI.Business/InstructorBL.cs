using ITI.Business.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITI.DataAccess;
using Microsoft.Data.SqlClient;

namespace ITI.Business
{
    public class InstructorBL
    {
        DbContext context;
        public InstructorBL() {
        context = new DbContext();
        }
        // get all
        public DataTable GetAllV1()
        {
            string command = "select * from Instructor";

           return  context.GetData(command);
        }
       
        public List<Instructor> GetAllV2()
        {
            string command = "select * from Instructor";
            DataTable dataTable = context.GetData(command); 

            List<Instructor> instructors= new List<Instructor>();

            foreach(DataRow row in dataTable.Rows)
            {
                instructors.Add(new Instructor()
                {
                    Id = (int)row["Ins_Id"],
                    Name = row["Ins_Name"].ToString(),
                    Degree = row["Ins_Degree"].ToString(),
                    salary = (decimal) row["salary"],
                    Dept_Id = (int)row["Dept_Id"]
                }) ; 
            }
            return instructors ;
        }
        // get by id
        public DataTable GetById(int id)
        {
            string command = $"select * from Instructor where Ins_ID = {id}";

            return context.GetData(command);
        }
        public Instructor GetByIdV2(int id)
        {
            string command = $"select * from Instructor where Ins_ID = {id}";

            DataTable dataTable = context.GetData(command);
            Instructor instructor = new Instructor()
            {
                Id = (int)dataTable.Rows[0]["Ins_Id"],
                Name = dataTable.Rows[0]["Ins_Name"].ToString(),
                Degree = dataTable.Rows[0]["Ins_Degree"].ToString(),
                salary = (decimal)dataTable.Rows[0]["salary"],
                Dept_Id = (int)dataTable.Rows[0]["Dept_Id"]
            };

            return instructor;
        }
        //edit
        public int Update(string name, string degree, decimal salary, int deptId, int ins_id)
        {
            string command = "update Instructor set Ins_name = @name, Ins_Degree= @degree,salary = @salary, Dept_Id= @dept where Ins_Id = @id";

            SqlParameter[] sqlParameters = new SqlParameter[5];
            sqlParameters[0] = new SqlParameter("name", name);
            sqlParameters[1] = new SqlParameter("degree", degree);
            sqlParameters[2] = new SqlParameter("salary", salary);
            sqlParameters[3] = new SqlParameter("dept", deptId);
            sqlParameters[4] = new SqlParameter("id", ins_id);


          return  context.ExecuteNonQuery(command, sqlParameters);
        }

        //add
        public int Insert(string name, string degree, decimal salary, int deptId)
        {
            string command = "insert into Instructor values(@name,@degree,@salary,@dept)";

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("name", name);
            sqlParameters[1] = new SqlParameter("degree", degree);
            sqlParameters[2] = new SqlParameter("salary", salary);
            sqlParameters[3] = new SqlParameter("dept", deptId);


            return context.ExecuteNonQuery(command, sqlParameters);
        }

        //delete
         public int delete(int id)
        {
            string command = "delete from Instructor where Ins_Id = @id";

            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("id", id);


            return context.ExecuteNonQuery(command, sqlParameters);
        }
    }
}
