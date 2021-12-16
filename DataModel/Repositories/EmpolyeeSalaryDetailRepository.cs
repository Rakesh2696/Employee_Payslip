using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IEmpolyeeSalaryDetailRepository
    {

    }
    public class EmpolyeeSalaryDetailRepository: IEmpolyeeSalaryDetailRepository
    {
        private PayRollManagementContext _context;

        public EmpolyeeSalaryDetailRepository(PayRollManagementContext context)
        {
            _context = context;
        }
    }
}
