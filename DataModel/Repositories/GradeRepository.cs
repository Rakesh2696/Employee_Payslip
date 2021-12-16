using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IGradeRepository
    {

    }
    public class GradeRepository: IGradeRepository
    {
        private PayRollManagementContext _context;

        public GradeRepository(PayRollManagementContext context)
        {
            _context = context;
        }
    }
}
