using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MagicalCrafters.Models;
using MagicalCrafters.Mappers;
using MagicalCrafters.DAL;
using MagicalCrafters.DAL.Models.DAL;
using MagicalCrafters.BLL;
using System.Configuration;
using System.IO;

namespace MagicalCrafters.Controllers
{
    public class UsersController : Controller
    {
        #region Objects
        public static Users _user = new Users();
        public static UsersAccess _userAccess = new UsersAccess();
        public static HousesAccess _houseAccess = new HousesAccess();
        public static PasswordBLL _passwordBLL = new PasswordBLL();
        public static Mappers_DAL _mappersDAL = new Mappers_DAL();
        public static Mappers_BLL _mappersBLL = new Mappers_BLL();

        static string _errorLog = ConfigurationManager.ConnectionStrings["ErrorLog"].ConnectionString;
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
            if (Session["User_Id"] != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(ViewModels userToLogin)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Users userDB = _mappersDAL.Map(_userAccess.GetUserByUserName(userToLogin.SingleUser.UserName));
                    if (userDB.UserName == userToLogin.SingleUser.UserName)
                    {
                        userToLogin.SingleUser.Password = _passwordBLL.HashPassword(userToLogin.SingleUser.Password, userDB.Salt);
                        bool isValid = _passwordBLL.ValidatePassword(userDB.Password, userToLogin.SingleUser.Password);

                        if (isValid)
                        {
                            Users user = _mappersDAL.Map(_userAccess.GetUser(userDB.User_Id));
                            Session["User_Id"] = user.User_Id;
                            Session["UserName"] = user.UserName;
                            Session["Role_Id"] = user.User_Info.Role_Id;
                            Session["House_Id"] = user.User_Info.House_Id;
                            Session["Points"] = user.User_Info.Points;

                            return RedirectToAction("Index", "Home");
                        }
                        return View(userToLogin);
                    }
                    return View(userToLogin);
                }
                return View(userToLogin);
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Login Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error updating the account. Please try again later.";
                return View(userToLogin);
            }
        }

        public ActionResult Logout()
        {
            try
            {
                if (Session["User_Id"] != null)
                {
                    Session.Clear();
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Login Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error updating the account. Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

        #region Get
        public ActionResult GetUser(int userId)
        {
            try
            {
                if (Session["User_Id"] != null)
                {
                    if ((int)Session["User_Id"] == userId || (int)Session["Role_Id"] == 3)
                    {
                        ViewModels userVM = new ViewModels();
                        userVM.SingleUser = _mappersDAL.Map(_userAccess.GetUser(userId));
                        return View(userVM);
                    }
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Get User Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error getting the account. Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult GetUsers()
        {
            try
            {
                if (Session["User_Id"] != null)
                {
                    if ((int)Session["Role_Id"] == 3)
                    {
                        ViewModels usersVM = new ViewModels();
                        usersVM.Users = _mappersDAL.Map(_userAccess.GetUsers());
                        return View(usersVM);
                    }
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Get Users Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error getting the page. Please try again later.";
                return RedirectToAction("Index", "Home");
            }
        }
        #endregion

        #region Post
        [HttpGet]
        public ActionResult PostUser()
        {
            if (Session["User_Id"] == null)
            {
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult PostUser(ViewModels userToPost)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Users userDb = _mappersDAL.Map(_userAccess.GetUserByUserName(userToPost.SingleUser.UserName));
                    if (userDb.UserName == null)
                    {
                        userToPost.SingleUser.Salt = _passwordBLL.CreateSalt();
                        userToPost.SingleUser.Password = _passwordBLL.HashPassword(userToPost.SingleUser.Password, userToPost.SingleUser.Salt);
                        _userAccess.PostUser(_mappersDAL.Map(userToPost.SingleUser));

                        Users newUser = _mappersDAL.Map(_userAccess.GetUserByUserName(userToPost.SingleUser.UserName));

                        if (newUser != null)
                        {
                            _houseAccess.PostPoints(5, userToPost.SingleUser.User_Info.House_Id);
                            if (userToPost.SingleUser.User_Info.House_Id == 1)
                            {
                                TempData["Message"] = "5 points to GRYFFINDOR!";
                            }
                            else if (userToPost.SingleUser.User_Info.House_Id == 2)
                            {
                                TempData["Message"] = "5 points to SLYTHERIN!";
                            }
                            else if (userToPost.SingleUser.User_Info.House_Id == 3)
                            {
                                TempData["Message"] = "5 points to RAVENCLAW!";
                            }
                            else if (userToPost.SingleUser.User_Info.House_Id == 4)
                            {
                                TempData["Message"] = "5 points to HUFFLEPUFF!";
                            }
                            return RedirectToAction("Login", "Users", new { area = "" });
                        }
                        else
                        {
                            TempData["Message"] = "There was an error creating the account. Please try again later.";
                            return View(userToPost);
                        }
                    }
                    TempData["Message"] = "Username is already in use.";
                    return View(userToPost);
                }
                else
                {
                    TempData["Message"] = "Please enter valid data in all fields";
                    return View(userToPost);
                }
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Post User Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error creating the account. Please try again later.";
                return View(userToPost);
            }
        }
        #endregion

        #region Patch
        [HttpGet]
        public ActionResult PatchUser(int userId)
        {
            if (Session["User_Id"] != null)
            {
                if ((int)Session["User_Id"] == userId || (int)Session["Role_Id"] == 3)
                {
                    ViewModels user = new ViewModels();
                    user.SingleUser = _mappersDAL.Map(_userAccess.GetUser(userId));
                    return View(user);
                }
                return RedirectToAction("Index", "Home"); //404 error page
            }
            return RedirectToAction("Login");
        }

        [HttpPost]
        public ActionResult PatchUser(ViewModels userToPatch/*, bool isPasswordReset*/)
        {
            try
            {
                if (Session["User_Id"] != null)
                {
                    if (userToPatch.SingleUser.User_Id == (int)Session["User_Id"] || (int)Session["Role_Id"] == 3)
                    {
                        if (ModelState.IsValid)
                        {
                            Users userDb = _mappersDAL.Map(_userAccess.GetUser(userToPatch.SingleUser.User_Id));
                            userToPatch.SingleUser.UserName = userToPatch.SingleUser.UserName ?? userDb.UserName;
                            //if (isPasswordReset)
                            //{
                            //    userToPatch.SingleUser.Salt = _passwordBLL.CreateSalt();
                            //    userToPatch.SingleUser.Password = _passwordBLL.HashPassword(_passwordBLL.CreateSalt(), userToPatch.SingleUser.Salt); //figure out a way to send random string to user
                            //}
                            userToPatch.SingleUser.User_Info.Role_Id = userToPatch.SingleUser.User_Info.Role_Id ?? userDb.User_Info.Role_Id;
                            userToPatch.SingleUser.User_Info.Email = userToPatch.SingleUser.User_Info.Email ?? userDb.User_Info.Email;
                            if (userToPatch.SingleUser.User_Id == (int)Session["User_Id"])
                            {
                                userToPatch.SingleUser.User_Info.LastModifiedBy = userToPatch.SingleUser.UserName;
                            }
                            else
                            {
                                userToPatch.SingleUser.User_Info.LastModifiedBy = Session["UserName"].ToString();
                            }
                            userToPatch.SingleUser.User_Info.LastModifiedDate = DateTime.Now;

                            _userAccess.PatchUser(_mappersDAL.Map(userToPatch.SingleUser));
                            ViewModels user = new ViewModels();
                            user.SingleUser = _mappersDAL.Map(_userAccess.GetUser(userToPatch.SingleUser.User_Id));
                            if (userToPatch.SingleUser.UserName == user.SingleUser.UserName && userToPatch.SingleUser.User_Info.Email == user.SingleUser.User_Info.Email)
                            {
                                Session["UserName"] = user.SingleUser.UserName;
                                Session["Role_Id"] = user.SingleUser.User_Info.Role_Id;
                                return RedirectToAction("GetUser", new { userId = user.SingleUser.User_Id });
                            }
                            TempData["Message"] = "There was an error updating the account. Please try again later.";
                        }
                        TempData["Message"] = "Please enter valid data in all fields.";
                    }
                    return View(userToPatch); //404 error page
                }
                return RedirectToAction("Login");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Patch User Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error updating the account. Please try again later.";
                return View(userToPatch);
            }
        }

        [HttpGet]
        public ActionResult PatchPassword(int userId)
        {
            return View();
        }

        [HttpPost]
        public ActionResult PatchPassword(int userId, string newPassword)
        {
            return View();
        }
        #endregion

        #region Delete / Block
        [HttpGet]
        public ActionResult DeleteUser(int userId)
        {
            try
            {
                if (Session["User_Id"] != null && (int)Session["User_Id"] == userId || (int)Session["Role_Id"] == 3)
                {
                    _userAccess.DeleteUser(userId, (int)Session["User_Id"]);
                    Users userDb = _mappersDAL.Map(_userAccess.GetUser(userId));
                    if (userDb.UserName == null)
                    {
                        Session.Clear();
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["Message"] = "There was an error deleting the account. Please try again later.";
                    return View("GetUser", new { userId });
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Delete User Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error deleting the account. Please try again later.";
                return View("GetUser", new { userId });
            }
        }

        [HttpGet]
        public ActionResult BlockUser(int userId)
        {
            try
            {
                if (Session["User_Id"] != null && (int)Session["User_Id"] == userId || (int)Session["Role_Id"] == 3)
                {
                    _userAccess.BlockUser(userId, (int)Session["User_Id"]);
                    Users userDb = _mappersDAL.Map(_userAccess.GetUser(userId));
                    if (userDb.UserName == null)
                    {
                        Session.Clear();
                        return RedirectToAction("Index", "Home");
                    }
                    TempData["Message"] = "There was an error blocking the account. Please try again later.";
                    return View("GetUser", new { userId }); //error message
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(_errorLog))
                {
                    writer.WriteLine(DateTime.Now + " Delete User Presentation Layer Exception: " + ex + "/r/n");
                }
                TempData["Message"] = "There was an error blocking the account. Please try again later.";
                return View("GetUser", new { userId });
            }
        }
        #endregion
    }
}