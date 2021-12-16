using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IDepartmentRepository
    {

    }
    public class DepartmentRepository: IDepartmentRepository
    {
        private PayRollManagementContext _context;

        public DepartmentRepository(PayRollManagementContext context)
        {
            _context = context;
        }
    }
}
