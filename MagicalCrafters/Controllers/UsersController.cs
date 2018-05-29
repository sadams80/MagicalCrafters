using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagicalCrafters.Models;
using MagicalCrafters.Mappers;
using MagicalCrafters.DAL;
using MagicalCrafters.DAL.Models.DAL;

namespace MagicalCrafters.Controllers
{
    public class UsersController : Controller
    {
        #region Objects
        public static Users _user = new Users();
        public static UsersAccess _userAccess = new UsersAccess();
        public static Mappers_DAL _mappersDAL = new Mappers_DAL();
        #endregion

        #region Index
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        #endregion

        #region Login Logout
        [HttpGet]
        public ActionResult Login(string username, string password)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ViewModels userToLogin)
        {
            return View();
        }

        public ActionResult Logout()
        {
            return View();
        }
        #endregion

        #region Get
        public ActionResult GetUser()
        {
            int userId = 1;
            ViewModels userVM = new ViewModels();
            userVM.SingleUser = _mappersDAL.Map(_userAccess.GetUser(userId));
            //userVM.SingleUsers_Info = _mappersDAL.MapUserInfo(userVM.SingleUser.User_Info);
            return View(userVM);
        }

        public ActionResult GetUsers()
        {
            return View();
        }
        #endregion

        #region Post
        [HttpGet]
        public ActionResult PostUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostUser(ViewModels userToPost)
        {
            return View();
        }
        #endregion

        #region Patch
        [HttpGet]
        public ActionResult PatchUser(int UserId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatchUser(ViewModels userToPatch)
        {
            return View();
        }
        #endregion

        #region Delete
        [HttpGet]
        public ActionResult DeleteUser(int userId)
        {
            return View();
        }
        #endregion
    }
}