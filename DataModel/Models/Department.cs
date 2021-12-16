using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class Department
    {
        public Department()
        {
            EmployeeGrades = new HashSet<EmployeeGrade>();
            Employees = new HashSet<Employee>();
            EmpolyeeSalaryDetails = new HashSet<EmpolyeeSalaryDetail>();
        }

        public int DeptId { get; set; }
        public string? DeptName { get; set; }

        public virtual ICollection<EmployeeGrade> EmployeeGrades { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<EmpolyeeSalaryDetail> EmpolyeeSalaryDetails { get; set; }
    }
}
