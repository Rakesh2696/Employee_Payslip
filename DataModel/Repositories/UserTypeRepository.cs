using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IUserTypeRepository
    {
        List<UserType> GetAll();
    }
    public class UserTypeRepository: IUserTypeRepository
    {
        private PayRollManagementContext _context;

        public UserTypeRepository(PayRollManagementContext context)
        {
            _context = context;
        }
        public List<UserType> GetAll()
        {
            return _context.UserTypes.ToList();
        }
    }
}
