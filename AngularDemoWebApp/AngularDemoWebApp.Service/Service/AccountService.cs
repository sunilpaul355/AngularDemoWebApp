using AngularDemoWebApp.DAL.Data;
using AngularDemoWebApp.DAL.IRepository;
using AngularDemoWebApp.Domain.Models;
using AngularDemoWebApp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularDemoWebApp.Service.Service
{
    public class AccountService :IAccountService
    {
        private readonly IAccountRepository accountRepository;
        #region CONSTRUCTOR

        public AccountService(IAccountRepository accountRepository )
        {
            this.accountRepository = accountRepository;
        }

        #endregion

        #region PUBLIC METHOD

        public List<UserModel> GetUsers()
        {
            try
            {
                List<UserModel> users = accountRepository.GetUsers().Select(m => new UserModel()
                {
                    FirstName=m.FirstName,
                    LastName=m.LastName,
                    Gender=m.Gender,
                    Email=m.Email,
                    MobileNumber=m.MobileNumber
                }).ToList();
                return users;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public UserModel GetUser(int userId)
        {
            try
            {
                User user = accountRepository.GetUser(userId);
                UserModel userModel = new UserModel();
                userModel.FirstName = user.FirstName;
                userModel.LastName = user.LastName;
                userModel.Gender = user.Gender;
                userModel.Email = user.Email;
                userModel.MobileNumber = user.MobileNumber;
                return userModel;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void AddUser(UserModel userModel)
        {
            try
            {
                User user = new User();
                user.FirstName = userModel.FirstName;
                user.LastName = userModel.LastName;
                user.Gender = userModel.Gender;
                user.Email = userModel.Email;
                user.Password = userModel.Password;
                user.MobileNumber = userModel.MobileNumber;
                if (userModel.UserId <= 0)
                {
                    user.DateCreated = DateTime.Now;
                    user.CreatedBy = 1;
                }
                else
                {
                    user.DateUpdated = DateTime.Now;
                    user.UpdatedBy = 1;
                }
                accountRepository.AddUser(user);
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
                accountRepository.DeleteUser(userId);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        



        #endregion
    }
}
