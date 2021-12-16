using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class User
    {
        public User()
        {
            Employees = new HashSet<Employee>();
        }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string UserType { get; set; }
        public int? UserTypeId { get; set; }

        public virtual UserType UserTypeModel{ get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
