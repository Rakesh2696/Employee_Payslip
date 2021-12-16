using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeCode { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
