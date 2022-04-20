using DataInterfaces;
using LogicInterfaces;
using LogicInterfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class UserContainer : IUserContainer
    {
        private IUserDAL _userDAL ;

        public UserContainer(IUserDAL userDAL)
        {
          _userDAL = userDAL;
        }

        public UserModel Login(string email, string password)
        {
          return new UserModel( _userDAL.LogIn(email, password));
        }
    }
}
