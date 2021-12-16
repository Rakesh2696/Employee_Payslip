using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IEmployeeRepository
    {

    }
    public class EmployeeRepository: IEmployeeRepository
    {
        private PayRollManagementContext _context;

        public EmployeeRepository(PayRollManagementContext context)
        {
            _context = context;
        }
    }
}
