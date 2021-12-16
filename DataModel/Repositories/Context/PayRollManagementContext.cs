using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataModel.Models
{
    public partial class PayRollManagementContext : DbContext
    {
        public PayRollManagementContext()
        {
        }

        public PayRollManagementContext(DbContextOptions<PayRollManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeGrade> EmployeeGrades { get; set; } = null!;
        public virtual DbSet<EmpolyeeSalaryDetail> EmpolyeeSalaryDetails { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Departme__DCA6597426903D3D");

                entity.ToTable("Department");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("dept_name");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.EmpAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("emp_address");

                entity.Property(e => e.EmpCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_city");

                entity.Property(e => e.EmpDob)
                    .HasColumnType("date")
                    .HasColumnName("emp_dob");

                entity.Property(e => e.EmpDoj)
                    .HasColumnType("date")
                    .HasColumnName("emp_doj");

                entity.Property(e => e.EmpMailId)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("emp_mail_id");

                entity.Property(e => e.EmpMobNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_mob_number");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpPanNumber)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("emp_pan_number");

                entity.Property(e => e.EmpPincode).HasColumnName("emp_pincode");

                entity.Property(e => e.EmpState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_state");

                entity.Property(e => e.EmpTitile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_titile");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_dept_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Employee_Users");
            });

            modelBuilder.Entity<EmployeeGrade>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Employee__85C600AFE6E5F3E2");

                entity.ToTable("EmployeeGrade");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.EmpDeptId).HasColumnName("emp_dept_id");

                entity.Property(e => e.EmpFromDate)
                    .HasColumnType("date")
                    .HasColumnName("emp_from_date");

                entity.Property(e => e.EmpGardeId).HasColumnName("emp_garde_id");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpToDate)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("emp_to_date");

                entity.HasOne(d => d.EmpDept)
                    .WithMany(p => p.EmployeeGrades)
                    .HasForeignKey(d => d.EmpDeptId)
                    .HasConstraintName("FK__EmployeeG__emp_d__2C3393D0");

                entity.HasOne(d => d.EmpGarde)
                    .WithMany(p => p.EmployeeGrades)
                    .HasForeignKey(d => d.EmpGardeId)
                    .HasConstraintName("FK__EmployeeG__emp_g__2E1BDC42");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmployeeGrades)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__EmployeeG__emp_i__2D27B809");
            });

            modelBuilder.Entity<EmpolyeeSalaryDetail>(entity =>
            {
                entity.HasKey(e => e.TransactionId)
                    .HasName("PK__Empolyee__85C600AF214F3479");

                entity.Property(e => e.TransactionId).HasColumnName("transaction_id");

                entity.Property(e => e.EmpBasic).HasColumnName("emp_basic");

                entity.Property(e => e.EmpBonus).HasColumnName("emp_bonus");

                entity.Property(e => e.EmpDa).HasColumnName("emp_da");

                entity.Property(e => e.EmpDeptId).HasColumnName("emp_dept_id");

                entity.Property(e => e.EmpGradeId).HasColumnName("emp_grade_id");

                entity.Property(e => e.EmpGross).HasColumnName("emp_gross");

                entity.Property(e => e.EmpHra).HasColumnName("emp_hra");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.EmpMa).HasColumnName("emp_ma");

                entity.Property(e => e.EmpPf).HasColumnName("emp_pf");

                entity.Property(e => e.EmpPt).HasColumnName("emp_pt");

                entity.Property(e => e.EmpSalaryEmbursmentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_salary_embursment_date");

                entity.Property(e => e.EmpSalaryMonth)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("emp_salary_month");

                entity.Property(e => e.EmpSalaryYear)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("emp_salary_year");

                entity.Property(e => e.EmpTa).HasColumnName("emp_ta");

                entity.Property(e => e.EmpTotalGrossSalary).HasColumnName("emp_total_gross_salary");

                entity.HasOne(d => d.EmpDept)
                    .WithMany(p => p.EmpolyeeSalaryDetails)
                    .HasForeignKey(d => d.EmpDeptId)
                    .HasConstraintName("FK__EmpolyeeS__emp_d__31EC6D26");

                entity.HasOne(d => d.EmpGrade)
                    .WithMany(p => p.EmpolyeeSalaryDetails)
                    .HasForeignKey(d => d.EmpGradeId)
                    .HasConstraintName("FK__EmpolyeeS__emp_g__32E0915F");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.EmpolyeeSalaryDetails)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK__EmpolyeeS__emp_i__30F848ED");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("Grade");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.GardeBonus).HasColumnName("garde_bonus");

                entity.Property(e => e.GradeBasic).HasColumnName("grade_basic");

                entity.Property(e => e.GradeDa).HasColumnName("grade_da");

                entity.Property(e => e.GradeHra).HasColumnName("grade_hra");

                entity.Property(e => e.GradeMa).HasColumnName("grade_ma");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("grade_name");

                entity.Property(e => e.GradePf).HasColumnName("grade_pf");

                entity.Property(e => e.GradePt).HasColumnName("grade_pt");

                entity.Property(e => e.GradeShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("grade_short_name");

                entity.Property(e => e.GradeTa).HasColumnName("grade_ta");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email_id");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("user_name");

                entity.Property(e => e.UserType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_type");

                entity.Property(e => e.UserTypeId).HasColumnName("UserType");

                entity.HasOne(d => d.UserTypeModel)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .HasConstraintName("FK_Users_UserType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.UserTypeId).HasColumnName("UserType_Id");

                entity.Property(e => e.UserTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UserType_Code");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
