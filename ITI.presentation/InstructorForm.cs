using ITI.Business;
using System.Data;

namespace ITI.presentation
{
    public partial class InstructorForm : Form
    {
        InstructorBL InstructorBL;
        DepartmentBL DepartmentBL;
        public InstructorForm()
        {
            InitializeComponent();
            InstructorBL = new InstructorBL();
            DepartmentBL = new DepartmentBL();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = InstructorBL.GetAllV1();
            dgv_instructors.DataSource = dataTable;


            cb_department.DataSource = DepartmentBL.GetAllDepts();
            cb_department.ValueMember = "Dept_Id";
            cb_department.DisplayMember = "Dept_Name";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int affectedRows = InstructorBL.Insert(txt_name.Text, cb_degree.SelectedItem.ToString(), nud_salary.Value, (int)cb_department.SelectedValue);

            if (affectedRows > 0)
            {
                MessageBox.Show("Data have been added");
            }

        }
    }
}