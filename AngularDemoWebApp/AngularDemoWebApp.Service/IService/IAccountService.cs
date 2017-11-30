using AngularDemoWebApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemoWebApp.Service.IService
{
   public  interface IAccountService
    {

        #region PUBLIC METHOD

        List<UserModel> GetUsers();

        UserModel GetUser(int userId);

        void AddUser(UserModel userModel);

        void DeleteUser(int userId);

        #endregion
    }
}
