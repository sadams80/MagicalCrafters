using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Users_Info
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
        public int Source_Id { get; set; }
        public int House_Id { get; set; }
        public string Email { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public int Points { get; set; }
        public Houses House { get; set; }
        public Users User { get; set; }
        public Roles Role { get; set; }
    }
}