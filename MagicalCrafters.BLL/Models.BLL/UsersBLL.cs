using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class UsersBLL
    {
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool? isBlocked { get; set; }
        public Users_InfoBLL User_Info { get; set; }
        public HousesBLL House { get; set; }
        public RolesBLL Role { get; set; }
    }
}
