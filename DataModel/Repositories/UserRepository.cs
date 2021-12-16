using DataModel.Models;
using Microsoft.EntityFrameworkCore;
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
        User GetLogIn(User user);
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
            return _context.Users.Include(x=>x.UserTypeModel).ToList();
        }

        public User? GetLogIn(User user)
        {
            return _context.Users.Include(x => x.UserTypeModel).Where(x => x.EmailId == user.EmailId && x.Password == user.Password && x.UserTypeModel.UserTypeCode==user.UserType)?.FirstOrDefault();
        }
    }
}
