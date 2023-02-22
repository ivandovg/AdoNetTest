using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ado11_1
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public ICollection<Teacher>? Teachers { get; set; }
    }

    internal class Teacher
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set;}
    }
}
