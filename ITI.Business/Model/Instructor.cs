using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Business.Model
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
        public decimal salary { get; set; }
        public int Dept_Id { get; set; }
    }
}
