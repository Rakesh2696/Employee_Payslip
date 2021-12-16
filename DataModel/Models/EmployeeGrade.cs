using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class EmployeeGrade
    {
        public int TransactionId { get; set; }
        public int? EmpDeptId { get; set; }
        public int? EmpId { get; set; }
        public int? EmpGardeId { get; set; }
        public DateTime? EmpFromDate { get; set; }
        public string? EmpToDate { get; set; }

        public virtual Employee? Emp { get; set; }
        public virtual Department? EmpDept { get; set; }
        public virtual Grade? EmpGarde { get; set; }
    }
}
