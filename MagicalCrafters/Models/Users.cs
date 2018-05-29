using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Users
    {
        public int User_Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool isBlocked { get; set; }
        public Users_Info User_Info { get; set; }

        public Users()
        {
            User_Info = new Users_Info();
        }
    }
}