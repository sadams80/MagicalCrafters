using System;

namespace MagicalCrafters.DAL.Models.DAL
{
    public class UsersDAL
    {
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool isBlocked { get; set; }
        public Users_InfoDAL User_Info { get; set; }
        public HousesDAL House { get; set; }
        public RolesDAL Role { get; set; }
    }
}
