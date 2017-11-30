using AngularDemoWebApp.Domain.Models;
using AngularDemoWebApp.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularDemoWebApp.Controllers
{
    public class AccountController : Controller
    {
        #region CONSTRUCTOR
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        #endregion

        #region PUBLIC METHOD

        // GET: Account
        public ActionResult Index()
        {
            List<UserModel> userModel = accountService.GetUsers();
            return View(userModel);
        }


        [HttpGet]
        public ActionResult Registration()
        {
            try
            {
               
                return View();
            }
            catch (Exception ex)
            {
                //TODO write down code for log exception
                throw ex;
            }
        }


        [HttpPost]
        public ActionResult Registration(UserModel userModel )
        {
            try
            {
                accountService.AddUser(userModel);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                //TODO write down code for log exception
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult Edit(int userId)
        {
            try
            {
                UserModel userModel = accountService.GetUser(userId);
                return View(userModel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        public JsonResult Delete(int userId)
        {
            try
            {
                accountService.DeleteUser(userId);
                return Json(new { Success = true, Message="User deleted successfully" }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { Success = false, Message = "Something went wrong" }, JsonRequestBehavior.AllowGet);
               // throw;
            }
        }

        #endregion


    }
}