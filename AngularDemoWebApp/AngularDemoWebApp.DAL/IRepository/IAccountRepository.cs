using AngularDemoWebApp.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemoWebApp.DAL.IRepository
{
    public interface IAccountRepository
    {
        #region PUBLIC METHOD

        IQueryable<User> GetUsers();

        User GetUser(int userId);

        void AddUser(User userModel);

        void DeleteUser(int userId);

        #endregion
    }
}
