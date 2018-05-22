using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagicalCrafters.Models;
using MagicalCrafters.Mappers;
using MagicalCrafters.DAL;
using MagicalCrafters.DAL.Models.DAL;
using AutoMapper;

namespace MagicalCrafters.Controllers
{
    public class UsersController : Controller
    {
        #region Objects
        static Users _user = new Users();
        static UsersAccess _userAccess = new UsersAccess();
        protected Mapper _mapper;
        #endregion

        #region Index
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");
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
        public ActionResult GetUser(int userId)
        {
            Users user = new Users();
            ViewModels userVM = new ViewModels();
            user = _mapper.Map<Users>(_userAccess.GetUser(userId));
            return View();
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