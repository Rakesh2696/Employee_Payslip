using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IEmployeeGradeRepository
    {

    }
    public class EmployeeGradeRepository: IEmployeeGradeRepository
    {
        private PayRollManagementContext _context;

        public EmployeeGradeRepository(PayRollManagementContext context)
        {
            _context = context;
        }
    }
}
