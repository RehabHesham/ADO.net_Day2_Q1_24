using ITI.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITI.presentation
{
    public partial class Student : Form
    {
        StudentBL studentBL;
        public Student()
        {
            InitializeComponent();
            studentBL = new StudentBL();
        }
    }
}
