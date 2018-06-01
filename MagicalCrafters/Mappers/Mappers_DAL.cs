using MagicalCrafters.DAL.Models.DAL;
using MagicalCrafters.Models;
using System.Collections.Generic;

namespace MagicalCrafters.Mappers
{
    public class Mappers_DAL
    {

        #region Users
        //public Users MapUser(UsersDAL userDAL)
        //{
        //    Users user = new Users();

        //    var userDAL_type = userDAL.GetType();
        //    var user_type = user.GetType();

        //    foreach (var userDAL_field in userDAL_type.GetFields())
        //    {
        //        var user_field = user_type.GetField(userDAL_field.Name);
        //        user_field.SetValue(user, userDAL_field.GetValue(userDAL));
        //    }

        //    foreach (var userDAL_prop in userDAL_type.GetProperties())
        //    {
        //        var user_prop = user_type.GetProperty(userDAL_prop.Name);
        //        user_prop.SetValue(user, userDAL_prop.GetValue(userDAL));
        //    }

        //    return user;
        //}

        //public UsersDAL MapUser(Users user)
        //{
        //    UsersDAL userDAL = new UsersDAL();

        //    var user_type = user.GetType();
        //    var userDAL_type = userDAL.GetType();

        //    foreach (var user_field in user_type.GetFields())
        //    {
        //        var userDAL_field = userDAL_type.GetField(user_field.Name);
        //        userDAL_field.SetValue(userDAL, user_field.GetValue(user));
        //    }

        //    foreach (var user_prop in user_type.GetProperties())
        //    {
        //        var userDAL_prop = userDAL_type.GetProperty(user_prop.Name);
        //        userDAL_prop.SetValue(userDAL, user_prop.GetValue(user));
        //    }

        //    return userDAL;
        //}
        public Users Map(UsersDAL userDAL)
        {
            Users user = new Users();
            user.User_Id = userDAL.User_Id;
            user.UserName = userDAL.UserName;
            user.Password = userDAL.Password;
            user.Salt = userDAL.Salt;
            user.isBlocked = userDAL.isBlocked;
            user.User_Info.isFlagged = userDAL.User_Info.isFlagged;
            user.User_Info.Role_Id = userDAL.User_Info.Role_Id;
            user.User_Info.Source_Id = userDAL.User_Info.Source_Id;
            user.User_Info.House_Id = userDAL.User_Info.House_Id;
            user.User_Info.Email = userDAL.User_Info.Email;
            user.User_Info.CreatedDate = userDAL.User_Info.CreatedDate;
            user.User_Info.LastModifiedBy = userDAL.User_Info.LastModifiedBy;
            user.User_Info.LastModifiedDate = userDAL.User_Info.LastModifiedDate;
            user.User_Info.Points = userDAL.User_Info.Points;
            user.User_Info.House.Name = userDAL.User_Info.House.Name;
            return user;
        }

        public UsersDAL Map(Users user)
        {
            UsersDAL userDAL = new UsersDAL();
            userDAL.User_Id = user.User_Id;
            userDAL.UserName = user.UserName;
            userDAL.Password = user.Password;
            userDAL.Salt = user.Salt;
            userDAL.isBlocked = user.isBlocked;
            userDAL.User_Info.isFlagged = user.User_Info.isFlagged;
            userDAL.User_Info.Role_Id = user.User_Info.Role_Id;
            userDAL.User_Info.Source_Id = user.User_Info.Source_Id;
            userDAL.User_Info.House_Id = user.User_Info.House_Id;
            userDAL.User_Info.Email = user.User_Info.Email;
            userDAL.User_Info.CreatedDate = user.User_Info.CreatedDate;
            userDAL.User_Info.LastModifiedBy = user.User_Info.LastModifiedBy;
            userDAL.User_Info.LastModifiedDate = user.User_Info.LastModifiedDate;
            userDAL.User_Info.Points = user.User_Info.Points;
            userDAL.User_Info.House.Name = user.User_Info.House.Name;
            return userDAL;
        }

        public List<Users> Map (List<UsersDAL> usersDAL)
        {
            List<Users> users = new List<Users>();
            foreach (UsersDAL userDAL in usersDAL)
            {
                users.Add(Map(userDAL));
            }
            return users;       //add getusers view, fix that up, add a link to the layout
        }
        #endregion

        #region Users_Info
        //public Users_Info MapUserInfo(Users_InfoDAL userinfoDAL)
        //{
        //    Users_Info userinfo = new Users_Info();

        //    var userDAL_type = userinfoDAL.GetType();
        //    var user_type = userinfo.GetType();

        //    foreach (var userDAL_field in userDAL_type.GetFields())
        //    {
        //        var user_field = user_type.GetField(userDAL_field.Name);
        //        user_field.SetValue(userinfo, userDAL_field.GetValue(userinfoDAL));
        //    }

        //    foreach (var userDAL_prop in userDAL_type.GetProperties())
        //    {
        //        var user_prop = user_type.GetProperty(userDAL_prop.Name);
        //        user_prop.SetValue(userinfo, userDAL_prop.GetValue(userinfoDAL));
        //    }

        //    return userinfo;
        //}

        //public Users_InfoDAL MapUserInfo(Users_Info userinfo)
        //{
        //    Users_InfoDAL userinfoDAL = new Users_InfoDAL();

        //    var user_type = userinfo.GetType();
        //    var userDAL_type = userinfoDAL.GetType();

        //    foreach (var user_field in user_type.GetFields())
        //    {
        //        var userDAL_field = userDAL_type.GetField(user_field.Name);
        //        userDAL_field.SetValue(userinfoDAL, user_field.GetValue(userinfo));
        //    }

        //    foreach (var user_prop in user_type.GetProperties())
        //    {
        //        var userDAL_prop = userDAL_type.GetProperty(user_prop.Name);
        //        userDAL_prop.SetValue(userinfoDAL, user_prop.GetValue(userinfo));
        //    }

        //    return userinfoDAL;
        //}
        #endregion
    }
}