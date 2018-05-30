using MagicalCrafters.BLL.Models.BLL;
using MagicalCrafters.Models;

namespace MagicalCrafters.Mappers
{
    public class Mappers_BLL
    {
        #region Users
        public Users Map(UsersBLL userBLL)
        {
            Users user = new Users();
            user.User_Id = userBLL.User_Id;
            user.UserName = userBLL.UserName;
            user.Password = userBLL.Password;
            user.Salt = userBLL.Salt;
            user.isBlocked = userBLL.isBlocked;
            user.User_Info.Role_Id = userBLL.User_Info.Role_Id;
            user.User_Info.Source_Id = userBLL.User_Info.Source_Id;
            user.User_Info.House_Id = userBLL.User_Info.House_Id;
            user.User_Info.Email = userBLL.User_Info.Email;
            user.User_Info.CreatedDate = userBLL.User_Info.CreatedDate;
            user.User_Info.LastModifiedBy = userBLL.User_Info.LastModifiedBy;
            user.User_Info.LastModifiedDate = userBLL.User_Info.LastModifiedDate;
            user.User_Info.Points = userBLL.User_Info.Points;
            return user;
        }

        public UsersBLL Map(Users user)
        {
            UsersBLL userBLL = new UsersBLL();
            userBLL.User_Id = user.User_Id;
            userBLL.UserName = user.UserName;
            userBLL.Password = user.Password;
            userBLL.Salt = user.Salt;
            userBLL.isBlocked = user.isBlocked;
            userBLL.User_Info.Role_Id = user.User_Info.Role_Id;
            userBLL.User_Info.Source_Id = user.User_Info.Source_Id;
            userBLL.User_Info.House_Id = user.User_Info.House_Id;
            userBLL.User_Info.Email = user.User_Info.Email;
            userBLL.User_Info.CreatedDate = user.User_Info.CreatedDate;
            userBLL.User_Info.LastModifiedBy = user.User_Info.LastModifiedBy;
            userBLL.User_Info.LastModifiedDate = user.User_Info.LastModifiedDate;
            userBLL.User_Info.Points = user.User_Info.Points;
            return userBLL;
        }
        #endregion
    }
}