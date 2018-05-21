using System;
using System.ComponentModel.DataAnnotations;

namespace MagicalCrafters.Models
{
    public class Crafts
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
        public Users User { get; set; }
        public Users_Info User_Info { get; set; }
    }
}