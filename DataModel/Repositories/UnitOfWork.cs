
using DataModel.Models;
using System;
using Microsoft.Extensions.Configuration;
using DataModel.Repositories;

namespace DataModel.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        int Complete();
        IDepartmentRepository IDepartmentRepository { get; }
        IEmployeeGradeRepository IEmployeeGradeRepository { get; }
        IEmployeeRepository IEmployeeRepository { get; }
        IEmpolyeeSalaryDetailRepository IEmpolyeeSalaryDetailRepository { get; }
        IGradeRepository IGradeRepository { get; }
        IUserRepository IUserRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        private PayRollManagementContext _DataContext;
        private readonly IConfiguration Configuration;

        private DepartmentRepository _departmentRepository;
        private EmployeeGradeRepository _employeeGradeRepository;
        private EmployeeRepository _employeeRepository;
        private EmpolyeeSalaryDetailRepository _empolyeeSalaryDetailRepository;
        private GradeRepository _gradeRepository;
        private UserRepository _userRepository;

        public UnitOfWork(PayRollManagementContext dataContext, IConfiguration configuration)
        {
            _DataContext = dataContext;
            Configuration = configuration;
        }

        public IDepartmentRepository IDepartmentRepository => _departmentRepository ?? (_departmentRepository = new DepartmentRepository(_DataContext));
        public IEmployeeGradeRepository IEmployeeGradeRepository => _employeeGradeRepository ?? (_employeeGradeRepository = new EmployeeGradeRepository(_DataContext));
        public IEmployeeRepository IEmployeeRepository => _employeeRepository ?? (_employeeRepository = new EmployeeRepository(_DataContext));
        public IEmpolyeeSalaryDetailRepository IEmpolyeeSalaryDetailRepository => _empolyeeSalaryDetailRepository ?? (_empolyeeSalaryDetailRepository = new EmpolyeeSalaryDetailRepository(_DataContext));
        public IGradeRepository IGradeRepository => _gradeRepository ?? (_gradeRepository = new GradeRepository(_DataContext));
        public IUserRepository IUserRepository => _userRepository ?? (_userRepository = new UserRepository(_DataContext));
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_DataContext != null)
                {
                    _DataContext.Dispose();
                    _DataContext = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public int Complete()
        {
            return _DataContext.SaveChanges();
        }

    }
}
