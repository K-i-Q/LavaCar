using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Domain.User
{
    public class UserModel
    {
        public long UserModelId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        
    }
}
