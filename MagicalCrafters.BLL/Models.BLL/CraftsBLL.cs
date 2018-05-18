using System;

namespace MagicalCrafters.BLL.Models.BLL
{
    public class CraftsBLL : Users_InfoBLL
    {
        public int Craft_Id { get; set; }
        public new int Source_Id { get; set; }
        public new string Name { get; set; }
        public string Description { get; set; }
        public new bool isFlagged { get; set; }
        public new bool isDeleted { get; set; }
        public new DateTime CreatedDate { get; set; }
        public new string LastModifiedBy { get; set; }
        public new DateTime LastModifiedDate { get; set; }
    }
}
