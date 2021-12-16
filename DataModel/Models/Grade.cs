using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class Grade
    {
        public Grade()
        {
            EmployeeGrades = new HashSet<EmployeeGrade>();
            EmpolyeeSalaryDetails = new HashSet<EmpolyeeSalaryDetail>();
        }

        public int GradeId { get; set; }
        public string? GradeName { get; set; }
        public string? GradeShortName { get; set; }
        public int? GradeBasic { get; set; }
        public int? GradeTa { get; set; }
        public int? GradeDa { get; set; }
        public int? GradeHra { get; set; }
        public int? GradeMa { get; set; }
        public int? GardeBonus { get; set; }
        public int? GradePf { get; set; }
        public int? GradePt { get; set; }

        public virtual ICollection<EmployeeGrade> EmployeeGrades { get; set; }
        public virtual ICollection<EmpolyeeSalaryDetail> EmpolyeeSalaryDetails { get; set; }
    }
}
