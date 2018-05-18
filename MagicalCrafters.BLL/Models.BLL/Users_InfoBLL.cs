using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class Users_InfoBLL : HousesBLL
    {
        public int User_Id { get; set; }
        public int Role_Id { get; set; }
        public new int Source_Id { get; set; }
        public string Email { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public new int Points { get; set; }
    }
}
