using DataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
    public class UserRepository: IUserRepository
    {
        private PayRollManagementContext _context;

        public UserRepository(PayRollManagementContext context)
        {
            _context = context;
        }
        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}
