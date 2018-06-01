using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicalCrafters.Models
{
    public class Users
    {
        public int User_Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [Display(Name = "Username: ")]
        public string UserName { get; set; }
        //[Required(ErrorMessage = "Password is required")]
        [Display(Name = "Password: ")]
        public string Password { get; set; }
        //[NotMapped] // Does not effect with your database
        //[Required(ErrorMessage = "Confirm Password required")]
        //[Compare("Password", ErrorMessage = "Password doesn't match.")]
        //[Display(Name = "Confirm Password: ")]
        //public string ConfirmPassword { get; set; }
        public string Salt { get; set; }
        [Display(Name = "Blocked")]
        public bool? isBlocked { get; set; }
        public bool? isDeleted { get; set; }
        public Users_Info User_Info { get; set; }

        public Users()
        {
            User_Info = new Users_Info();
        }
    }
}