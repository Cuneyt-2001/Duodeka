using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataInterfaces.DTOs;

namespace DataInterfaces
{
    public interface IUserDAL
    {
      public UserDTO LogIn(string email, string wachtwoord);

    }
}
