using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
        public int UserId { get; set; }
   
        public string UserName { get; set; }
  
        public string UsersUserName { get; set; }
   
        public string Password { get; set; }
  
        public string UserPhoneNumber { get; set; }
    
        public DateTime UserDateOfBirth { get; set; }
   
        public string UserCity { get; set; }
  
        public string UserRegion { get; set; }
   
        public string UserEmail { get; set; }

        public bool UserRedList { get; set; }

        public bool UserLogInValid { get; set; }

        public string UserType { get; set; }
    }
}
