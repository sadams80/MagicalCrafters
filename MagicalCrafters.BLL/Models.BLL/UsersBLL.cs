using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class UsersBLL : Users_InfoBLL
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool isBlocked { get; set; }
    }
}
