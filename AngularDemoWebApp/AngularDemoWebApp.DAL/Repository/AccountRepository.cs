using AngularDemoWebApp.DAL.Data;
using AngularDemoWebApp.DAL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemoWebApp.DAL.Repository
{
    public class AccountRepository : IAccountRepository
    {
        #region CONSTRUCTOR

        private readonly DBPracticeEntities context;
        public AccountRepository()
        {
            context = new DBPracticeEntities();
        }

        #endregion

        #region PUBLIC METHOD

        public IQueryable<User> GetUsers()
        {
            try
            {
                return context.Users.AsQueryable<User>();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public  User GetUser(int userId)
        {
            try
            {
                return context.Users.Where(m => m.UserId == userId).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddUser(User user)
        {
            try
            {
                if (user.UserId <= 0)
                {
                    context.Users.Add(user);
                }
                else
                {
                    context.Entry(user).State = System.Data.Entity.EntityState.Modified;
                }
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteUser(int userId)
        {
            try
            {
                User user = this.GetUser(userId);
                context.Users.Remove(user);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
