using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class CraftsBLL
    {
        public int Craft_Id { get; set; }
        public int User_Id { get; set; }
        public int Source_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isFlagged { get; set; }
        public bool isDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public UsersBLL User { get; set; }
        public Users_InfoBLL User_Info { get; set; }
    }
}
