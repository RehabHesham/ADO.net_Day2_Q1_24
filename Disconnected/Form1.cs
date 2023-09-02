using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics;

namespace Disconnected
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dataTable;
        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Server=.;Database=ITI;Trusted_Connection=True;TrustServerCertificate=True;");
            adapter = new SqlDataAdapter();
            dataTable = new DataTable();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetInstructors();
            GetDepartments();
        }

        void GetInstructors()
        {
            // select command
            SqlCommand selecCommand = new SqlCommand("Select * from Instructor",connection);

            adapter.SelectCommand = selecCommand;
            adapter.Fill(dataTable);

            dgv_instructors.DataSource = dataTable;
            dgv_instructors.Columns[0].ReadOnly = true;
        }
        void GetDepartments()
        {
            SqlCommand selecCommand = new SqlCommand("select Dept_Id as id,Dept_Name from Department", connection);


            DataTable dt = new DataTable();
            adapter.SelectCommand = selecCommand;
            adapter.Fill(dt);

            cb_department.DataSource = dt;

            cb_department.ValueMember = "id";
            cb_department.DisplayMember = "Dept_Name";
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dataTable.NewRow();
            dataRow["Ins_Name"] = txt_name.Text;
            dataRow["Ins_Degree"] = cb_degree.SelectedItem;
            dataRow["salary"] = nud_salary.Value;
            dataRow["Dept_Id"] = cb_department.SelectedValue;

            dataTable.Rows.Add(dataRow);
        }

        int currentId;
        private void dgv_instructors_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // currentId = 1;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in dataTable.Rows)
            {
                if ((int)row["Ins_Id"] == currentId)
                {
                    row["Ins_Name"] = txt_name.Text;
                    row["Ins_Degree"] = cb_degree.SelectedItem;
                    row["salary"] = nud_salary.Value;
                    row["Dept_Id"] = cb_department.SelectedValue;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                if ((int)row["Ins_Id"] == currentId)
                {
                    // bonus
                    row.Delete();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
           
            foreach(DataRow row in dataTable.Rows)
            {
                Debug.WriteLine($"row {row.ToString()} => state => {row.RowState}");
            }
            Debug.WriteLine("==========================");


            adapter.UpdateCommand = new SqlCommand("update Instructor set Ins_name = @name, Ins_Degree= @degree,salary = @salary, Dept_Id= @dept where Ins_Id = @id", connection);
            adapter.UpdateCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Ins_Name");
            adapter.UpdateCommand.Parameters.Add("degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            adapter.UpdateCommand.Parameters.Add("salary", SqlDbType.Money, 4, "Salary");
            adapter.UpdateCommand.Parameters.Add("dept", SqlDbType.Int, 4, "Dept_Id");
            adapter.UpdateCommand.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");

            adapter.InsertCommand = new SqlCommand("insert into Instructor values(@name,@degree,@salary,@dept)", connection);
            adapter.InsertCommand.Parameters.Add("name", SqlDbType.NVarChar, 50, "Ins_Name");
            adapter.InsertCommand.Parameters.Add("degree", SqlDbType.NVarChar, 50, "Ins_Degree");
            adapter.InsertCommand.Parameters.Add("salary", SqlDbType.Money, 4, "Salary");
            adapter.InsertCommand.Parameters.Add("dept", SqlDbType.Int, 4, "Dept_Id");

            adapter.DeleteCommand = new SqlCommand("delete from Instructor where Ins_Id = @id",connection);
            adapter.DeleteCommand.Parameters.Add("id", SqlDbType.Int, 4, "Ins_Id");

            adapter.Update(dataTable);


            GetInstructors();
        }
    }
}