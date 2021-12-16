using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class Employee
    {
        public Employee()
        {
            EmployeeGrades = new HashSet<EmployeeGrade>();
            EmpolyeeSalaryDetails = new HashSet<EmpolyeeSalaryDetail>();
        }

        public int EmployeeId { get; set; }
        public string? EmpTitile { get; set; }
        public string? EmpName { get; set; }
        public DateTime? EmpDob { get; set; }
        public DateTime? EmpDoj { get; set; }
        public string? EmpAddress { get; set; }
        public string? EmpCity { get; set; }
        public int? EmpPincode { get; set; }
        public string? EmpMobNumber { get; set; }
        public string? EmpState { get; set; }
        public string? EmpMailId { get; set; }
        public string? EmpPanNumber { get; set; }
        public int? DeptId { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual ICollection<EmployeeGrade> EmployeeGrades { get; set; }
        public virtual ICollection<EmpolyeeSalaryDetail> EmpolyeeSalaryDetails { get; set; }
    }
}
