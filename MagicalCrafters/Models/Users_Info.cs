using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Users_Info
    {
        public int User_Id { get; set; } //ad validation to this and views, add add points to houses in controllers and DAL
        [Display(Name = "User Type: ")]
        public int Role_Id { get; set; }
        public int Source_Id { get; set; }
        [Display(Name = "House: ")]
        public int House_Id { get; set; }
        [Display(Name = "Email: ")]
        public string Email { get; set; }
        [Display(Name = "Flagged: ")]
        public bool isFlagged { get; set; }
        //public bool isDeleted { get; set; }
        [Display(Name = "Created Date: ")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Last Modified By: ")]
        public string LastModifiedBy { get; set; }
        [Display(Name = "Last Modified Date: ")]
        public DateTime LastModifiedDate { get; set; }
        [Display(Name = "Points: ")]
        public int Points { get; set; }
        public Houses House { get; set; }
        public Roles Role { get; set; }

        public Users_Info()
        {
            House = new Houses();
            Role = new Roles();
        }
    }
}