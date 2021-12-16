using System;
using System.Collections.Generic;

namespace DataModel.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? EmailId { get; set; }
        public string? UserType { get; set; }
    }
}
