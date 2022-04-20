using DataInterfaces.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces.Models
{
    public class UserModel
    {
        public string Email { get; set; }
        public UserModel(UserDTO dto)
        {
            Email = dto.Email;
        }
     
    }
}
