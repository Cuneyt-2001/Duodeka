using LogicInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicInterfaces
{
    public interface IUserContainer
    {
        UserModel Login(string email, string password);
    }
}
