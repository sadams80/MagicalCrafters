using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Users_InfoBLL
    {
        public int User_Id { get; set; }
        public int? Role_Id { get; set; }
        public int Source_Id { get; set; }
        public int House_Id { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public long Points { get; set; }
        public HousesBLL House { get; set; }
        public UsersBLL User { get; set; }
        public RolesBLL Role { get; set; }
    }
}
