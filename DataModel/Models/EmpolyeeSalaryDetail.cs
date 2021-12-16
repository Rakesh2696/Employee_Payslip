using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class EmpolyeeSalaryDetail
    {
        public int TransactionId { get; set; }
        public int? EmpId { get; set; }
        public string? EmpSalaryMonth { get; set; }
        public string? EmpSalaryYear { get; set; }
        public DateTime? EmpSalaryEmbursmentDate { get; set; }
        public int? EmpDeptId { get; set; }
        public int? EmpGradeId { get; set; }
        public int? EmpBasic { get; set; }
        public int? EmpDa { get; set; }
        public int? EmpTa { get; set; }
        public int? EmpHra { get; set; }
        public int? EmpMa { get; set; }
        public int? EmpBonus { get; set; }
        public int? EmpPf { get; set; }
        public int? EmpPt { get; set; }
        public int? EmpGross { get; set; }
        public int? EmpTotalGrossSalary { get; set; }

        public virtual Employee? Emp { get; set; }
        public virtual Department? EmpDept { get; set; }
        public virtual Grade? EmpGrade { get; set; }
    }
}
